using System;
using System.Collections.Generic;
using System.Linq;
using net.adamec.lib.common.dmn.engine.engine.decisions;
using net.adamec.lib.common.dmn.engine.engine.decisions.table;
using net.adamec.lib.common.dmn.engine.parser;
using net.adamec.lib.common.dmn.engine.parser.dto;
using net.adamec.lib.common.logging;

namespace net.adamec.lib.common.dmn.engine.engine.definition
{
    public class DmnDefinitionFactory //TODO Definition (abstraction Model -> Definition -> Context) documentation
    {
        protected static ILogger Logger = CommonLogging.CreateLogger<DmnDefinitionFactory>();

        /// <summary>
        /// Variables used while executing the DMN model - can be used within the Decision Tables and/or Expressions
        /// In general, it holds the Input Data of DMN model and outputs from Decision Tables and/or Expressions
        /// </summary>
        public IDictionary<string, DmnVariableDefinition> Variables { get; } = new Dictionary<string, DmnVariableDefinition>();

        /// <summary>
        /// Input data interface. Input data will be stored as Variables, complex objects are supported
        /// </summary>
        public IDictionary<string, DmnVariableDefinition> InputData { get; } = new Dictionary<string, DmnVariableDefinition>();

        public IDictionary<string, IDmnDecision> Decisions { get; } = new Dictionary<string, IDmnDecision>();

        public static DmnDefinition CreateDmnDefinition(DmnModel source)
        {
            var factory = new DmnDefinitionFactory(source);
            return new DmnDefinition(factory.Variables, factory.InputData, factory.Decisions);
        }

        protected DmnDefinitionFactory(DmnModel source)
        {
            //Process input data
            var inputDataById = new Dictionary<string, DmnVariableDefinition>();
            if (source.InputData != null)
            {
                ProcessInputDataSource(source, inputDataById);
            }

            //Process decisions
            var decisionsById = new Dictionary<string, IDmnDecision>();
            // ReSharper disable once InvertIf
            if (source.Decisions != null)
            {
                foreach (var sourceDecision in source.Decisions)
                {
                    ProcessDecision(sourceDecision, source.Decisions, decisionsById, inputDataById);
                }
            }
        }

        protected void ProcessInputDataSource(DmnModel source, IDictionary<string, DmnVariableDefinition> inputDataById)
        {
            //TODO    ?Input name in form varName:varType for (complex) input types
            //TODO ?Required input parameters check for null??
            foreach (var sourceInput in source.InputData)
            {
                if (string.IsNullOrEmpty(sourceInput.Id)) throw new DmnParserException($"Missing input id");

                var inputName = !string.IsNullOrEmpty(sourceInput.Name) ? sourceInput.Name : sourceInput.Id;
                var variableName = NormalizeVariableName(inputName);
                if (InputData.ContainsKey(variableName))
                    throw new DmnParserException($"Duplicate input data name {variableName} (from {inputName})");

                var variable = new DmnVariableDefinition(variableName) { IsInputParameter = true, HasValueSetter = true };
                variable.ValueSetters.Add($"Input: {inputName}");
                InputData.Add(variableName, variable);
                Variables.Add(variableName, variable);
                inputDataById.Add(sourceInput.Id, variable);
            }
        }

        protected IDmnDecision ProcessDecision(
             Decision sourceDecision, IReadOnlyCollection<Decision> allDecisions,
             IDictionary<string, IDmnDecision> decisionsById, IDictionary<string, DmnVariableDefinition> inputDataById)
        {
            if (string.IsNullOrEmpty(sourceDecision.Id)) throw new DmnParserException($"Missing decision id");

            if (decisionsById.ContainsKey(sourceDecision.Id)) return decisionsById[sourceDecision.Id]; //already processed

            var decisionName = !string.IsNullOrEmpty(sourceDecision.Name) ? sourceDecision.Name : sourceDecision.Id;
            if (Decisions.ContainsKey(decisionName)) throw new DmnParserException($"Duplicate decision name {decisionName}");

            var requiredInputs = new List<DmnVariableDefinition>();
            var requiredDecisions = new List<IDmnDecision>();
            //check dependencies
            if (sourceDecision.InformationRequirements != null)
            {
                foreach (var dependsOnDecisionRef in sourceDecision.InformationRequirements.Where(i => i.RequirementType == InformationRequirementType.Decision))
                {
                    var refId = dependsOnDecisionRef.Ref;
                    if (string.IsNullOrEmpty(refId)) throw new DmnParserException($"Missing required decision reference for {decisionName}");

                    if (decisionsById.ContainsKey(refId))
                    {
                        //decision already processed, just add "new" inputs
                        var requiredDecision = decisionsById[refId];
                        AddNewRequiredInputs(requiredDecision.RequiredInputs, requiredInputs);
                        requiredDecisions.Add(requiredDecision);
                        continue;
                    }

                    var sourceDependsOnDecision = allDecisions.FirstOrDefault(d => d.Id == refId);
                    if (sourceDependsOnDecision == null) throw new DmnParserException($"Decision with reference {refId} for {decisionName} not found");

                    var dependsOnDecision = ProcessDecision(sourceDependsOnDecision, allDecisions, decisionsById, inputDataById); //process needed decision first
                    AddNewRequiredInputs(dependsOnDecision.RequiredInputs, requiredInputs);
                    requiredDecisions.Add(dependsOnDecision);
                }
            }

            //validate input references
            if (sourceDecision.InformationRequirements != null)
            {
                var newInputs = new List<DmnVariableDefinition>();
                foreach (var informationRequirement in sourceDecision.InformationRequirements.Where(d => d.RequirementType == InformationRequirementType.Input))
                {
                    var refId = informationRequirement.Ref;
                    if (string.IsNullOrEmpty(refId)) throw new DmnParserException($"Missing required input reference for {decisionName}");
                    if (!inputDataById.ContainsKey(refId)) throw new DmnParserException($"Input with reference {refId} for {decisionName} not found");
                    newInputs.Add(inputDataById[refId]);
                }
                AddNewRequiredInputs(newInputs, requiredInputs);
            }

            //Factory
            IDmnDecision decision;
            if (sourceDecision.DecisionTable == null)
            {
                //expression
                decision = CreateExpressionDecision(sourceDecision, decisionName, requiredInputs, requiredDecisions);
            }
            else
            {
                //decision table
                decision = CreateDecisionTable(sourceDecision.DecisionTable, decisionName, requiredInputs, requiredDecisions);
            }

            Decisions.Add(decisionName, decision);
            decisionsById.Add(sourceDecision.Id, decision);
            return decision;
        }

        protected DmnDecisionTable CreateDecisionTable(DecisionTable sourceTable, string decisionName,
            List<DmnVariableDefinition> requiredInputs, List<IDmnDecision> requiredDecisions)
        {
            //prepare outputs
            if (sourceTable.Outputs == null || sourceTable.Outputs.Count < 1)
                throw new DmnParserException($"No outputs for decision table {decisionName}");

            var outputs = new List<DmnDecisionTableOutput>();
            var outputIdx = 0;
            foreach (var sourceOutput in sourceTable.Outputs)
            {
                //Label, Name, Id
                var sourceVariableName =
                    !string.IsNullOrEmpty(sourceOutput.Label) ? sourceOutput.Label :
                    !string.IsNullOrEmpty(sourceOutput.Name) ? sourceOutput.Name :
                    sourceOutput.Id;

                var variableName = NormalizeVariableName(sourceVariableName);
                DmnVariableDefinition variable;
                if (!Variables.ContainsKey(variableName))
                {
                    //create variable
                    variable = new DmnVariableDefinition(variableName);
                    Variables.Add(variableName, variable);
                }
                else
                {
                    variable = Variables[variableName];
                }

                variable.HasValueSetter = true;
                variable.ValueSetters.Add($"Table Decision {decisionName}");
                CheckAndUpdateVariableType(variable, sourceOutput.TypeRef);

                var allowedValues = sourceOutput.AllowedOutputValues?.Values?.ToList();
                outputs.Add(new DmnDecisionTableOutput(outputIdx, variable, allowedValues));
                outputIdx++;
            }

            //prepare inputs
            if (sourceTable.Inputs == null || sourceTable.Inputs.Count < 1)
                throw new DmnParserException($"No inputs for decision table {decisionName}");

            var inputs = new List<DmnDecisionTableInput>();
            var inputIdx = 0;
            foreach (var sourceInput in sourceTable.Inputs)
            {
                //Expression or  variable by Label,  Id
                DmnVariableDefinition variable = null;
                string expression = null;

                if (string.IsNullOrEmpty(sourceInput.InputExpression?.Text))
                {
                    var sourceVariableName = !string.IsNullOrEmpty(sourceInput.Label) ? sourceInput.Label : sourceInput.Id;
                    var variableName = NormalizeVariableName(sourceVariableName);

                    if (!Variables.ContainsKey(variableName))
                    {
                        throw new DmnParserException(
                            $"Input variable {sourceVariableName} ({variableName}) for decision table {decisionName} not found");
                    }

                    variable = Variables[variableName];
                    CheckAndUpdateVariableType(variable, sourceInput.InputExpression?.TypeRef);
                }
                else
                {
                    expression = sourceInput.InputExpression.Text;
                }

                var allowedValues = sourceInput.AllowedInputValues?.Values?.ToList();
                inputs.Add(new DmnDecisionTableInput(inputIdx, variable, expression, allowedValues));
                inputIdx++;
            }

            //prepare rules
            if (sourceTable.Rules == null || sourceTable.Rules.Count < 1)
                throw new DmnParserException($"No rules for decision table {decisionName}");

            var rules = new List<DmnDecisionTableRule>();
            var ruleIdx = 0;
            foreach (var sourceRule in sourceTable.Rules)
            {
                if (sourceRule.InputEntries == null || sourceRule.InputEntries.Count != inputs.Count)
                    throw new DmnParserException($"Number of input entries doesn't match the number of inputs for decision table {decisionName}. Rule Id:{sourceRule.Id} ");

                if (sourceRule.OutputEntries == null || sourceRule.OutputEntries.Count != outputs.Count)
                    throw new DmnParserException($"Number of output entries doesn't match the number of outputs for decision table {decisionName}. Rule Id:{sourceRule.Id} ");

                var ruleInputs = new List<DmnDecisionTableRuleInput>();
                var ruleOutputs = new List<DmnDecisionTableRuleOutput>();
                var ruleName = string.IsNullOrEmpty(sourceRule.Label) ? sourceRule.Id : sourceRule.Label;

                //inputs
                var ruleInputIdx = 0;
                foreach (var sourceRuleInputEntry in sourceRule.InputEntries)
                {
                    if (!string.IsNullOrEmpty(sourceRuleInputEntry.Text) && sourceRuleInputEntry.Text != "-") //don't create rule inputs with no condition - can be also represented as single dash
                    {
                        var ruleInput = new DmnDecisionTableRuleInput(inputs[ruleInputIdx], sourceRuleInputEntry.Text);
                        ruleInputs.Add(ruleInput);
                    }
                    ruleInputIdx++;
                }

                //outputs
                var ruleOutputIdx = 0;
                foreach (var sourceRuleOutputEntry in sourceRule.OutputEntries)
                {
                    var ruleOutput = new DmnDecisionTableRuleOutput(outputs[ruleOutputIdx], sourceRuleOutputEntry.Text);
                    ruleOutputs.Add(ruleOutput);
                    ruleOutputIdx++;
                }

                rules.Add(new DmnDecisionTableRule(ruleIdx, ruleName, ruleInputs, ruleOutputs, sourceRule.Description));
                ruleIdx++;
            }

            var decisionTable = new DmnDecisionTable(
                decisionName,
                sourceTable.HitPolicy, sourceTable.Aggregation,
                inputs, outputs, rules,
                requiredInputs, requiredDecisions);
            return decisionTable;
        }

        protected DmnExpressionDecision CreateExpressionDecision(
            Decision sourceDecision, string decisionName,
            List<DmnVariableDefinition> requiredInputs, List<IDmnDecision> requiredDecisions)
        {
            //prepare output variable
            var sourceVariableName = !string.IsNullOrEmpty(sourceDecision.OutputVariable.Name)
                ? sourceDecision.OutputVariable.Name
                : sourceDecision.OutputVariable.Id;
            var variableName = NormalizeVariableName(sourceVariableName);
            DmnVariableDefinition variable;
            if (!Variables.ContainsKey(variableName))
            {
                //create variable
                variable = new DmnVariableDefinition(variableName);
                Variables.Add(variableName, variable);
            }
            else
            {
                variable = Variables[variableName];
            }

            variable.HasValueSetter = true;
            variable.ValueSetters.Add($"Expression Decision {decisionName}");
            CheckAndUpdateVariableType(variable, sourceDecision.OutputVariable.TypeRef);

            //prepare expression
            if (string.IsNullOrEmpty(sourceDecision.Expression.Text))
                throw new DmnParserException($"Missing expression for expression decision {decisionName}");
            var expr = $"{sourceDecision.Expression.Text}";

            //create
            var expressionDecision = new DmnExpressionDecision(decisionName, expr, variable, requiredInputs, requiredDecisions);
            return expressionDecision;
        }

        protected static void AddNewRequiredInputs(IReadOnlyCollection<DmnVariableDefinition> newInputs, List<DmnVariableDefinition> requiredInputs)
        {
            if (newInputs == null || !newInputs.Any()) return;

            foreach (var requiredInput in newInputs)
            {
                if (!requiredInputs.Exists(i => i.Name == requiredInput.Name))
                    requiredInputs.Add(requiredInput);
            }
        }

        protected static string NormalizeVariableName(string name)
        {
            var retVal = name.Trim().Replace(' ', '_');
            return retVal;
        }

        protected static void CheckAndUpdateVariableType(DmnVariableDefinition variable, string typeName)
        {
            if (string.IsNullOrEmpty(typeName)) return;
            if (variable == null) return;

            var parsedType = ParseTypeName(typeName);
            if (variable.Type == null)
            {
                //set (update)
                variable.Type = parsedType;
            }
            else
            {
                //check
                if (variable.Type != parsedType)
                    throw Logger.Fatal<DmnParserException>($"Types for variable {variable.Name} don't match: {variable.Type} vs. {parsedType}");
            }
        }

        private static Type ParseTypeName(string typeName)
        {
            typeName = typeName.ToLower();
            switch (typeName)
            {
                case "string": return typeof(string);
                case "boolean": return typeof(bool);
                case "integer": return typeof(int);
                case "long": return typeof(long);
                case "double": return typeof(double);
                case "date": return typeof(DateTime);
                default:
                    throw Logger.Fatal<DmnParserException>($"Unsupported type name {typeName}");
            }
        }
    }
}
