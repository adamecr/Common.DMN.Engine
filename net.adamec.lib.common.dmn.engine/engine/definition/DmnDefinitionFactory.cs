using System;
using System.Collections.Generic;
using System.Linq;
using net.adamec.lib.common.core.logging;
using net.adamec.lib.common.dmn.engine.engine.decisions;
using net.adamec.lib.common.dmn.engine.engine.decisions.expression;
using net.adamec.lib.common.dmn.engine.engine.decisions.table;
using net.adamec.lib.common.dmn.engine.engine.decisions.table.definition;
using net.adamec.lib.common.dmn.engine.parser;
using net.adamec.lib.common.dmn.engine.parser.dto;

namespace net.adamec.lib.common.dmn.engine.engine.definition
{
    /// <summary>
    /// Factory that validates and transforms the <see cref="DmnModel"/> to <see cref="DmnDefinition"/> that can be executed within <see cref="runtime.DmnExecutionContext"/>
    /// </summary>
    /// <remarks>
    /// As the <see cref="DmnParser"/> is responsible for parsing the XML with the model, the <see cref="DmnDefinitionFactory"/> contains the
    /// main logic of checking the model and preparing it for the execution. It's recommended not to build <see cref="DmnDefinition"/> out of this factory, as
    /// the crucial validations may be missed.
    /// </remarks>
    public class DmnDefinitionFactory
    {
        /// <summary>
        /// Logger
        /// </summary>
        protected static ILogger Logger = CommonLogging.CreateLogger<DmnDefinitionFactory>();

        /// <summary>
        /// Variables used while executing the DMN model - can be used within the Decision Tables and/or Expressions
        /// In general, it holds the Input Data of DMN model and outputs from Decision Tables and/or Expressions
        /// </summary>
        protected Dictionary<string, DmnVariableDefinition> Variables { get; } = new Dictionary<string, DmnVariableDefinition>();

        /// <summary>
        /// Input data interface. Input data will be stored as Variables, complex objects are supported
        /// </summary>
        protected Dictionary<string, IDmnVariable> InputData { get; } = new Dictionary<string, IDmnVariable>();

        /// <summary>
        /// Dictionary of available decisions by name
        /// </summary>
        protected Dictionary<string, IDmnDecision> Decisions { get; } = new Dictionary<string, IDmnDecision>();

        /// <summary>
        /// Validates the <paramref name="source"/> model and creates the <see cref="DmnDefinition"/> from <see cref="DmnModel"/>
        /// </summary>
        /// <param name="source">Source DMN Model parsed from XML</param>
        ///<exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>    
        /// <returns>DMN model definition that can be used to execute the decisions within the <see cref="runtime.DmnExecutionContext"/></returns>
        public static DmnDefinition CreateDmnDefinition(DmnModel source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            var factory = new DmnDefinitionFactory(source);
            return new DmnDefinition(
                factory.Variables.ToDictionary(
                    v => v.Key,
                    v => (IDmnVariable)v.Value),
                factory.Decisions);
        }

        /// <summary>
        /// CTOR - Validates the <paramref name="source"/> model and creates the <see cref="DmnDefinition"/> from <see cref="DmnModel"/>
        /// </summary>
        /// <param name="source">Source DMN Model parsed from XML</param>
        ///<exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>   
        protected DmnDefinitionFactory(DmnModel source)
        {
            if (source == null) throw Logger.Fatal<ArgumentNullException>($"{nameof(source)} is null");

            //Process input data
            var inputDataById = new Dictionary<string, DmnVariableDefinition>();
            if (source.InputData != null) //it's not common, but OK to have no input data
            {
                ProcessInputDataSource(source, inputDataById);
            }

            //Process decisions
            var decisionsById = new Dictionary<string, IDmnDecision>();
            // ReSharper disable once InvertIf
            if (source.Decisions != null && source.Decisions.Count > 0)
            {
                foreach (var sourceDecision in source.Decisions)
                {
                    ProcessDecision(sourceDecision, source.Decisions, decisionsById, inputDataById);
                }
            }
            else
            {
                throw Logger.Fatal<DmnParserException>($"No decision in DMN model.");
            }
        }



        /// <summary>
        /// Validates the inputs of the <see cref="DmnModel"/> (<paramref name="source"/> and populates <see cref="InputData"/> and related <see cref="Variables"/>
        /// </summary>
        /// <param name="source">Source DMN Model parsed from XML</param>
        /// <param name="inputDataById">Temporary dictionary of input data (by ID) - input data are populated here</param>
        /// <exception cref="ArgumentNullException"><paramref name="source"/> or <paramref name="inputDataById"/> is null.</exception>
        /// <exception cref="DmnParserException">Missing input id</exception> 
        /// <exception cref="DmnParserException">Duplicate input data name</exception> 
        protected void ProcessInputDataSource(DmnModel source, IDictionary<string, DmnVariableDefinition> inputDataById)
        {
            if (source == null) throw Logger.Fatal<ArgumentNullException>($"{nameof(source)} is null");
            if (inputDataById == null) throw Logger.Fatal<ArgumentNullException>($"{nameof(inputDataById)} is null");
            if (source.InputData == null || source.InputData.Count == 0) return;//it's not common, but OK to have no input data

            //TODO    ?Input name in form varName:varType for (complex) input types
            foreach (var sourceInput in source.InputData)
            {
                if (string.IsNullOrWhiteSpace(sourceInput.Id)) throw Logger.Fatal<DmnParserException>($"Missing input id");

                var inputName = !string.IsNullOrWhiteSpace(sourceInput.Name) ? sourceInput.Name : sourceInput.Id;
                var variableName = DmnVariableDefinition.NormalizeVariableName(inputName);
                if (InputData.ContainsKey(variableName))
                    throw Logger.Fatal<DmnParserException>($"Duplicate input data name {variableName} (from {inputName})");

                var variable = new DmnVariableDefinition(variableName, inputName);
                InputData.Add(variableName, variable);
                Variables.Add(variableName, variable);
                inputDataById.Add(sourceInput.Id, variable);
            }
        }

        /// <summary>
        /// Validates the <paramref name="sourceDecision"/> within the <see cref="DmnModel"/>
        /// and creates <see cref="DmnExpressionDecision"/> or <see cref="DmnDecisionTable"/>
        /// </summary>
        /// <param name="sourceDecision">Decision source parsed from XML</param>
        /// <param name="allDecisions">All decisions parsed from XML source</param>
        /// <param name="decisionsById">Temporary dictionary of decisions (by ID) - decisions are added here</param>
        /// <param name="inputDataById">Temporary dictionary of input data (by ID)</param>
        ///<exception cref="ArgumentNullException"><paramref name="sourceDecision"/>, <paramref name="decisionsById"/> or <paramref name="inputDataById"/> is null.</exception>
        /// <exception cref="DmnParserException">Missing decision id</exception> 
        /// <exception cref="DmnParserException">Duplicate decision name</exception> 
        /// <exception cref="DmnParserException">Missing required decision reference</exception> 
        /// <exception cref="DmnParserException">Decision with given reference id not found</exception> 
        /// <exception cref="DmnParserException">Missing required input reference for</exception> 
        /// <exception cref="DmnParserException">Input with given reference id not found</exception> 
        protected IDmnDecision ProcessDecision(
             Decision sourceDecision, IReadOnlyCollection<Decision> allDecisions,
             IDictionary<string, IDmnDecision> decisionsById, IReadOnlyDictionary<string, DmnVariableDefinition> inputDataById)
        {

            if (sourceDecision == null) throw Logger.Fatal<ArgumentNullException>($"{nameof(sourceDecision)} is null");
            if (decisionsById == null) throw Logger.Fatal<ArgumentNullException>($"{nameof(decisionsById)} is null");
            if (inputDataById == null) throw Logger.Fatal<ArgumentNullException>($"{nameof(inputDataById)} is null");

            if (string.IsNullOrWhiteSpace(sourceDecision.Id)) throw Logger.Fatal<DmnParserException>($"Missing decision id");
            if (decisionsById.ContainsKey(sourceDecision.Id)) return decisionsById[sourceDecision.Id]; //already processed

            var decisionName = !string.IsNullOrWhiteSpace(sourceDecision.Name) ? sourceDecision.Name : sourceDecision.Id;
            if (Decisions.ContainsKey(decisionName)) throw Logger.Fatal<DmnParserException>($"Duplicate decision name {decisionName}");

            var requiredInputs = new List<IDmnVariable>();
            var requiredDecisions = new List<IDmnDecision>();
            //check dependencies
            if (sourceDecision.InformationRequirements != null)
            {
                foreach (var dependsOnDecisionRef in sourceDecision.InformationRequirements.Where(i => i.RequirementType == InformationRequirementType.Decision))
                {
                    var refId = dependsOnDecisionRef.Ref;
                    if (string.IsNullOrWhiteSpace(refId)) throw Logger.Fatal<DmnParserException>($"Missing required decision reference for {decisionName}");

                    if (decisionsById.TryGetValue(refId, out var requiredDecision))
                    {
                        //decision already processed, just add "new" inputs
                        AddNewRequiredInputs(requiredDecision.RequiredInputs, requiredInputs);
                        requiredDecisions.Add(requiredDecision);
                        continue;
                    }

                    var sourceDependsOnDecision = allDecisions.FirstOrDefault(d => d.Id == refId);
                    if (sourceDependsOnDecision == null) throw Logger.Fatal<DmnParserException>($"Decision with reference {refId} for {decisionName} not found");

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
                    if (string.IsNullOrWhiteSpace(refId)) throw Logger.Fatal<DmnParserException>($"Missing required input reference for {decisionName}");
                    if (!inputDataById.ContainsKey(refId)) throw Logger.Fatal<DmnParserException>($"Input with reference {refId} for {decisionName} not found");
                    newInputs.Add(inputDataById[refId]);
                }
                AddNewRequiredInputs(newInputs, requiredInputs);
            }

            //Decision factory
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

        /// <summary>
        /// Validates the <paramref name="sourceTable"/> within the <see cref="DmnModel"/>
        /// and creates <see cref="DmnDecisionTable"/>
        /// </summary>
        /// <param name="sourceTable">Decision source parsed from XML</param>
        /// <param name="decisionName">Unique name of decision</param>
        /// <param name="requiredInputs">Inputs required by decision</param>
        /// <param name="requiredDecisions">Decisions, the decision table depends on</param>
        ///<exception cref="ArgumentNullException"><paramref name="sourceTable"/>, <paramref name="decisionName"/>, <paramref name="requiredInputs"/> or <paramref name="requiredDecisions"/> is null.</exception>
        ///<exception cref="ArgumentException"><paramref name="decisionName"/> is empty</exception>    
        /// <exception cref="DmnParserException">No outputs for decision table</exception> 
        /// <exception cref="DmnParserException">No inputs for decision table</exception> 
        /// <exception cref="DmnParserException">Input variable for decision table not found</exception> 
        /// <exception cref="DmnParserException">No rules for decision table</exception> 
        /// <exception cref="DmnParserException">Number of rule input entries doesn't match the number of inputs for decision table</exception> 
        /// <exception cref="DmnParserException">Number of rule output entries doesn't match the number of outputs for decision table</exception> 
        protected DmnDecisionTable CreateDecisionTable(
            DecisionTable sourceTable,
            string decisionName,
            List<IDmnVariable> requiredInputs,
            List<IDmnDecision> requiredDecisions)
        {
            if (sourceTable == null) throw Logger.Fatal<ArgumentNullException>($"{nameof(sourceTable)} is null");
            if (decisionName == null) throw Logger.Fatal<ArgumentNullException>($"{nameof(decisionName)} is null");
            if (string.IsNullOrWhiteSpace(decisionName)) throw Logger.Fatal<ArgumentException>($"{nameof(decisionName)} is empty");
            if (requiredInputs == null) throw Logger.Fatal<ArgumentNullException>($"{nameof(requiredInputs)} is null");
            if (requiredDecisions == null) throw Logger.Fatal<ArgumentNullException>($"{nameof(requiredDecisions)} is null");

            //prepare outputs
            if (sourceTable.Outputs == null || sourceTable.Outputs.Count < 1)
                throw Logger.Fatal<DmnParserException>($"No outputs for decision table {decisionName}");

            var outputs = new List<DmnDecisionTableOutput>();
            var outputIdx = 0;
            foreach (var sourceOutput in sourceTable.Outputs)
            {
                //Label, Name, Id
                var sourceVariableName =
                    !string.IsNullOrWhiteSpace(sourceOutput.Label) ? sourceOutput.Label :
                    !string.IsNullOrWhiteSpace(sourceOutput.Name) ? sourceOutput.Name :
                    sourceOutput.Id;

                var variableName = DmnVariableDefinition.NormalizeVariableName(sourceVariableName);
                if (!Variables.TryGetValue(variableName, out var variable))
                {
                    //create variable
                    variable = new DmnVariableDefinition(variableName);
                    Variables.Add(variableName, variable);
                }

                variable.AddValueSetter($"Table Decision {decisionName}");
                CheckAndUpdateVariableType(variable, sourceOutput.TypeRef);

                var allowedValues = sourceOutput.AllowedOutputValues?.Values;
                outputs.Add(new DmnDecisionTableOutput(outputIdx, variable, allowedValues));
                outputIdx++;
            }

            //prepare inputs
            if (sourceTable.Inputs == null || sourceTable.Inputs.Count < 1)
                throw Logger.Fatal<DmnParserException>($"No inputs for decision table {decisionName}");

            var inputs = new List<DmnDecisionTableInput>();
            var inputIdx = 0;
            foreach (var sourceInput in sourceTable.Inputs)
            {
                //Expression or  variable by Label,  Id
                DmnVariableDefinition variable = null;
                string expression = null;

                if (string.IsNullOrWhiteSpace(sourceInput.InputExpression?.Text))
                {
                    var sourceVariableName = !string.IsNullOrWhiteSpace(sourceInput.Label) ? sourceInput.Label : sourceInput.Id;
                    var variableName = DmnVariableDefinition.NormalizeVariableName(sourceVariableName);

                    if (!Variables.TryGetValue(variableName, out variable))
                    {
                        throw Logger.Fatal<DmnParserException>(
                            $"Input variable {sourceVariableName} ({variableName}) for decision table {decisionName} not found");
                    }

                    CheckAndUpdateVariableType(variable, sourceInput.InputExpression?.TypeRef);
                }
                else
                {
                    expression = sourceInput.InputExpression.Text;
                }

                var allowedValues = sourceInput.AllowedInputValues?.Values;
                inputs.Add(new DmnDecisionTableInput(inputIdx, variable, expression, allowedValues));
                inputIdx++;
            }

            //prepare rules
            if (sourceTable.Rules == null || sourceTable.Rules.Count < 1)
                throw Logger.Fatal<DmnParserException>($"No rules for decision table {decisionName}");

            var rules = new List<DmnDecisionTableRule>();
            var ruleIdx = 0;
            foreach (var sourceRule in sourceTable.Rules)
            {
                if (sourceRule.InputEntries == null || sourceRule.InputEntries.Count != inputs.Count)
                    throw Logger.Fatal<DmnParserException>($"Number of input entries doesn't match the number of inputs for decision table {decisionName}. Rule Id:{sourceRule.Id} ");

                if (sourceRule.OutputEntries == null || sourceRule.OutputEntries.Count != outputs.Count)
                    throw Logger.Fatal<DmnParserException>($"Number of output entries doesn't match the number of outputs for decision table {decisionName}. Rule Id:{sourceRule.Id} ");

                var ruleInputs = new List<DmnDecisionTableRuleInput>();
                var ruleOutputs = new List<DmnDecisionTableRuleOutput>();
                var ruleName = string.IsNullOrWhiteSpace(sourceRule.Label) ? sourceRule.Id : sourceRule.Label;

                //inputs
                var ruleInputIdx = 0;
                foreach (var sourceRuleInputEntry in sourceRule.InputEntries)
                {
                    if (!string.IsNullOrWhiteSpace(sourceRuleInputEntry.Text) && sourceRuleInputEntry.Text != "-") //don't create rule inputs with no condition - can be also represented as single dash
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

                rules.Add(new DmnDecisionTableRule(ruleIdx, ruleName, ruleInputs.ToArray(), ruleOutputs.ToArray(), sourceRule.Description));
                ruleIdx++;
            }

            var decisionTable = new DmnDecisionTable(
                decisionName,
                sourceTable.HitPolicy, sourceTable.Aggregation,
                inputs.ToArray(), outputs.ToArray(), rules.ToArray(),
                requiredInputs, requiredDecisions);
            return decisionTable;
        }

        /// <summary>
        /// Validates the <paramref name="sourceDecision"/> within the <see cref="DmnModel"/>
        /// and creates <see cref="DmnExpressionDecision"/>
        /// </summary>
        /// <param name="sourceDecision">Decision source parsed from XML</param>
        /// <param name="decisionName">Unique name of decision</param>
        /// <param name="requiredInputs">Inputs required by decision</param>
        /// <param name="requiredDecisions">Decisions, the decision table depends on</param>
        ///<exception cref="ArgumentNullException"><paramref name="sourceDecision"/>, <paramref name="decisionName"/>, <paramref name="requiredInputs"/> or <paramref name="requiredDecisions"/> is null.</exception>
        ///<exception cref="ArgumentException"><paramref name="decisionName"/> is empty</exception>    
        /// <exception cref="DmnParserException">Missing expression for expression decision</exception> 
        /// <exception cref="DmnParserException">Missing output variable for expression decision</exception> 
        protected DmnExpressionDecision CreateExpressionDecision(
           Decision sourceDecision,
           string decisionName,
           IReadOnlyCollection<IDmnVariable> requiredInputs,
           IReadOnlyCollection<IDmnDecision> requiredDecisions)
        {
            if (sourceDecision == null) throw Logger.Fatal<ArgumentNullException>($"{nameof(sourceDecision)} is null");
            if (decisionName == null) throw Logger.Fatal<ArgumentNullException>($"{nameof(decisionName)} is null");
            if (string.IsNullOrWhiteSpace(decisionName)) throw Logger.Fatal<ArgumentException>($"{nameof(decisionName)} is empty");
            if (requiredInputs == null) throw Logger.Fatal<ArgumentNullException>($"{nameof(requiredInputs)} is null");
            if (requiredDecisions == null) throw Logger.Fatal<ArgumentNullException>($"{nameof(requiredDecisions)} is null");

            //prepare output variable
            if (sourceDecision.OutputVariable == null) throw Logger.Fatal<DmnParserException>($"Missing output variable for expression decision {decisionName}");
            var sourceVariableName = !string.IsNullOrWhiteSpace(sourceDecision.OutputVariable.Name)
                ? sourceDecision.OutputVariable.Name
                : sourceDecision.OutputVariable.Id;
            var variableName = DmnVariableDefinition.NormalizeVariableName(sourceVariableName);
            if (!Variables.TryGetValue(variableName, out var variable))
            {
                //create variable
                variable = new DmnVariableDefinition(variableName);
                Variables.Add(variableName, variable);
            }

            variable.AddValueSetter($"Expression Decision {decisionName}");
            CheckAndUpdateVariableType(variable, sourceDecision.OutputVariable.TypeRef);

            //prepare expression
            if (string.IsNullOrWhiteSpace(sourceDecision.Expression.Text))
                throw Logger.Fatal<DmnParserException>($"Missing expression for expression decision {decisionName}");
            var expr = $"{sourceDecision.Expression.Text}";

            //create
            var expressionDecision = new DmnExpressionDecision(decisionName, expr, variable, requiredInputs, requiredDecisions);
            return expressionDecision;
        }

        /// <summary>
        /// Adds <paramref name="newInputs"/> into the list of <paramref name="requiredInputs"/>.
        /// <paramref name="newInputs"/> can be null or empty (no addition then)
        /// </summary>
        /// <param name="newInputs"></param>
        /// <param name="requiredInputs"></param>
        ///<exception cref="ArgumentNullException"><paramref name="requiredInputs"/> is null.</exception>
        protected static void AddNewRequiredInputs(IReadOnlyCollection<IDmnVariable> newInputs, List<IDmnVariable> requiredInputs)
        {
            if (requiredInputs == null) throw Logger.Fatal<ArgumentNullException>($"{nameof(requiredInputs)} is null.");
            if (newInputs == null || !newInputs.Any()) return;

            foreach (var requiredInput in newInputs)
            {
                if (!requiredInputs.Exists(i => i.Name == requiredInput.Name))
                    requiredInputs.Add(requiredInput);
            }
        }

        /// <summary>
        /// Assigns the <paramref name="variable"/> with <see cref="Type"/> corresponding to the <paramref name="typeName"/>.
        /// When the variable already contains the type information, it must match with the <paramref name="typeName"/>
        /// </summary>
        /// <param name="variable">Variable to check or update. If null, function returns without an exception</param>
        /// <param name="typeName">Type name to assign. If null or empty, function returns without an exception (assuming that the type is not know yet)</param>
        /// <exception cref="DmnParserException">Type for variable don't match the one assigned before</exception>
        protected static void CheckAndUpdateVariableType(DmnVariableDefinition variable, string typeName)
        {
            if (string.IsNullOrWhiteSpace(typeName)) return;
            if (variable == null) return;

            var parsedType = ParseTypeName(typeName);
            if (variable.Type == null)
            {
                //set (update)
                variable.SetRecognizedType(parsedType);
            }
            else
            {
                //check
                if (variable.Type != parsedType)
                    throw Logger.Fatal<DmnParserException>($"Types for variable {variable.Name} don't match: {variable.Type} vs. {parsedType}");
            }
        }

        /// <summary>
        /// Parses the type name to <see cref="Type"/>
        /// </summary>
        /// <param name="typeName">Type name to parse</param>
        /// <returns><see cref="Type"/> corresponding to <paramref name="typeName"/></returns>
        /// <exception cref="ArgumentException"><paramref name="typeName"/> is null or empty</exception>
        /// <exception cref="DmnParserException">Unsupported type name</exception>
        private static Type ParseTypeName(string typeName)
        {
            if (string.IsNullOrWhiteSpace(typeName))
                throw Logger.Fatal<ArgumentException>($"{nameof(typeName)} is null or empty");

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
