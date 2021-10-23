using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using net.adamec.lib.common.dmn.engine.engine.decisions.table.definition;

namespace net.adamec.lib.common.dmn.engine.engine.definition.builder
{
    /// <summary>
    /// Decision table rule definition builder
    /// <para>Rule definition is built using the chain of builders provided as lambda/delegate when calling <code>TableDecision.WithRule</code>.
    /// The table inputs and outputs must be defined in TableDecision builder first, as the rule builders must be provided with proper table input/output references.
    /// </para>
    /// <para>The builder chain provides methods to define the input conditions (When, When.And[.And], Always)
    /// and the output calculations (Then, Then.And[.And], SkipOutput)</para>
    /// <para>Syntax examples:</para>
    /// <para><code>rule.When(input1Ref, "input 1 eval expression").Then(output1Ref, "output 1 calc expression")</code></para>
    /// <para><code>rule.When(input1Ref, "input 1 eval expression").And(input2Ref, "input 2 eval expression").Then(output1Ref, "output 1 calc expression").And(output2Ref, "output 2 calc expression")</code></para>
    /// <para><code>rule.Always().Then(output1Ref, "output 1 calc expression").And(output2Ref, "output 2 calc expression")</code></para>
    /// <para><code>rule.When(input1Ref, "input 1 eval expression").SkipOutput()</code></para>
    /// <para><code>rule.When(input1Ref, "input 1 eval expression").And(input2Ref, "input 2 eval expression").SkipOutput()</code></para>
    /// <para><code>rule.Always().SkipOutput()</code></para>
    /// <para></para>
    /// <para><see cref="TableRuleInputBuilder"/> provides <see cref="TableRuleInputBuilder.When"/> method to provide the first input condition and returns <see cref="TableRuleInputBuilder"/>.</para>
    /// <para><see cref="TableRuleInputBuilder"/> provides <see cref="TableRuleInputBuilder.Always"/> method to let the rule accept any input and returns <see cref="TableRuleThenOnlyBuilder"/>.</para>
    /// <para><see cref="TableRuleThenOrAndBuilder"/> provides <see cref="TableRuleThenOrAndBuilder.And"/> method provide the additional input condition and returns <see cref="TableRuleThenOrAndBuilder"/>.</para>
    /// <para><see cref="TableRuleThenOrAndBuilder"/> provides <see cref="TableRuleThenOrAndBuilder.Then"/> method to provide the first output expression and returns <see cref="TableRuleAndOutputBuilder"/>.</para>
    /// <para><see cref="TableRuleThenOrAndBuilder"/> provides <see cref="TableRuleThenOrAndBuilder.SkipOutput"/> method to skip the output calculation and returns <see cref="TableRuleOutputBuilder"/>.</para>
    /// <para><see cref="TableRuleThenOnlyBuilder"/> provides <see cref="TableRuleThenOnlyBuilder.Then"/> method to provide the first output calculation and returns <see cref="TableRuleAndOutputBuilder"/>.</para>
    /// <para><see cref="TableRuleThenOnlyBuilder"/> provides <see cref="TableRuleThenOnlyBuilder.SkipOutput"/> method to skip the output calculation and returns <see cref="TableRuleOutputBuilder"/>.</para>
    /// <para><see cref="TableRuleAndOutputBuilder"/> inherits from <see cref="TableRuleOutputBuilder"/> and provides <see cref="TableRuleAndOutputBuilder.And"/> method to provide the additional output calculation and returns <see cref="TableRuleAndOutputBuilder"/>.</para>
    /// <para><see cref="TableRuleOutputBuilder"/> is the final rule builder.</para>
    /// </summary>
    public class TableRule : DmnBuilderElement<TableRule, DmnDecisionTableRule>
    {
        /// <summary>
        /// Index (order) of the rule within the decision table
        /// </summary>
        public int Index { get; }
        /// <summary>
        /// Rule name
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Optional rule description (annotation)
        /// </summary>
        public string Description { get; }

        ///<summary>
        /// Definition of decision table rule inputs as a dictionary of pairs table input reference and the evaluation expression
        /// </summary>
        public IReadOnlyDictionary<TableInput.Ref, string> Inputs => InputsInternal;
        ///<summary>
        /// Internal definition of decision table rule inputs as a dictionary of pairs table input reference and the evaluation expression
        /// </summary>
        private Dictionary<TableInput.Ref, string> InputsInternal { get; } = new Dictionary<TableInput.Ref, string>();

        ///<summary>
        /// Definition of decision table rule outputs as a dictionary of pairs table output reference and the calculation expression
        /// </summary>
        public IReadOnlyDictionary<TableOutput.Ref, string> Outputs => OutputsInternal;
        ///<summary>
        /// Internal definition of decision table rule outputs as a dictionary of pairs table output reference and the calculation expression
        /// </summary>
        private Dictionary<TableOutput.Ref, string> OutputsInternal { get; } = new Dictionary<TableOutput.Ref, string>();

        /// <summary>
        /// All inputs defined for decision table (by reference)
        /// </summary>
        private IReadOnlyDictionary<TableInput.Ref, TableInput> AllTableInputs { get; }
        /// <summary>
        /// All outputs defined for decision table (by reference)
        /// </summary>
        private IReadOnlyDictionary<TableOutput.Ref, TableOutput> AllTableOutputs { get; }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="variables"><see cref="VariableCatalog"/> managing the definition builder variables</param>
        /// <param name="decisions"><see cref="DecisionCatalog"/> managing the definition builder decisions</param>
        /// <param name="allTableInputs">All inputs defined for table (by reference)</param>
        /// <param name="allTableOutputs">All outputs defined for table (by reference)</param>
        /// <param name="index">Index of the rule (order)</param>
        /// <param name="name">Table unique rule name</param>
        /// <param name="description">Optional rule description</param>
        internal TableRule(
            VariableCatalog variables, DecisionCatalog decisions,
            IReadOnlyDictionary<TableInput.Ref, TableInput> allTableInputs, IReadOnlyDictionary<TableOutput.Ref, TableOutput> allTableOutputs,
            int index, string name, string description = null)
            : base(variables, decisions)
        {
            Index = index;
            Name = name;
            Description = description;

            AllTableInputs = allTableInputs ?? throw new ArgumentNullException(nameof(allTableInputs));
            AllTableOutputs = allTableOutputs ?? throw new ArgumentNullException(nameof(allTableOutputs));
        }

        /// <summary>
        /// Sets the <paramref name="inputExpression">input expression</paramref> for the input referenced by <paramref name="inputRef"/>
        /// </summary>
        /// <remarks>
        /// When the expression is null or whitespace the table input will not be used for the rule (will be removed when it was already defined before).
        /// When the expression is "valid" and the input expression has been defined before, it will override it
        /// </remarks>
        /// <param name="inputRef">Reference to decision table input</param>
        /// <param name="inputExpression">Input evaluation expression</param>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        /// <exception cref="ArgumentNullException">Throws <see cref="ArgumentNullException"/> when the <paramref name="inputRef"/> is null</exception>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the <paramref name="inputRef"/> is not recognized as the valid table input</exception>
        private void SetInput(TableInput.Ref inputRef, string inputExpression)
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Table rule is already built");

            if (inputRef == null) throw new ArgumentNullException(nameof(inputRef));
            if (!AllTableInputs.ContainsKey(inputRef))
                throw Logger.Error<DmnBuilderException>("Input reference is not valid for current table");

            if (string.IsNullOrWhiteSpace(inputExpression))
            {
                if (InputsInternal.ContainsKey(inputRef)) InputsInternal.Remove(inputRef);
            }
            else
            {
                InputsInternal[inputRef] = inputExpression;
            }
        }

        /// <summary>
        /// Clears input expressions for all inputs
        /// </summary>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        private void ClearInputs()
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Table rule is already built");

            InputsInternal.Clear();
        }


        /// <summary>
        /// Sets the <paramref name="outputExpression">output expression</paramref> for the output referenced by <paramref name="outputRef"/>
        /// </summary>
        /// <remarks>
        /// When the expression is null or whitespace the table output will not be used for the rule (will be removed when it was already defined before).
        /// When the expression is "valid" and the output expression has been defined before, it will override it
        /// </remarks>
        /// <param name="outputRef">Reference to decision table output</param>
        /// <param name="outputExpression">Output calculation expression</param>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        /// <exception cref="ArgumentNullException">Throws <see cref="ArgumentNullException"/> when the <paramref name="outputRef"/> is null</exception>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the <paramref name="outputRef"/> is not recognized as the valid table output</exception>
        private void SetOutput(TableOutput.Ref outputRef, string outputExpression)
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Table rule is already built");

            if (outputRef == null) throw new ArgumentNullException(nameof(outputRef));
            if (!AllTableOutputs.ContainsKey(outputRef))
                throw Logger.Error<DmnBuilderException>("Output reference is not valid for current table");

            if (string.IsNullOrWhiteSpace(outputExpression))
            {
                if (OutputsInternal.ContainsKey(outputRef)) OutputsInternal.Remove(outputRef);
            }
            else
            {
                OutputsInternal[outputRef] = outputExpression;
            }
        }

        /// <summary>
        /// Clears the output calculation expressions for all outputs
        /// </summary>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        private void ClearOutputs()
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Table rule is already built");

            OutputsInternal.Clear();
        }

        /// <summary>
        /// Helper builder used to configure the decision table rule definition using the chain of builders.
        /// </summary>
        public class TableRuleInputBuilder
        {
            /// <summary>
            /// "Parent"rule builder.
            /// </summary>
            private TableRule Rule { get; }
            /// <summary>
            /// CTOR
            /// </summary>
            /// <param name="rule">"Parent"rule builder</param>
            internal TableRuleInputBuilder(TableRule rule)
            {
                Rule = rule;
            }

            /// <summary>
            /// Sets the <paramref name="inputExpression">input expression</paramref> for the input referenced by <paramref name="inputRef"/>
            /// </summary>
            /// <remarks>
            /// <see cref="When"/>clears all input expressions for the rule first and then add the <paramref name="inputExpression"/> for <see cref="inputRef"/>
            /// When the expression is null or whitespace the table input will not be used for the rule (will not be added).
            /// </remarks>
            /// <param name="inputRef">Reference to decision table input</param>
            /// <param name="inputExpression">Input evaluation expression</param>
            /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
            /// <exception cref="ArgumentNullException">Throws <see cref="ArgumentNullException"/> when the <paramref name="inputRef"/> is null</exception>
            /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the <paramref name="inputRef"/> is not recognized as the valid table input</exception>
            public TableRuleThenOrAndBuilder When(TableInput.Ref inputRef, string inputExpression)
            {
                Rule.ClearInputs();
                Rule.SetInput(inputRef, inputExpression);
                return new TableRuleThenOrAndBuilder(Rule);
            }

            /// <summary>
            /// Skips the input conditions for rule meaning that the rule will accept any input. All existing input conditions, if any, are removed
            /// </summary>
            public TableRuleThenOnlyBuilder Always()
            {
                Rule.ClearInputs();
                return new TableRuleThenOnlyBuilder(Rule);
            }
        }

        /// <summary>
        /// Helper builder used to configure the decision table rule definition using the chain of builders.
        /// </summary>
        public class TableRuleThenOrAndBuilder
        {
            /// <summary>
            /// "Parent"rule builder.
            /// </summary>
            private TableRule Rule { get; }
            /// <summary>
            /// CTOR
            /// </summary>
            /// <param name="rule">"Parent"rule builder</param>
            internal TableRuleThenOrAndBuilder(TableRule rule)
            {
                Rule = rule;
            }

            /// <summary>
            /// Sets the <paramref name="outputExpression">output expression</paramref> for the output referenced by <paramref name="outputRef"/>
            /// </summary>
            /// <remarks>
            /// <see cref="Then"/>clears all output expressions for the rule first and then add the <paramref name="outputExpression"/> for <see cref="outputRef"/>
            /// When the expression is null or whitespace the table output will not be used for the rule (will not be added).
            /// </remarks>
            /// <param name="outputRef">Reference to decision table output</param>
            /// <param name="outputExpression">Output calculation expression</param>
            /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
            /// <exception cref="ArgumentNullException">Throws <see cref="ArgumentNullException"/> when the <paramref name="outputRef"/> is null</exception>
            /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the <paramref name="outputRef"/> is not recognized as the valid table output</exception>
            public TableRuleAndOutputBuilder Then(TableOutput.Ref outputRef, string outputExpression)
            {
                Rule.ClearOutputs();
                Rule.SetOutput(outputRef, outputExpression);
                return new TableRuleAndOutputBuilder(Rule);
            }

            /// <summary>
            /// Skips the output definition for the rule (no output to be provided). When there are already any output calculations for the rule, they will be removed.
            /// </summary>
            public TableRuleOutputBuilder SkipOutput()
            {
                Rule.ClearOutputs();
                return new TableRuleOutputBuilder(Rule);
            }

            /// <summary>
            /// Sets the <paramref name="inputExpression">input expression</paramref> for the input referenced by <paramref name="inputRef"/>
            /// </summary>
            /// <remarks>
            /// When the expression is null or whitespace the table input will not be used for the rule (will be removed when it was already defined before).
            /// When the expression is "valid" and the input expression has been defined before, it will override it
            /// </remarks>
            /// <param name="inputRef">Reference to decision table input</param>
            /// <param name="inputExpression">Input evaluation expression</param>
            /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
            /// <exception cref="ArgumentNullException">Throws <see cref="ArgumentNullException"/> when the <paramref name="inputRef"/> is null</exception>
            /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the <paramref name="inputRef"/> is not recognized as the valid table input</exception>
            public TableRuleThenOrAndBuilder And(TableInput.Ref inputRef, string inputExpression)
            {
                Rule.SetInput(inputRef, inputExpression);
                return this;
            }
        }

        /// <summary>
        /// Helper builder used to configure the decision table rule definition using the chain of builders.
        /// </summary>
        public class TableRuleThenOnlyBuilder
        {
            /// <summary>
            /// "Parent"rule builder.
            /// </summary>
            private TableRule Rule { get; }
            /// <summary>
            /// CTOR
            /// </summary>
            /// <param name="rule">"Parent"rule builder</param>
            internal TableRuleThenOnlyBuilder(TableRule rule)
            {
                Rule = rule;
            }

            /// <summary>
            /// Sets the <paramref name="outputExpression">output expression</paramref> for the output referenced by <paramref name="outputRef"/>
            /// </summary>
            /// <remarks>
            /// <see cref="Then"/>clears all output expressions for the rule first and then add the <paramref name="outputExpression"/> for <see cref="outputRef"/>
            /// When the expression is null or whitespace the table input will not be used for the rule (will not be added).
            /// </remarks>
            /// <param name="outputRef">Reference to decision table output</param>
            /// <param name="outputExpression">Output calculation expression</param>
            /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
            /// <exception cref="ArgumentNullException">Throws <see cref="ArgumentNullException"/> when the <paramref name="outputRef"/> is null</exception>
            /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the <paramref name="outputRef"/> is not recognized as the valid table output</exception>
            public TableRuleAndOutputBuilder Then(TableOutput.Ref outputRef, string outputExpression)
            {
                Rule.ClearOutputs();
                Rule.SetOutput(outputRef, outputExpression);
                return new TableRuleAndOutputBuilder(Rule);
            }

            /// <summary>
            /// Skips the output definition for the rule (no output to be provided). When there are already any output calculations for the rule, they will be removed/
            /// </summary>
            public TableRuleOutputBuilder SkipOutput()
            {
                Rule.ClearOutputs();
                return new TableRuleOutputBuilder(Rule);
            }

        }

        /// <summary>
        /// Helper builder used to configure the decision table rule definition using the chain of builders.
        /// </summary>
        public class TableRuleOutputBuilder
        {
            /// <summary>
            /// "Parent"rule builder.
            /// </summary>
            protected TableRule Rule { get; }
            /// <summary>
            /// CTOR
            /// </summary>
            /// <param name="rule">"Parent"rule builder</param>
            internal TableRuleOutputBuilder(TableRule rule)
            {
                Rule = rule;
            }


        }

        /// <summary>
        /// Helper builder used to configure the decision table rule definition using the chain of builders.
        /// </summary>
        public class TableRuleAndOutputBuilder : TableRuleOutputBuilder
        {
            /// <summary>
            /// CTOR
            /// </summary>
            /// <param name="rule">"Parent"rule builder</param>
            internal TableRuleAndOutputBuilder(TableRule rule) : base(rule)
            {

            }

            /// <summary>
            /// Sets the <paramref name="outputExpression">output expression</paramref> for the output referenced by <paramref name="outputRef"/>
            /// </summary>
            /// <remarks>
            /// When the expression is null or whitespace the table output will not be used for the rule (will be removed when it was already defined before).
            /// When the expression is "valid" and the output expression has been defined before, it will override it
            /// </remarks>
            /// <param name="outputRef">Reference to decision table output</param>
            /// <param name="outputExpression">Output calculation expression</param>
            /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
            /// <exception cref="ArgumentNullException">Throws <see cref="ArgumentNullException"/> when the <paramref name="outputRef"/> is null</exception>
            /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the <paramref name="outputRef"/> is not recognized as the valid table output</exception>
            public TableRuleAndOutputBuilder And(TableOutput.Ref outputRef, string outputExpression)
            {
                Rule.SetOutput(outputRef, outputExpression);
                return this;
            }
        }

        /// <summary>
        /// Builds the decision table rule definition
        /// </summary>
        /// <returns>Decision table rule definition built</returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the rule name is not defined in the builder</exception>
        internal override DmnDecisionTableRule Build()
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Decision is already built");
            if (string.IsNullOrWhiteSpace(Name)) throw Logger.Error<DmnBuilderException>("Name must be defined for decision table rule");

            var rule = new DmnDecisionTableRule(
                Index,
                Name,
                Inputs.Select(i => new DmnDecisionTableRuleInput(AllTableInputs[i.Key].GetResultOrBuild(), i.Value)).ToArray(),
                Outputs.Select(i => new DmnDecisionTableRuleOutput(AllTableOutputs[i.Key].GetResultOrBuild(), i.Value)).ToArray(),
                Description);
            ResultInternal = rule;
            return rule;
        }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"#{Index}:{Name} {Description}";
        }
    }
}