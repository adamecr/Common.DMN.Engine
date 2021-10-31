using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using net.adamec.lib.common.dmn.engine.engine.decisions.table.definition;

namespace net.adamec.lib.common.dmn.engine.engine.definition.builder
{
    /// <summary>
    /// Definition of decision table input - contains index (order), mapping to the source variable or source expression, and optional list of allowed values
    /// </summary>
    /// <remarks>Source variable and source expression are mutually exclusive and one of them has to be provided.</remarks>
    public sealed class TableInput : DmnBuilderElement<TableInput, DmnDecisionTableInput>
    {
        /// <summary>
        /// Reference CTOR delegate
        /// </summary>
        /// <remarks>
        /// The idea is to allow only "owner class" to be able to create the instances of the nested class.
        /// Nested class has the private CTOR. Static CTOR of nested class (Ref) sets the delegate
        /// to <code>RefCtor = owner => new Ref(owner)</code>, so such delegate can be used within the owner class
        /// to create the instances of nested class.
        /// </remarks>
        private static Func<TableInput, Ref> RefCtor { get; set; }

        /// <summary>
        /// Static CTOR - forces the run of <see cref="Ref"/> static CTOR to ensure that
        /// <seealso cref="RefCtor"/> is properly initialized
        /// </summary>
        static TableInput()
        {
            RuntimeHelpers.RunClassConstructor(typeof(Ref).TypeHandle);
        }

        /// <summary>
        /// Table input definition builder reference class
        /// </summary>
        public sealed class Ref
        {
            /// <summary>
            /// Static CTOR - sets the <see cref="RefCtor"/> delegate to Ref's private instance CTOR
            /// allowing the "owner" to create the Ref instances
            /// </summary>
            static Ref()
            {
                RefCtor = input => new Ref(input);
            }

            /// <summary>
            /// Encapsulated table input ("owner" of the reference)
            /// </summary>
            private TableInput Input { get; }
            /// <summary>
            /// Index (order) of the table input
            /// </summary>
            public int Index => Input.Index;

            /// <summary>
            /// Private CTOR - accessible from "owner class" via <see cref="RefCtor"/>
            /// </summary>
            /// <param name="input">Table input to create the reference for</param>
            private Ref(TableInput input)
            {
                Input = input;
            }
        }

        /// <summary>
        /// Table input reference that can be used in other builders
        /// </summary>
        public Ref Reference { get; }

        /// <summary>
        /// Index of the input (order)
        /// </summary>
        /// <remarks>The inputs are "indexed" in the order as added to the table definition builder</remarks>
        public int Index { get; }

        /// <summary>
        /// Reference to input source variable (the variable value is compared to the rules)
        /// </summary>
        /// <remarks>Source variable and source expression are mutually exclusive.</remarks>
        public Variable.Ref Variable => VariableInternal?.Reference;
        /// <summary>
        /// Input source variable (the variable value is compared to the rules)
        /// </summary>
        /// <remarks>Source variable and source expression are mutually exclusive.</remarks>
        private Variable VariableInternal { get; set; }
        /// <summary>
        /// Input source expression (the evaluated expression is compared to the rules)
        /// </summary>
        /// <remarks>Source variable and source expression are mutually exclusive.</remarks>
        public string Expression { get; private set; }

        /// <summary>
        /// Optional array of allowed values
        /// </summary>
        public string[] AllowedValues { get; private set; }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="variables"><see cref="VariableCatalog"/> managing the definition builder variables</param>
        /// <param name="decisions"><see cref="DecisionCatalog"/> managing the definition builder decisions</param>
        /// <param name="index">Index of the input (order)</param>
        internal TableInput(VariableCatalog variables, DecisionCatalog decisions, int index)
            : base(variables, decisions)
        {
            Index = index;
            Reference = RefCtor(this);
        }

        /// <summary>
        /// Binds the table input to given variable reference
        /// </summary>
        /// <param name="variableRef">Reference to variable used as the table input source</param>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        /// <exception cref="ArgumentNullException">Throws <see cref="DmnBuilderException"/> when <paramref name="variableRef"/> is missing</exception>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when <paramref name="variableRef"/> can't be found in the variable catalog</exception>
        public TableInput WithVariable(Variable.Ref variableRef)
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Table input is already built");
            if (variableRef == null) throw new ArgumentNullException(nameof(variableRef));

            var variable = Variables[variableRef] ?? throw Logger.Error<DmnBuilderException>($"Can't get the variable from reference {variableRef.Name}");
            VariableInternal = variable;
            Expression = null;
            return this;
        }

        /// <summary>
        /// Binds the table input to given expression
        /// </summary>
        /// <param name="expression">Expression to be used as the table input source</param>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        /// <exception cref="ArgumentNullException">Throws <see cref="DmnBuilderException"/> when <paramref name="expression"/> is missing</exception>
        /// <exception cref="ArgumentException">Throws <see cref="ArgumentException"/> when <paramref name="expression"/> is empty or whitespace</exception>
        public TableInput WithExpression(string expression)
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Table input is already built");
            Expression = expression ?? throw new ArgumentNullException(nameof(expression));
            if (string.IsNullOrWhiteSpace(expression)) throw new ArgumentException("Missing expression", nameof(expression));

            VariableInternal = null;
            return this;
        }

        /// <summary>
        /// Sets the list of values allowed for the input
        /// </summary>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public TableInput WithAllowedValues(string[] allowedValues)
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Table input is already built");

            AllowedValues = allowedValues;
            return this;
        }

        /// <summary>
        /// Clears the list of values allowed for the input
        /// </summary>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public TableInput WithoutAllowedValuesConstraint()
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Table input is already built");

            AllowedValues = null;
            return this;
        }

        /// <summary>
        /// Builds the decision table input definition
        /// </summary>
        /// <returns>Decision table input definition built</returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when neither expression nor variable is defined for the input </exception>
        protected internal override DmnDecisionTableInput Build()
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Decision is already built");

            if (Expression == null && VariableInternal == null)
                throw Logger.Error<DmnBuilderException>("Either Expression or Variable must be defined for decision table input");

            var input = new DmnDecisionTableInput(
                Index,
                VariableInternal?.GetResultOrBuild(),
                Expression,
                AllowedValues);
            ResultInternal = input;
            return input;
        }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"#{Index}:{Variable?.ToString() ?? "{" + Expression + "}"}";
        }
    }
}