using System;
using System.Collections.Generic;
using System.Linq;
using net.adamec.lib.common.core.logging;
using net.adamec.lib.common.dmn.engine.engine.decisions;
using net.adamec.lib.common.dmn.engine.engine.decisions.expression;
using net.adamec.lib.common.dmn.engine.engine.decisions.table;
using net.adamec.lib.common.dmn.engine.engine.decisions.table.definition;
using net.adamec.lib.common.dmn.engine.engine.definition.extensions;
using net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram;
using net.adamec.lib.common.dmn.engine.parser;
using net.adamec.lib.common.dmn.engine.parser.dto;

namespace net.adamec.lib.common.dmn.engine.engine.definition
{
    /// <summary>
    /// Factory that validates and transforms the <see cref="DmnModel"/> to <see cref="DmnDefinition"/> that can be executed within <see cref="execution.context.DmnExecutionContext"/>
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
        /// Source DMN Model parsed from XML
        /// </summary>
        protected DmnModel SourceModel { get; }

        /// <summary>
        /// Variables used while executing the DMN model - can be used within the Decision Tables and/or Expressions
        /// In general, it holds the Input Data of DMN model and outputs from Decision Tables and/or Expressions
        /// Dictionary by Variable name
        /// </summary>
        protected Dictionary<string, DmnVariableDefinition> Variables { get; } = new Dictionary<string, DmnVariableDefinition>();

        /// <summary>
        /// Input data interface. Input data will be stored as Variables, complex objects are supported. Dictionary by Input/Variable name
        /// </summary>
        protected Dictionary<string, IDmnVariable> InputData { get; } = new Dictionary<string, IDmnVariable>();

        /// <summary>
        /// Dictionary of available decisions by name
        /// </summary>
        protected Dictionary<string, IDmnDecision> Decisions { get; } = new Dictionary<string, IDmnDecision>();

        /// <summary>
        /// Dictionary of input data variable definitions (by ID)
        /// </summary>
        protected Dictionary<string, DmnVariableDefinition> InputDataById { get; } = new Dictionary<string, DmnVariableDefinition>();

        /// <summary>
        /// Dictionary of decision definitions (by ID)
        /// </summary>
        protected Dictionary<string, IDmnDecision> DecisionsById { get; } = new Dictionary<string, IDmnDecision>();

        /// <summary>
        /// Protected CTOR
        /// </summary>
        /// <param name="sourceModel">Source DMN Model parsed from XML</param>
        /// <exception cref="ArgumentNullException"><paramref name="sourceModel"/> is null.</exception> 
        protected DmnDefinitionFactory(DmnModel sourceModel)
        {
            SourceModel = sourceModel ?? throw Logger.Fatal<ArgumentNullException>($"{nameof(sourceModel)} is null");
        }


        /// <summary>
        /// Validates the <paramref name="source"/> model and creates the <see cref="DmnDefinition"/> from <see cref="DmnModel"/>
        /// </summary>
        /// <param name="source">Source DMN Model parsed from XML</param>
        /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>    
        /// <returns>DMN model definition that can be used to execute the decisions within the <see cref="execution.context.DmnExecutionContext"/></returns>
        public static DmnDefinition CreateDmnDefinition(DmnModel source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            var factory = new DmnDefinitionFactory(source);
            return factory.ProcessModel();
        }

        /// <summary>
        /// Validates the <see cref="SourceModel"/> model and creates the <see cref="DmnDefinition"/> from <see cref="DmnModel"/>
        /// </summary>
        /// <exception cref="InvalidOperationException"><see cref="SourceModel"/> is null.</exception>   
        /// <returns>DMN model definition that can be used to execute the decisions within the <see cref="execution.context.DmnExecutionContext"/></returns>
        protected virtual DmnDefinition ProcessModel()
        {
            if (SourceModel == null) throw Logger.Fatal<InvalidOperationException>($"{nameof(SourceModel)} is null");

            //-----------------------------------------------------------------
            // Process DMN Model
            //-----------------------------------------------------------------

            //Process input data
            if (SourceModel.InputData != null) //it's not common, but OK to have no input data
            {
                ProcessInputDataSource();
            }

            //Process decisions
            if (SourceModel.Decisions != null && SourceModel.Decisions.Count > 0)
            {
                foreach (var sourceDecision in SourceModel.Decisions)
                {
                    ProcessDecision(sourceDecision);
                }
            }
            else
            {
                throw Logger.Fatal<DmnParserException>($"No decision in DMN model.");
            }

            //-----------------------------------------------------------------
            // Create DMN Definition
            //-----------------------------------------------------------------
            var definition = new DmnDefinition(
                Variables.ToDictionary(
                    v => v.Key,
                    v => (IDmnVariable)v.Value),
                Decisions);

            //-----------------------------------------------------------------
            // Process extensions
            //-----------------------------------------------------------------

            // Process diagram (and shape) extension
            if (SourceModel.DmnVersion >= DmnParser.DmnVersionEnum.V1_3)
            {
                ProcessDiagramExtension(definition);
            }

            return definition;
        }

        /// <summary>
        /// Validates the inputs of the <see cref="DmnModel"/> (<see cref="SourceModel"/>)
        /// and populates <see cref="InputData"/>, <see cref="InputDataById"/> and related <see cref="Variables"/>
        /// </summary>
        /// <exception cref="InvalidOperationException"><see cref="SourceModel"/>, <see cref="InputData"/> is null.</exception>
        /// <exception cref="DmnParserException">Missing input id</exception> 
        /// <exception cref="DmnParserException">Duplicate input data name</exception> 
        protected virtual void ProcessInputDataSource()
        {
            if (SourceModel == null) throw Logger.Fatal<InvalidOperationException>($"{nameof(SourceModel)} is null");
            if (InputDataById == null) throw Logger.Fatal<InvalidOperationException>($"{nameof(InputDataById)} is null");
            if (SourceModel.InputData == null || SourceModel.InputData.Count == 0) return;//it's not common, but OK to have no input data

            //TODO    ?Input name in form varName:varType for (complex) input types
            foreach (var sourceInput in SourceModel.InputData)
            {
                if (string.IsNullOrWhiteSpace(sourceInput.Id)) throw Logger.Fatal<DmnParserException>($"Missing input id");

                var inputName = !string.IsNullOrWhiteSpace(sourceInput.Name) ? sourceInput.Name : sourceInput.Id;
                var variableName = DmnVariableDefinition.NormalizeVariableName(inputName);
                if (InputData.ContainsKey(variableName))
                    throw Logger.Fatal<DmnParserException>($"Duplicate input data name {variableName} (from {inputName})");

                var variable = new DmnVariableDefinition(variableName, inputName, label: inputName);
                InputData.Add(variableName, variable);
                Variables.Add(variableName, variable);
                InputDataById.Add(sourceInput.Id, variable);
            }
        }

        /// <summary>
        /// Validates the <paramref name="sourceDecision"/> within the <see cref="DmnModel"/>
        /// and creates <see cref="DmnExpressionDecision"/> or <see cref="DmnDecisionTable"/>.
        /// Populates <see cref="Decisions"/> and <see cref="DecisionsById"/>
        /// </summary>
        /// <param name="sourceDecision">Decision source parsed from XML</param>
        /// <exception cref="ArgumentNullException"><paramref name="sourceDecision"/> is null.</exception>
        /// <exception cref="InvalidOperationException"><see cref="SourceModel"/>, <see cref="InputData"/> or <see cref="DecisionsById"/> is null.</exception>
        /// <exception cref="DmnParserException">Missing decision id</exception> 
        /// <exception cref="DmnParserException">Duplicate decision name</exception> 
        /// <exception cref="DmnParserException">Missing required decision reference</exception> 
        /// <exception cref="DmnParserException">Decision with given reference id not found</exception> 
        /// <exception cref="DmnParserException">Missing required input reference for</exception> 
        /// <exception cref="DmnParserException">Input with given reference id not found</exception> 
        protected virtual IDmnDecision ProcessDecision(Decision sourceDecision)
        {
            if (sourceDecision == null) throw Logger.Fatal<ArgumentNullException>($"{nameof(sourceDecision)} is null");
            if (SourceModel == null) throw Logger.Fatal<InvalidOperationException>($"{nameof(SourceModel)} is null");
            if (InputDataById == null) throw Logger.Fatal<InvalidOperationException>($"{nameof(InputDataById)} is null");
            if (DecisionsById == null) throw Logger.Fatal<InvalidOperationException>($"{nameof(DecisionsById)} is null");

            var allSourceDecisions = SourceModel.Decisions ?? new List<Decision>(); //All decisions parsed from XML source

            if (string.IsNullOrWhiteSpace(sourceDecision.Id)) throw Logger.Fatal<DmnParserException>($"Missing decision id");
            if (DecisionsById.ContainsKey(sourceDecision.Id)) return DecisionsById[sourceDecision.Id]; //already processed

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

                    if (DecisionsById.TryGetValue(refId, out var requiredDecision))
                    {
                        /* since v1.1 only directly required inputs are added and GetAllRequiredXxx methods are added to Definition
                        //decision already processed, just add "new" inputs
                        AddNewRequiredInputs(requiredDecision.RequiredInputs, requiredInputs);
                        */

                        //decision already processed
                        requiredDecisions.Add(requiredDecision);
                        continue;
                    }

                    var sourceDependsOnDecision = allSourceDecisions.FirstOrDefault(d => d.Id == refId);
                    if (sourceDependsOnDecision == null) throw Logger.Fatal<DmnParserException>($"Decision with reference {refId} for {decisionName} not found");

                    var dependsOnDecision = ProcessDecision(sourceDependsOnDecision); //process required decision first

                    //since v1.1 only directly required inputs are added and GetAllRequiredXxxx methods are added to Definition
                    //AddNewRequiredInputs(dependsOnDecision.RequiredInputs, requiredInputs);

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
                    if (!InputDataById.ContainsKey(refId)) throw Logger.Fatal<DmnParserException>($"Input with reference {refId} for {decisionName} not found");
                    newInputs.Add(InputDataById[refId]);
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
            DecisionsById.Add(sourceDecision.Id, decision);
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
        /// <exception cref="ArgumentNullException"><paramref name="sourceTable"/>, <paramref name="decisionName"/>, <paramref name="requiredInputs"/> or <paramref name="requiredDecisions"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="decisionName"/> is empty</exception>    
        /// <exception cref="DmnParserException">No outputs for decision table</exception> 
        /// <exception cref="DmnParserException">No inputs for decision table</exception> 
        /// <exception cref="DmnParserException">Input variable for decision table not found</exception> 
        /// <exception cref="DmnParserException">Input for decision table has no source</exception>
        /// <exception cref="DmnParserException">No rules for decision table</exception> 
        /// <exception cref="DmnParserException">Number of rule input entries doesn't match the number of inputs for decision table</exception> 
        /// <exception cref="DmnParserException">Number of rule output entries doesn't match the number of outputs for decision table</exception> 
        protected virtual DmnDecisionTable CreateDecisionTable(
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
                string sourceVariableName;
                if (SourceModel.DmnVersion < DmnParser.DmnVersionEnum.V1_3ext)
                {
                    //legacy mapping pre V1_3ext
                    //Label, Name, Id
                    sourceVariableName =
                    !string.IsNullOrWhiteSpace(sourceOutput.Label) ? sourceOutput.Label :
                    !string.IsNullOrWhiteSpace(sourceOutput.Name) ? sourceOutput.Name :
                    sourceOutput.Id;
                }
                else
                {
                    //mapping since V1_3ext
                    //Name,Label, Id
                    sourceVariableName =
                        !string.IsNullOrWhiteSpace(sourceOutput.Name) ? sourceOutput.Name :
                        !string.IsNullOrWhiteSpace(sourceOutput.Label) ? sourceOutput.Label :
                        sourceOutput.Id;
                }

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
                var label =
                    !string.IsNullOrWhiteSpace(sourceOutput.Label) ? sourceOutput.Label :
                    !string.IsNullOrWhiteSpace(sourceOutput.Name) ? sourceOutput.Name :
                    null;//label??name??null(will default to Output#n)

                outputs.Add(new DmnDecisionTableOutput(outputIdx, variable, allowedValues, label));
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


                var xmlId = sourceInput.Id;
                var xmlLabel = sourceInput.Label;
                var xmlInputVariable = sourceInput.InputVariable; //new in v1.1
                var xmlExpressionText = sourceInput.InputExpression?.Text;

                bool isVariableInput;
                string sourceVariableName, variableName, expression;

                if (SourceModel.DmnVersion < DmnParser.DmnVersionEnum.V1_3ext)
                {
                    //legacy mapping pre V1_3ext
                    isVariableInput = string.IsNullOrWhiteSpace(xmlExpressionText);
                    if (isVariableInput)
                    {
                        sourceVariableName = !string.IsNullOrWhiteSpace(xmlLabel) ? xmlLabel : xmlId;
                        variableName = DmnVariableDefinition.NormalizeVariableName(sourceVariableName);
                        expression = null;
                    }
                    else
                    {
                        sourceVariableName = null;
                        variableName = null;
                        expression = xmlExpressionText;
                    }
                }
                else
                {
                    //mapping since V1_3ext
                    if (!string.IsNullOrWhiteSpace(xmlInputVariable))
                    {
                        isVariableInput = true;
                        sourceVariableName = xmlInputVariable;
                        variableName = DmnVariableDefinition.NormalizeVariableName(sourceVariableName);
                        expression = null;
                    }
                    else if ( //first "wins" (expression vs label) or it goes to fall back (ID)
                        !CheckTableInputForVariable(xmlExpressionText, Variables, out isVariableInput, out sourceVariableName, out variableName, out expression) &&
                        !CheckTableInputForVariable(xmlLabel, Variables, out isVariableInput, out sourceVariableName, out variableName, out expression))
                    {
                        //fall back - ID is a must, but can be only variable name
                        CheckTableInputForVariable(xmlId, Variables, out isVariableInput, out sourceVariableName, out variableName, out expression);
                        if (!isVariableInput)
                        {
                            //Error - don't use the ID as expression
                            throw Logger.Fatal<DmnParserException>(
                                $"Input#{inputIdx+1} for decision table {decisionName} has no source");
                        }
                    }
                }

                if (isVariableInput)
                {
                    if (!Variables.TryGetValue(variableName, out variable))
                    {
                        throw Logger.Fatal<DmnParserException>(
                            $"Input variable {sourceVariableName} ({variableName}) for decision table {decisionName} not found");
                    }

                    CheckAndUpdateVariableType(variable, sourceInput.InputExpression?.TypeRef);
                }

                var allowedValues = sourceInput.AllowedInputValues?.Values;
                var inputLabel = !string.IsNullOrWhiteSpace(xmlLabel) ? xmlLabel : isVariableInput ? sourceVariableName : null; //label??variable??null(will default to Input#n)

                inputs.Add(new DmnDecisionTableInput(inputIdx, variable, expression, allowedValues, inputLabel));
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
                requiredInputs, requiredDecisions,
                label: decisionName);
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
        /// <exception cref="ArgumentNullException"><paramref name="sourceDecision"/>, <paramref name="decisionName"/>, <paramref name="requiredInputs"/> or <paramref name="requiredDecisions"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="decisionName"/> is empty</exception>    
        /// <exception cref="DmnParserException">Missing expression for expression decision</exception> 
        /// <exception cref="DmnParserException">Missing output variable for expression decision</exception> 
        protected virtual DmnExpressionDecision CreateExpressionDecision(
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
                variable = new DmnVariableDefinition(variableName, label: sourceVariableName);
                Variables.Add(variableName, variable);
            }

            variable.AddValueSetter($"Expression Decision {decisionName}");
            CheckAndUpdateVariableType(variable, sourceDecision.OutputVariable.TypeRef);

            //prepare expression
            if (string.IsNullOrWhiteSpace(sourceDecision.Expression.Text))
                throw Logger.Fatal<DmnParserException>($"Missing expression for expression decision {decisionName}");
            var expr = $"{sourceDecision.Expression.Text}";

            //create
            var expressionDecision = new DmnExpressionDecision(decisionName, expr, variable, requiredInputs, requiredDecisions, label: decisionName);
            return expressionDecision;
        }

        /// <summary>
        /// Checks whether <param name="source"> is either not set (null or whitespace) or variable or expression.</param>
        /// </summary>
        /// <param name="source">Source string to check</param>
        /// <param name="knownVariables">Dictionary of know variables</param>
        /// <param name="isVariable">Out: Flag whether the <paramref name="source"/> is set and represents variable</param>
        /// <param name="sourceVariableName">Out: Source variable name (before normalization) when <paramref name="source"/> is set and represents variable</param>
        /// <param name="variableName">Out: Variable name when <paramref name="source"/> is set and represents variable</param>
        /// <param name="expression">Out: Expression when <paramref name="source"/> is set and represents expression</param>
        /// <returns>True when <param name="source"> is not null or whitespace, so it represents variable or expression</param></returns>
        /// <exception cref="ArgumentNullException"><paramref name="knownVariables"/> is null</exception>
        protected virtual bool CheckTableInputForVariable(
            string source,
            Dictionary<string, DmnVariableDefinition> knownVariables,
            out bool isVariable,
            out string sourceVariableName,
            out string variableName,
            out string expression)
        {
            if (knownVariables is null) throw new ArgumentNullException(nameof(knownVariables));

            if (string.IsNullOrWhiteSpace(source))
            {
                isVariable = false;
                sourceVariableName = null;
                variableName = null;
                expression = null;
                return false;
            }
            
            if (DmnVariableDefinition.CanNormalizeVariableName(source, out var potentialVariableName,out _) &&
                Variables.TryGetValue(potentialVariableName, out _))
            {
                //source is know variable name -> variable
                isVariable = true;
                sourceVariableName = source;
                variableName = potentialVariableName;
                expression = null;
                return true;
            }

            isVariable = false;
            sourceVariableName = null;
            variableName = null;
            expression = source;
            return true;
        }

        /// <summary>
        /// Adds <paramref name="newInputs"/> into the list of <paramref name="requiredInputs"/>.
        /// <paramref name="newInputs"/> can be null or empty (no addition then)
        /// </summary>
        /// <param name="newInputs"></param>
        /// <param name="requiredInputs"></param>
        /// <exception cref="ArgumentNullException"><paramref name="requiredInputs"/> is null.</exception>
        protected virtual void AddNewRequiredInputs(IReadOnlyCollection<IDmnVariable> newInputs, List<IDmnVariable> requiredInputs)
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
        protected virtual void CheckAndUpdateVariableType(DmnVariableDefinition variable, string typeName)
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
        protected virtual Type ParseTypeName(string typeName)
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

        /// <summary>
        /// When the <see cref="SourceModel"/> has the DI diagram data, it gets individual shapes having bounds and tries to find them
        /// within <see cref="InputDataById"/> and <see cref="DecisionsById"/>. When there is a match, it creates <see cref="DiDiagramShapeExtension"/>
        /// attached to the element. All matched bounds are also added to <see cref="DiDiagramExtension"/> attached to the definition
        /// </summary>
        /// <param name="dmnDefinition">DMN Definition built by factory</param>
        /// <exception cref="ArgumentNullException"><paramref name="dmnDefinition"/> is null.</exception>
        /// <exception cref="InvalidOperationException"><see cref="SourceModel"/>, <see cref="InputData"/> or <see cref="DecisionsById"/> is null.</exception>
        protected virtual void ProcessDiagramExtension(DmnDefinition dmnDefinition)
        {
            if (dmnDefinition == null) throw Logger.Fatal<ArgumentNullException>(nameof(dmnDefinition));
            if (SourceModel == null) throw Logger.Fatal<InvalidOperationException>($"{nameof(SourceModel)} is null");
            if (InputDataById == null) throw Logger.Fatal<InvalidOperationException>($"{nameof(InputDataById)} is null");
            if (DecisionsById == null) throw Logger.Fatal<InvalidOperationException>($"{nameof(DecisionsById)} is null");

            if (SourceModel.DiagramExtension?.Diagrams is null) return;

            var elements = new Dictionary<string, IDmnElement>();
            InputDataById.ToList().ForEach(x => elements.Add(x.Key, x.Value));
            DecisionsById.ToList().ForEach(x => elements.Add(x.Key, x.Value));

            var diagramExtension = new DiDiagramExtension();

            foreach (var shape in SourceModel
                         .DiagramExtension
                         .Diagrams
                         .Where(d => d.Shapes != null)
                         .SelectMany(d => d.Shapes)
                         .Where(s => s.Bounds != null && !string.IsNullOrWhiteSpace(s.DmnElementRef)))
            {
                var elementRef = shape.DmnElementRef;
                var bounds = shape.Bounds;
                if (!elements.TryGetValue(elementRef, out var element)) continue;

                var shapeExtension = new DiDiagramShapeExtension(bounds.X, bounds.Y, bounds.Width, bounds.Height);
                element.AddExtension(shapeExtension);
                diagramExtension.ShapesByElement.Add(element, shapeExtension.Clone());
            }

            if (diagramExtension.ShapesByElement.Count > 0)
            {
                dmnDefinition.AddExtension(diagramExtension);
            }
        }
    }
}
