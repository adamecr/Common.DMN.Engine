using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace net.adamec.lib.common.dmn.engine.engine.definition.builder
{
    /// <summary>
    /// Variable definition builder
    /// </summary>
    public sealed class Variable : DmnBuilderElement<Variable, DmnVariableDefinition>
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
        private static Func<Variable, Ref> RefCtor { get; set; }

        /// <summary>
        /// Static CTOR - forces the run of <see cref="Ref"/> static CTOR to ensure that
        /// <seealso cref="RefCtor"/> is properly initialized
        /// </summary>
        static Variable()
        {
            RuntimeHelpers.RunClassConstructor(typeof(Ref).TypeHandle);
        }

        /// <summary>
        /// Variable definition builder reference class
        /// </summary>
        public sealed class Ref
        {
            /// <summary>
            /// Static CTOR - sets the <see cref="RefCtor"/> delegate to Ref's private instance CTOR
            /// allowing the "owner" to create the Ref instances
            /// </summary>
            static Ref()
            {
                RefCtor = v => new Ref(v);
            }

            /// <summary>
            /// Encapsulated variable ("owner" of the reference)
            /// </summary>
            private Variable Variable { get; }
            /// <summary>
            /// Name of the variable
            /// </summary>
            public string Name => Variable.Name;

            /// <summary>
            /// Type of the variable
            /// </summary>
            public Type Type => Variable.Type;
            /// <summary>
            /// Flag whether the variable represents the input parameter of the decision model
            /// </summary>
            public bool IsInputParameter => Variable.IsInputParameter;

            /// <summary>
            /// Private CTOR - accessible from "owner class" via <see cref="RefCtor"/>
            /// </summary>
            /// <param name="variable">Variable to create the reference for</param>
            private Ref(Variable variable)
            {
                Variable = variable;
            }
        }

        /// <summary>
        /// Variable reference that can be used in other builders
        /// </summary>
        public Ref Reference { get; }

        /// <summary>
        /// Name of the variable
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Label of the variable
        /// </summary>
        public string Label { get; }
        /// <summary>
        /// Type of the variable
        /// </summary>
        public Type Type { get; private set; }

        /// <summary>
        /// Flag whether the variable represents the input parameter of the decision model.
        /// Such variable will be read-only
        /// </summary>
        public bool IsInputParameter { get; private set; }

        /// <summary>
        /// List of value "setters" for the variable.
        /// </summary>
        /// <remarks>
        /// Can be "Input: {inputName}", "Table Decision {decisionName}" or "Expression Decision {decisionName}".
        /// </remarks>
        private readonly List<string> valueSetters = new List<string>();

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="variables"><see cref="VariableCatalog"/> managing the definition builder variables</param>
        /// <param name="decisions"><see cref="DecisionCatalog"/> managing the definition builder decisions</param>
        /// <param name="name">Name of the variable</param>
        /// <param name="type">Optional Type of the variable if known</param>
        /// <param name="label">Label of the variable (input parameter), name is used when not provided</param>
        internal Variable(VariableCatalog variables, DecisionCatalog decisions, string name, Type type = null, string label=null)
            : base(variables, decisions)
        {
            name = DmnVariableDefinition.NormalizeVariableName(name ?? throw new ArgumentNullException(nameof(name)));
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name not provided", nameof(name));

            Reference = RefCtor(this);
            Name = name;
            Label = string.IsNullOrWhiteSpace(label) ? name : label;
            Type = type;
        }

        /// <summary>
        /// Flags variable for input
        /// </summary>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public Variable ForInput()
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Variable is already built");

            IsInputParameter = true;
            AddValueSetter($"Input: {Name}");
            return this;
        }

        /// <summary>
        /// Adds a value setter information to variable definition
        /// </summary>
        /// <param name="setter">Setter information to add</param>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public Variable AddValueSetter(string setter)
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Variable is already built");

            if (setter == null) throw new ArgumentNullException(nameof(setter));
            if (string.IsNullOrWhiteSpace(setter)) throw new ArgumentException("Setter not provided", nameof(setter));

            valueSetters.Add(setter);
            return this;
        }

        /// <summary>
        /// Assigns the variable with <see cref="Type"/> corresponding to the <paramref name="newType"/> and returns true.
        /// When the variable already contains the type information, it must match with the <paramref name="newType"/>,
        /// otherwise the <see cref="DmnBuilderException"/> is thrown.
        /// </summary>
        /// <param name="newType"><see cref="Type"/> to assign. If null, function returns without an exception (assuming that the type is not know yet)</param>
        /// <exception cref="DmnBuilderException">Thrown when the <paramref name="newType"/> doesn't match already existing <see cref="Variable.Type"/></exception>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        public Variable CheckAndSetVariableType(Type newType)
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Variable is already built");
            if (newType == null) return this;

            //check
            if (Type != null && Type != newType)
                throw Logger.Error<DmnBuilderException>(
                    $"The type {newType.FullName} for variable {Name} doesn't match the existing type {Type.FullName}");

            //set
            Type = newType;
            return this;
        }

        /// <summary>
        /// Builds the variable definition
        /// </summary>
        /// <returns>Variable definition built</returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        protected internal override DmnVariableDefinition Build()
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Variable is already built");
            if (string.IsNullOrWhiteSpace(Name))
                throw new InvalidOperationException("Missing name in variable to be built");

            ResultInternal = new DmnVariableDefinition(Name, Type, IsInputParameter, valueSetters,Label);
            return ResultInternal;
        }

        /// <inheritdoc />
        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"{Name}{(Type == null ? "" : ":" + Type)}";
        }

    }
}