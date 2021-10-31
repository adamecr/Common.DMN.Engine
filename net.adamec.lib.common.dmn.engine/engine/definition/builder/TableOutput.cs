using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using net.adamec.lib.common.dmn.engine.engine.decisions.table.definition;

namespace net.adamec.lib.common.dmn.engine.engine.definition.builder
{
    /// <summary>
    /// Definition of decision table output - contains index (order), mapping to the variable and optional list of allowed values
    /// </summary>
    public sealed class TableOutput : DmnBuilderElement<TableOutput, DmnDecisionTableOutput>
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
        private static Func<TableOutput, Ref> RefCtor { get; set; }

        /// <summary>
        /// Static CTOR - forces the run of <see cref="Ref"/> static CTOR to ensure that
        /// <seealso cref="RefCtor"/> is properly initialized
        /// </summary>
        static TableOutput()
        {
            RuntimeHelpers.RunClassConstructor(typeof(Ref).TypeHandle);
        }

        /// <summary>
        /// Table output definition builder reference class
        /// </summary>
        public sealed class Ref
        {
            /// <summary>
            /// Static CTOR - sets the <see cref="RefCtor"/> delegate to Ref's private instance CTOR
            /// allowing the "owner" to create the Ref instances
            /// </summary>
            static Ref()
            {
                RefCtor = output => new Ref(output);
            }

            /// <summary>
            /// Encapsulated table output ("owner" of the reference)
            /// </summary>
            private TableOutput Output { get; }
            /// <summary>
            /// Index (order) of the table output
            /// </summary>
            public int Index => Output.Index;

            /// <summary>
            /// Private CTOR - accessible from "owner class" via <see cref="RefCtor"/>
            /// </summary>
            /// <param name="output">Table output to create the reference for</param>
            private Ref(TableOutput output)
            {
                Output = output;
            }
        }

        /// <summary>
        /// Table output reference that can be used in other builders
        /// </summary>
        public Ref Reference { get; }

        /// <summary>
        /// Index of the output (order)
        /// </summary>
        /// <remarks>The outputs are "indexed" in the order as added to the table definition builder</remarks>
        public int Index { get; }

        /// <summary>
        /// Reference to variable to store the output to
        /// </summary>
        public Variable.Ref Variable => VariableInternal?.Reference;
        /// <summary>
        /// Variable to store the output to
        /// </summary>
        private Variable VariableInternal { get; set; }

        /// <summary>
        /// Optional array of allowed values
        /// </summary>
        public string[] AllowedValues { get; private set; }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="variables"><see cref="VariableCatalog"/> managing the definition builder variables</param>
        /// <param name="decisions"><see cref="DecisionCatalog"/> managing the definition builder decisions</param>
        /// <param name="index">Index of the output (order)</param>
        internal TableOutput(VariableCatalog variables, DecisionCatalog decisions, int index)
            : base(variables, decisions)
        {
            Index = index;
            Reference = RefCtor(this);
        }

        /// <summary>
        /// Binds the table output to given variable reference
        /// </summary>
        /// <param name="variableRef">Reference to variable used as the table output destination</param>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        /// <exception cref="ArgumentNullException">Throws <see cref="DmnBuilderException"/> when <paramref name="variableRef"/> is missing</exception>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when <paramref name="variableRef"/> can't be found in the variable catalog</exception>
        public TableOutput WithVariable(Variable.Ref variableRef)
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Table output is already built");
            if (variableRef == null) throw new ArgumentNullException(nameof(variableRef));

            var variable = Variables[variableRef] ?? throw Logger.Error<DmnBuilderException>($"Can't get the variable from reference {variableRef.Name}");
            VariableInternal = variable;

            return this;
        }

        /// <summary>
        /// Sets the list of values allowed for the output
        /// </summary>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public TableOutput WithAllowedValues(string[] allowedValues)
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Table output is already built");
            AllowedValues = allowedValues;
            return this;
        }

        /// <summary>
        /// Clears the list of values allowed for the output
        /// </summary>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public TableOutput WithoutAllowedValuesConstraint()
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Table output is already built");
            AllowedValues = null;
            return this;
        }

        /// <summary>
        /// Builds the decision table output definition
        /// </summary>
        /// <returns>Decision table output definition built</returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the output variable is not defined in builder</exception>
        protected internal override DmnDecisionTableOutput Build()
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Decision is already built");
            if (VariableInternal == null) throw Logger.Error<DmnBuilderException>("Variable must be defined for decision table output");

            var output = new DmnDecisionTableOutput(
                Index,
                VariableInternal.GetResultOrBuild(),
                AllowedValues);
            ResultInternal = output;
            return output;
        }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"#{Index}:{Variable}";
        }

    }
}