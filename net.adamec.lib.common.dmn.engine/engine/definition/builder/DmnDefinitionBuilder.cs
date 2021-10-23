using System;
using System.Diagnostics.CodeAnalysis;
using net.adamec.lib.common.core.logging;

namespace net.adamec.lib.common.dmn.engine.engine.definition.builder
{
    /// <summary>
    /// Builder used to create <see cref="DmnDefinition"/>
    /// </summary>
    public class DmnDefinitionBuilder
    {
        /// <summary>
        /// Logger
        /// </summary>
        private static readonly ILogger Logger = CommonLogging.CreateLogger<DmnDefinitionBuilder>();

        /// <summary>
        /// Flag whether the definition has been already built.
        /// </summary>
        /// <remarks>When set to true, the definition can't be modified anymore -
        /// the modification functions will throw <see cref="DmnBuilderException"/> when called</remarks>
        public bool IsBuilt { get; private set; }

        /// <summary>
        /// Catalog holding the variables used in <see cref="DmnDefinitionBuilder"/>
        /// </summary>
        private VariableCatalog Variables { get; } = new VariableCatalog();

        /// <summary>
        /// Catalog holding the decisions used in <see cref="DmnDefinitionBuilder"/>
        /// </summary>
        private DecisionCatalog Decisions { get; } = new DecisionCatalog();

        /// <summary>
        /// Adds the inputs of <typeparamref name="TVariableType"/> with given <paramref name="names"/> into the definition
        /// </summary>
        /// <typeparam name="TVariableType">Type of the inputs to add</typeparam>
        /// <param name="names">Names of the inputs to add</param>
        /// <returns>The current <see cref="DmnDefinitionBuilder"/></returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public DmnDefinitionBuilder WithInputs<TVariableType>(params string[] names)
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Definition is already built");

            // ReSharper disable once InvertIf
            if ((names?.Length ?? 0) > 0)
            {
                foreach (var name in names)
                {
                    WithInput(name, typeof(TVariableType));
                }
            }

            return this;
        }

        /// <summary>
        /// Adds the untyped input with given <paramref name="name"/> into the definition.
        /// Avoid using the untyped inputs where possible - the input type will be set based on the value assigned to the <see cref="execution.context.DmnExecutionContext"/>,
        /// so this needs to be taken into the consideration when defining the decisions
        /// </summary>
        /// <param name="name">Name of the input to add</param>
        /// <returns>The current <see cref="DmnDefinitionBuilder"/></returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public DmnDefinitionBuilder WithInput(string name)
        {
            return WithInput(name, null, out _);
        }

        /// <summary>
        /// Adds the untyped input with given <paramref name="name"/> into the definition.
        /// Avoid using the untyped inputs where possible - the input type will be set based on the value assigned to the <see cref="execution.context.DmnExecutionContext"/>,
        /// so this needs to be taken into the consideration when defining the decisions
        /// </summary>
        /// <param name="name">Name of the input to add</param>
        /// <param name="inputVariable">Reference to the input variable backing the input added</param>
        /// <returns>The current <see cref="DmnDefinitionBuilder"/></returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public DmnDefinitionBuilder WithInput(string name, out Variable.Ref inputVariable)
        {
            return WithInput(name, null, out inputVariable);
        }

        /// <summary>
        /// Adds the inputs of given <paramref name="name"/> and <paramref name="variableType">type</paramref> into the definition
        /// </summary>
        /// <param name="name">Name of the input to add</param>
        /// <param name="variableType">Type of the input to add</param>
        /// <returns>The current <see cref="DmnDefinitionBuilder"/></returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public DmnDefinitionBuilder WithInput(string name, Type variableType)
        {
            return WithInput(name, variableType, out _);
        }

        /// <summary>
        /// Adds the inputs of given <paramref name="name"/> and <typeparamref name="TVariableType">type</typeparamref> into the definition
        /// </summary>
        /// <param name="name">Name of the input to add</param>
        /// <typeparam name="TVariableType">Type of the input to add</typeparam>
        /// <returns>The current <see cref="DmnDefinitionBuilder"/></returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public DmnDefinitionBuilder WithInput<TVariableType>(string name)
        {
            return WithInput(name, typeof(TVariableType), out _);
        }

        /// <summary>
        /// Adds the inputs of given <paramref name="name"/> and <typeparamref name="TVariableType">type</typeparamref> into the definition
        /// </summary>
        /// <param name="name">Name of the input to add</param>
        /// <param name="inputVariable">Reference to the input variable backing the input added</param>
        /// <typeparam name="TVariableType">Type of the input to add</typeparam>
        /// <returns>The current <see cref="DmnDefinitionBuilder"/></returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public DmnDefinitionBuilder WithInput<TVariableType>(string name, out Variable.Ref inputVariable)
        {
            return WithInput(name, typeof(TVariableType), out inputVariable);
        }

        /// <summary>
        /// Adds the inputs of given <paramref name="name"/> and <paramref name="variableType">type</paramref> into the definition
        /// </summary>
        /// <param name="name">Name of the input to add</param>
        /// <param name="variableType">Type of the input to add</param>
        /// <param name="inputVariable">Reference to the input variable backing the input added</param>
        /// <returns>The current <see cref="DmnDefinitionBuilder"/></returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public DmnDefinitionBuilder WithInput(string name, Type variableType, out Variable.Ref inputVariable)
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Definition is already built");
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Missing input name", nameof(name));

            var variableName = DmnVariableDefinition.NormalizeVariableName(name);
            var existingInputs = Variables.InputData;
            if (existingInputs.ContainsKey(variableName))
                throw Logger.Error<DmnBuilderException>($"Duplicate input variable name {variableName} (normalized from {name})");
            
            var existingVariables = Variables.Variables;
            if (existingVariables.ContainsKey(variableName)) throw Logger.Error<DmnBuilderException>($"Duplicate variable name {variableName} (normalized from {name})");


            var variable = new Variable(Variables, Decisions, variableName, variableType).ForInput();
            inputVariable = variable.Reference;
            Variables.AddVariable(variable);

            return this;
        }

        /// <summary>
        /// Adds the (non-input) variables of <typeparamref name="TVariableType"/> with given <paramref name="names"/> into the definition
        /// </summary>
        /// <typeparam name="TVariableType">Type of the variable to add</typeparam>
        /// <param name="names">Names of the variables to add</param>
        /// <returns>The current <see cref="DmnDefinitionBuilder"/></returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public DmnDefinitionBuilder WithVariables<TVariableType>(params string[] names)
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Definition is already built");

            // ReSharper disable once InvertIf
            if ((names?.Length ?? 0) > 0)
            {
                foreach (var name in names)
                {
                    WithVariable(name, typeof(TVariableType));
                }
            }

            return this;
        }

        /// <summary>
        /// Adds the (non-input) variable of given <paramref name="name"/> and <paramref name="variableType">type</paramref> into the definition
        /// </summary>
        /// <param name="name">Name of the variable to add</param>
        /// <param name="variableType">Type of the variable to add</param>
        /// <returns>The current <see cref="DmnDefinitionBuilder"/></returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public DmnDefinitionBuilder WithVariable(string name, Type variableType)
        {
            return WithVariable(name, variableType, out _);
        }

        /// <summary>
        /// Adds the (non-input) variable of given <paramref name="name"/> and <typeparamref name="TVariableType">type</typeparamref> into the definition
        /// </summary>
        /// <param name="name">Name of the variable to add</param>
        /// <typeparam name="TVariableType">Type of the variable to add</typeparam>
        /// <returns>The current <see cref="DmnDefinitionBuilder"/></returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public DmnDefinitionBuilder WithVariable<TVariableType>(string name)
        {
            return WithVariable(name, typeof(TVariableType), out _);
        }

        /// <summary>
        /// Adds the (non-input) variable of given <paramref name="name"/> and <typeparamref name="TVariableType">type</typeparamref> into the definition
        /// </summary>
        /// <param name="name">Name of the variable to add</param>
        /// <param name="variableRef">Reference to the variable added</param>
        /// <typeparam name="TVariableType">Type of the variable to add</typeparam>
        /// <returns>The current <see cref="DmnDefinitionBuilder"/></returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public DmnDefinitionBuilder WithVariable<TVariableType>(string name, out Variable.Ref variableRef)
        {
            return WithVariable(name, typeof(TVariableType), out variableRef);
        }

        /// <summary>
        /// Adds the (non-input) variable of given <paramref name="name"/> and <paramref name="variableType">type</paramref> into the definition
        /// </summary>
        /// <param name="name">Name of the variable to add</param>
        /// <param name="variableType">Type of the variable to add</param>
        /// <param name="variableRef">Reference to the variable added</param>
        /// <returns>The current <see cref="DmnDefinitionBuilder"/></returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public DmnDefinitionBuilder WithVariable(string name, Type variableType, out Variable.Ref variableRef)
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Definition is already built");
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Missing variable name", nameof(name));

            var variableName = DmnVariableDefinition.NormalizeVariableName(name);
            if (Variables.Variables.ContainsKey(variableName)) throw Logger.Error<DmnBuilderException>($"Duplicate variable name {variableName} (normalized from {name})");

            var variable = new Variable(Variables, Decisions, variableName, variableType);
            variableRef = variable.Reference;
            Variables.AddVariable(variable);

            return this;
        }

        /// <summary>
        /// Adds the expression decision into the definition
        /// </summary>
        /// <param name="name">Name of the decision to add</param>
        /// <param name="expression">Expression to be evaluated during the decision execution</param>
        /// <param name="outputVariable">Reference to existing variable to store the output of the decision evaluation</param>
        /// <returns>The current <see cref="DmnDefinitionBuilder"/></returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public DmnDefinitionBuilder WithExpressionDecision(string name, string expression, Variable.Ref outputVariable)
        {
            return WithExpressionDecision(name, e => e.Put(expression).To(outputVariable), out _);
        }

        /// <summary>
        /// Adds the expression decision into the definition
        /// </summary>
        /// <param name="name">Name of the decision to add</param>
        /// <param name="expression">Expression to be evaluated during the decision execution</param>
        /// <param name="outputVariable">Reference to existing variable to store the output of the decision evaluation</param>
        /// <param name="decisionRef">Reference to the decision added</param>
        /// <returns>The current <see cref="DmnDefinitionBuilder"/></returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public DmnDefinitionBuilder WithExpressionDecision(string name, string expression, Variable.Ref outputVariable, out Decision.Ref decisionRef)
        {
            return WithExpressionDecision(name, e => e.Put(expression).To(outputVariable), out decisionRef);
        }

        /// <summary>
        /// Adds the expression decision into the definition
        /// </summary>
        /// <param name="name">Name of the decision to add</param>
        /// <param name="builder">Builder to be used to fully configure the expression decision definition</param>
        /// <returns>The current <see cref="DmnDefinitionBuilder"/></returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public DmnDefinitionBuilder WithExpressionDecision(string name, Func<ExpressionDecision.ExpressionDecisionSrcBuilder, ExpressionDecision> builder)
        {
            return WithExpressionDecision(name, builder, out _);
        }

        /// <summary>
        /// Adds the expression decision into the definition
        /// </summary>
        /// <param name="name">Name of the decision to add</param>
        /// <param name="builder">Builder to be used to fully configure the expression decision definition</param>
        /// <param name="decisionRef">Reference to the decision added</param>
        /// <returns>The current <see cref="DmnDefinitionBuilder"/></returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public DmnDefinitionBuilder WithExpressionDecision(string name, Func<ExpressionDecision.ExpressionDecisionSrcBuilder, ExpressionDecision> builder, out Decision.Ref decisionRef)
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Definition is already built");
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Missing decision name", nameof(name));
            if (builder is null) throw new ArgumentNullException(nameof(builder));

            if (Decisions.Decisions.ContainsKey(name)) throw Logger.Error<DmnBuilderException>($"Decision {name} already exists");

            var decision = new ExpressionDecision(Variables, Decisions, name);
            decisionRef = decision.Reference;
            Decisions.AddDecision(decision);
            builder.Invoke(new ExpressionDecision.ExpressionDecisionSrcBuilder(decision));

            return this;
        }

        /// <summary>
        /// Adds the decision table into the definition
        /// </summary>
        /// <param name="name">Name of the decision table to add</param>
        /// <param name="builder">Builder to be used to fully configure the decision table definition</param>
        /// <returns>The current <see cref="DmnDefinitionBuilder"/></returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public DmnDefinitionBuilder WithTableDecision(string name, Func<TableDecision, TableDecision> builder)
        {
            return WithTableDecision(name, builder, out _);
        }

        /// <summary>
        /// Adds the decision table into the definition
        /// </summary>
        /// <param name="name">Name of the decision table to add</param>
        /// <param name="builder">Builder to be used to fully configure the decision table definition</param>
        /// <param name="decisionRef">Reference to the decision added</param>
        /// <returns>The current <see cref="DmnDefinitionBuilder"/></returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public DmnDefinitionBuilder WithTableDecision(string name, Func<TableDecision, TableDecision> builder, out Decision.Ref decisionRef)
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Definition is already built");
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Missing decision name", nameof(name));
            if (builder is null) throw new ArgumentNullException(nameof(builder));

            if (Decisions.Decisions.ContainsKey(name)) throw Logger.Error<DmnBuilderException>($"Decision {name} already exists");

            var decision = new TableDecision(Variables, Decisions, name);
            decisionRef = decision.Reference;
            Decisions.AddDecision(decision);
            builder.Invoke(decision);

            return this;
        }

        /// <summary>
        /// Builds the DMN definition as prepared in <see cref="DmnDefinitionBuilder"/> and returns <see cref="DmnDefinition"/> that can be
        /// executed within <see cref="execution.context.DmnExecutionContext"/>
        /// </summary>
        /// <returns><see cref="DmnDefinition"/> that can be executed within <see cref="execution.context.DmnExecutionContext"/></returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition contains no decision</exception>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public DmnDefinition Build()
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Definition is already built");

            IsBuilt = true;
            if (Decisions.Decisions.Count == 0)
            {
                throw Logger.Error<DmnBuilderException>($"No decision in DMN definition");
            }
            return new DmnDefinition(Variables.Build(), Decisions.Build());
        }

        /// <inheritdoc />
        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"Is built: {IsBuilt}, {Variables.Variables.Count} total variables ({Variables.InputData.Count} inputs), {Decisions.Decisions.Count} decisions";
        }
    }


}