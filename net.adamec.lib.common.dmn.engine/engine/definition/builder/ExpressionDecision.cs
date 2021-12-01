using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using net.adamec.lib.common.dmn.engine.engine.decisions;
using net.adamec.lib.common.dmn.engine.engine.decisions.expression;

namespace net.adamec.lib.common.dmn.engine.engine.definition.builder
{
    /// <summary>
    /// Expression decision definition builder
    /// <para>Expression decision definition is built using the chain of builders provided as lambda/delegate when calling <code>DmnDefinitionBuilder.WithExpressionDecision</code>.
    /// It has syntax <code>expressionDecision.Put("expression").To(outputVariableReference)</code>.
    /// <see cref="ExpressionDecisionSrcBuilder"/> provides <see cref="ExpressionDecisionSrcBuilder.Put"/> method and returns <see cref="ExpressionDecisionVarBuilder"/>.
    /// <see cref="ExpressionDecisionVarBuilder"/> provides <see cref="ExpressionDecisionVarBuilder.To"/> method and returns <see cref="ExpressionDecision">"final" expression decision builder</see>
    /// that can be used to configure the required inputs and decisions when needed and to fully build the expression decision 
    /// </para>
    /// </summary>
    public sealed class ExpressionDecision : Decision
    {
        /// <summary>
        /// Reference to the variable used to store the expression decision output
        /// </summary>
        public Variable.Ref OutputVariable => OutputVariableInternal?.Reference;

        /// <summary>
        /// Builder of variable used to store the expression decision output
        /// </summary>
        private Variable OutputVariableInternal { get; set; }

        /// <summary>
        /// Expression to be evaluated when the expression decision is executed
        /// </summary>
        public string Expression { get; private set; }


        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="variables"><see cref="VariableCatalog"/> managing the definition builder variables</param>
        /// <param name="decisions"><see cref="DecisionCatalog"/> managing the definition builder decisions</param>
        /// <param name="name">Unique name of the decision</param>
        internal ExpressionDecision(VariableCatalog variables, DecisionCatalog decisions, string name)
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
        public ExpressionDecision Requires(Variable.Ref input)
        {
            AddRequiredInput(input);
            return this;
        }

        /// <summary>
        /// Adds the required decision reference to the decision.
        /// </summary>
        /// <remarks>When executing the decision, the engine checks for required decisions and executes them before executing this decision</remarks>
        /// <param name="decision">Reference to the decision this decision depends on </param>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public ExpressionDecision Requires(Ref decision)
        {
            AddRequiredDecision(decision);
            return this;
        }

        /// <summary>
        /// Sets the expression to be evaluated when the expression decision is executed
        /// </summary>
        /// <param name="expression">Expression to be evaluated when the expression decision is executed</param>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        /// <exception cref="ArgumentNullException">When the <paramref name="expression"/> is null</exception>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the <paramref name="expression"/> is empty or whitespace</exception>
        private void SetExpression(string expression)
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Decision is already built");
            Expression = expression ?? throw new ArgumentNullException(nameof(expression));
            if (string.IsNullOrWhiteSpace(expression))
                throw new ArgumentException("Missing expression", nameof(expression));
        }

        /// <summary>
        /// Sets the output variable to store the result of the decision expression evaluation to
        /// </summary>
        /// <param name="variable">Reference to the variable used to store the expression decision output</param>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        /// <exception cref="ArgumentNullException">When the <paramref name="variable"/> is null</exception>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the <paramref name="variable"/> can't be found in <see cref="VariableCatalog"/></exception>
        private void SetOutput(Variable.Ref variable)
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Decision is already built");
            if (variable == null) throw new ArgumentNullException(nameof(variable));
            OutputVariableInternal =
                Variables[variable]
                ?? throw Logger.Error<DmnBuilderException>($"Can't get the variable from reference {variable.Name}");

            OutputVariableInternal.AddValueSetter($"Expression Decision {Name}");
        }

        /// <summary>
        /// Helper builder used to configure the expression decision definition using the chain of builders.
        /// <see cref="ExpressionDecisionSrcBuilder"/> provides <see cref="ExpressionDecisionSrcBuilder.Put"/> method to define the expression
        /// and returns <see cref="ExpressionDecisionVarBuilder"/> used to define the output variable.
        /// </summary>
        public class ExpressionDecisionSrcBuilder
        {
            /// <summary>
            /// "Parent" expression decision builder.
            /// </summary>
            private ExpressionDecision Decision { get; }

            /// <summary>
            /// CTOR
            /// </summary>
            /// <param name="decision">"Parent" expression decision builder</param>
            internal ExpressionDecisionSrcBuilder(ExpressionDecision decision)
            {
                Decision = decision;
            }

            /// <summary>Sets the expression of the expression decision</summary>
            /// <param name="expression">Expression to be evaluated </param>
            /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
            public ExpressionDecisionVarBuilder Put(string expression)
            {
                Decision.SetExpression(expression);
                return new ExpressionDecisionVarBuilder(Decision);

            }
        }
        /// <summary>
        /// Helper builder used to configure the expression decision definition using the chain of builders.
        /// <see cref="ExpressionDecisionVarBuilder"/> provides <see cref="ExpressionDecisionVarBuilder.To"/> method to define output variable
        /// and returns <see cref="ExpressionDecision">"final" expression decision builder</see>
        /// that can be used to configure the required inputs and decisions when needed and to fully build the expression decision
        /// </summary>
        public class ExpressionDecisionVarBuilder
        {
            /// <summary>
            /// "Parent" expression decision builder.
            /// </summary>
            private ExpressionDecision Decision { get; }

            /// <summary>
            /// CTOR
            /// </summary>
            /// <param name="decision">"Parent" expression decision builder</param>
            internal ExpressionDecisionVarBuilder(ExpressionDecision decision)
            {
                Decision = decision;
            }

            /// <summary>
            /// Sets the output variable to store the result of the decision expression evaluation to
            /// </summary>
            /// <param name="variable">Reference to the variable used to store the expression decision output</param>
            /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
            public ExpressionDecision To(Variable.Ref variable)
            {
                Decision.SetOutput(variable);
                return Decision;
            }
        }

        /// <summary>
        /// Builds the expression decision definition
        /// </summary>
        /// <returns>Decision definition built</returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the expression or output variable is not defined in builder</exception>
        protected internal override IDmnDecision Build()
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Decision is already built");

            if (OutputVariableInternal == null)
                throw Logger.Error<DmnBuilderException>($"Missing output variable for expression decision {Name}");

            if (string.IsNullOrWhiteSpace(Expression))
                throw Logger.Error<DmnBuilderException>($"Missing expression for expression decision {Name}");

            //create
            var expressionDecision = new DmnExpressionDecision(
                Name,
                Expression,
                OutputVariableInternal.GetResultOrBuild(),
                RequiredInputs.Select(i => Variables[i].GetResultOrBuild()).ToArray(),
                RequiredDecisions.Select(d => Decisions[d].GetResultOrBuild()).ToArray());
            ResultInternal = expressionDecision;
            return expressionDecision;
        }

        /// <inheritdoc />
        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"{base.ToString()} - Expression: {Expression} To:{OutputVariable.Name}";
        }
    }
}