using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using net.adamec.lib.common.dmn.engine.engine.decisions;
using net.adamec.lib.common.dmn.engine.engine.decisions.table;
using net.adamec.lib.common.dmn.engine.parser.dto;

namespace net.adamec.lib.common.dmn.engine.engine.definition.builder
{
    /// <summary>
    /// Decision table definition builder
    /// </summary>
    public class TableDecision : Decision
    {
        /// <summary>
        /// Table input builders
        /// </summary>
        public IReadOnlyList<TableInput> Inputs => InputsInternal;
        /// <summary>
        /// Internal list of table input builders
        /// </summary>    
        private List<TableInput> InputsInternal { get; } = new List<TableInput>();
        /// <summary>
        /// Table input builders by reference
        /// </summary>    
        private Dictionary<TableInput.Ref, TableInput> InputsByRef { get; } = new Dictionary<TableInput.Ref, TableInput>();

        /// <summary>
        /// Table output builders
        /// </summary>
        public IReadOnlyList<TableOutput> Outputs => OutputsInternal;
        /// <summary>
        /// Internal list of table output builders
        /// </summary>    
        private List<TableOutput> OutputsInternal { get; } = new List<TableOutput>();
        /// <summary>
        /// Table output builders by reference
        /// </summary>    
        private Dictionary<TableOutput.Ref, TableOutput> OutputsByRef { get; } = new Dictionary<TableOutput.Ref, TableOutput>();

        /// <summary>
        /// Table rule builders
        /// </summary>
        public IReadOnlyList<TableRule> Rules => RulesInternal;
        /// <summary>
        /// Internal list of table rule builders
        /// </summary>
        private List<TableRule> RulesInternal { get; } = new List<TableRule>();

        /// <summary>
        /// Decision table hit policy (default <see cref="HitPolicyEnum.Unique"/>)
        /// </summary>
        public HitPolicyEnum HitPolicy { get; private set; } = HitPolicyEnum.Unique;
        /// <summary>
        /// Decision table hit policy aggregation type (default <see cref="CollectHitPolicyAggregationEnum.List"/>)
        /// </summary>
        public CollectHitPolicyAggregationEnum Aggregation { get; private set; } = CollectHitPolicyAggregationEnum.List;

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="variables"><see cref="VariableCatalog"/> managing the definition builder variables</param>
        /// <param name="decisions"><see cref="DecisionCatalog"/> managing the definition builder decisions</param>
        /// <param name="name">Unique name of the decision</param>
        internal TableDecision(VariableCatalog variables, DecisionCatalog decisions, string name)
            : base(variables, decisions, name)
        {

        }

        /// <summary>
        /// Adds the required input reference to the decision.
        /// </summary>
        /// <remarks>Required inputs represents the "link" between input and decision in a model.
        /// Technically, the input requirements (existence of the input) are not checked during the execution,
        /// it's more for better understanding the DMN model</remarks>
        /// <param name="input">Reference to the input variable</param>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public new TableDecision Requires(Variable.Ref input)
        {
            base.Requires(input);
            return this;
        }

        /// <summary>
        /// Adds the required decision reference to the decision.
        /// </summary>
        /// <remarks>When executing the decision, the engine checks for required decisions and executes them before executing this decision</remarks>
        /// <param name="decision">Reference to the decision this decision depends on </param>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public new TableDecision Requires(Ref decision)
        {
            base.Requires(decision);
            return this;
        }

        /// <summary>
        /// Sets the hit policy of the decision table
        /// </summary>
        /// <param name="hitPolicy">Decision table hit policy</param>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public TableDecision WithHitPolicy(HitPolicyEnum hitPolicy)
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>($"Decision is already built");
            HitPolicy = hitPolicy;
            return this;
        }

        /// <summary>
        /// Sets the hit policy aggregation type of the decision table
        /// </summary>
        /// <param name="aggregation">Hit policy aggregation</param>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public TableDecision WithAggregation(CollectHitPolicyAggregationEnum aggregation)
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>($"Decision is already built"); Aggregation = aggregation;
            return this;
        }

        /// <summary>
        /// Adds the variable based table input
        /// </summary>
        /// <remarks>The inputs are "indexed" in the order as added to the table definition builder</remarks>
        /// <param name="variableRef">Reference to variable used as table input</param>
        /// <param name="inputRef">Reference to added table input that can be used in rule builders</param>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public TableDecision WithInput(Variable.Ref variableRef, out TableInput.Ref inputRef)
        {
            return WithInput(variableRef, out inputRef, null);
        }

        /// <summary>
        /// Adds the variable based table input
        /// </summary>
        /// <remarks>The inputs are "indexed" in the order as added to the table definition builder</remarks>
        /// <param name="variableRef">Reference to variable used as table input</param>
        /// <param name="inputRef">Reference to added table input that can be used in rule builders</param>
        /// <param name="allowedValues">Allowed input values</param>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        /// <exception cref="ArgumentNullException"> when the <paramref name="variableRef"/> is not provided</exception>
        public TableDecision WithInput(Variable.Ref variableRef, out TableInput.Ref inputRef, params string[] allowedValues)
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>($"Decision is already built");
            if (variableRef == null) throw new ArgumentNullException(nameof(variableRef));

            var input = new TableInput(Variables, Decisions, InputsInternal.Count).WithVariable(variableRef);
            _ = allowedValues != null && allowedValues.Length > 0
                ? input.WithAllowedValues(allowedValues)
                : input.WithoutAllowedValuesConstraint();

            inputRef = input.Reference;
            InputsInternal.Add(input);
            InputsByRef.Add(inputRef, input);
            return this;
        }

        /// <summary>
        /// Adds the expression based table input
        /// </summary>
        /// <remarks>The inputs are "indexed" in the order as added to the table definition builder</remarks>
        /// <param name="expression">Expression to be used as table input</param>
        /// <param name="inputRef">Reference to added table input that can be used in rule builders</param>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        /// <exception cref="ArgumentNullException"> when the <paramref name="expression"/> is not provided</exception>
        /// <exception cref="ArgumentException"> when the <paramref name="expression"/> is empty or whitespace</exception>
        public TableDecision WithInput(string expression, out TableInput.Ref inputRef)
        {
            return WithInput(expression, out inputRef, null);
        }

        /// <summary>
        /// Adds the expression based table input
        /// </summary>
        /// <remarks>The inputs are "indexed" in the order as added to the table definition builder</remarks>
        /// <param name="expression">Expression to be used as table input</param>
        /// <param name="inputRef">Reference to added table input that can be used in rule builders</param>
        /// <param name="allowedValues">Allowed input values</param>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        /// <exception cref="ArgumentNullException"> when the <paramref name="expression"/> is not provided</exception>
        /// <exception cref="ArgumentException"> when the <paramref name="expression"/> is empty or whitespace</exception>
        public TableDecision WithInput(string expression, out TableInput.Ref inputRef, params string[] allowedValues)
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>($"Decision is already built");
            if (expression == null) throw new ArgumentNullException(nameof(expression));
            if (string.IsNullOrWhiteSpace(expression))
                throw new ArgumentException("Missing expression", nameof(expression));

            var input = new TableInput(Variables, Decisions, InputsInternal.Count).WithExpression(expression);
            _ = allowedValues != null && allowedValues.Length > 0
                ? input.WithAllowedValues(allowedValues)
                : input.WithoutAllowedValuesConstraint();

            inputRef = input.Reference;
            InputsInternal.Add(input);
            InputsByRef.Add(inputRef, input);
            return this;
        }

        /// <summary>
        /// Adds the table output with reference to the variable to store the output value to
        /// </summary>
        /// <remarks>The outputs are "indexed" in the order as added to the table definition builder</remarks>
        /// <param name="variableRef">Reference to variable used to store the table output to</param>
        /// <param name="outputRef">Reference to added table output that can be used in rule builders</param>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        /// <exception cref="ArgumentNullException"> when the <paramref name="variableRef"/> is not provided</exception>
        public TableDecision WithOutput(Variable.Ref variableRef, out TableOutput.Ref outputRef)
        {
            return WithOutput(variableRef, out outputRef, null);
        }

        /// <summary>
        /// Adds the table output with reference to the variable to store the output value to
        /// </summary>
        /// <remarks>The outputs are "indexed" in the order as added to the table definition builder</remarks>
        /// <param name="variableRef">Reference to variable used to store the table output to</param>
        /// <param name="outputRef">Reference to added table output that can be used in rule builders</param>
        /// <param name="allowedValues">Allowed output values</param>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        /// <exception cref="ArgumentNullException"> when the <paramref name="variableRef"/> is not provided</exception>
        public TableDecision WithOutput(Variable.Ref variableRef, out TableOutput.Ref outputRef, params string[] allowedValues)
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>($"Decision is already built");
            if (variableRef == null) throw new ArgumentNullException(nameof(variableRef));

            var output = new TableOutput(Variables, Decisions, OutputsInternal.Count).WithVariable(variableRef);
            _ = allowedValues != null && allowedValues.Length > 0
                ? output.WithAllowedValues(allowedValues)
                : output.WithoutAllowedValuesConstraint();

            outputRef = output.Reference;
            OutputsInternal.Add(output);
            OutputsByRef.Add(outputRef, output);
            return this;
        }

        /// <summary>
        /// Adds the table rule. 
        /// </summary>
        /// <param name="name">Name of the table rule</param>
        /// <param name="builder">Builder used to create the rule definition (see <see cref="TableRule"/> for details)</param>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        /// <exception cref="ArgumentNullException"> when the <paramref name="name"/> is not provided</exception>
        /// <exception cref="ArgumentException"> when the <paramref name="name"/> is empty or whitespace</exception>
        /// <exception cref="ArgumentNullException"> when the <paramref name="builder"/> is not provided</exception>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the rule with given <paramref name="name"/> already exists</exception>
        public TableDecision WithRule(string name, Func<TableRule.TableRuleInputBuilder, TableRule.TableRuleOutputBuilder> builder)
        {
            return WithRule(name, null, builder);
        }

        /// <summary>
        /// Adds the table rule. 
        /// </summary>
        /// <param name="name">Name of the table rule</param>
        /// <param name="description">Description of th rule</param>
        /// <param name="builder">Builder used to create the rule definition (see <see cref="TableRule"/> for details)</param>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        /// <exception cref="ArgumentNullException"> when the <paramref name="name"/> is not provided</exception>
        /// <exception cref="ArgumentException"> when the <paramref name="name"/> is empty or whitespace</exception>
        /// <exception cref="ArgumentNullException"> when the <paramref name="builder"/> is not provided</exception>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the rule with given <paramref name="name"/> already exists</exception>
        public TableDecision WithRule(string name, string description, Func<TableRule.TableRuleInputBuilder, TableRule.TableRuleOutputBuilder> builder)
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>($"Decision is already built");
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Missing rule name", nameof(name));
            if (builder == null) throw new ArgumentNullException(nameof(builder));

            if (Rules.Any(r => r.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase))) throw Logger.Error<DmnBuilderException>($"Rule {name} already exists");

            var rule = new TableRule(Variables, Decisions, InputsByRef, OutputsByRef, RulesInternal.Count, name, description);
            builder.Invoke(new TableRule.TableRuleInputBuilder(rule));

            RulesInternal.Add(rule);
            return this;
        }

        /// <summary>
        /// Builds the decision table definition
        /// </summary>
        /// <returns>Table decision definition built</returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when there is no input or no output defined in builder</exception>
        internal override IDmnDecision Build()
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Decision is already built");
            if (InputsInternal.Count < 1) throw Logger.Error<DmnBuilderException>($"At least one input must be defined for decision table {Name}");
            if (OutputsInternal.Count < 1) throw Logger.Error<DmnBuilderException>($"At least one output must be defined for decision table {Name}");

            //create
            var tableDecision = new DmnDecisionTable(
                Name,
                HitPolicy,
                Aggregation,
                InputsInternal.Select(i => i.GetResultOrBuild()).ToArray(),
                OutputsInternal.Select(o => o.GetResultOrBuild()).ToArray(),
                RulesInternal.Select(r => r.GetResultOrBuild()).ToArray(),
                RequiredInputs.Select(i => Variables[i].GetResultOrBuild()).ToArray(),
                RequiredDecisions.Select(d => Decisions[d].GetResultOrBuild()).ToArray());
            ResultInternal = tableDecision;
            return tableDecision;
        }

        /// <inheritdoc />
        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"{Name} {Inputs.Count} inputs, {Outputs.Count} outputs, {Rules.Count} rules; HitPolicy: {HitPolicy}";
        }
    }
}