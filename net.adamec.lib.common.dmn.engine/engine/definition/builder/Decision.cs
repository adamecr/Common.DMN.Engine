using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using net.adamec.lib.common.dmn.engine.engine.decisions;

namespace net.adamec.lib.common.dmn.engine.engine.definition.builder
{
    /// <summary>
    /// Decision definition builder
    /// </summary>
    public abstract class Decision : DmnBuilderElement<Decision, IDmnDecision>

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
        private static Func<Decision, Ref> RefCtor { get; set; }

        /// <summary>
        /// Static CTOR - forces the run of <see cref="Ref"/> static CTOR to ensure that
        /// <seealso cref="RefCtor"/> is properly initialized
        /// </summary>
        static Decision()
        {
            RuntimeHelpers.RunClassConstructor(typeof(Ref).TypeHandle);
        }

        /// <summary>
        /// Decision definition builder reference class
        /// </summary>
        public sealed class Ref
        {
            /// <summary>
            /// Static CTOR - sets the <see cref="RefCtor"/> delegate to Ref's private instance CTOR
            /// allowing the "owner" to create the Ref instances
            /// </summary>
            static Ref()
            {
                RefCtor = d => new Ref(d);
            }

            /// <summary>
            /// Encapsulated decision ("owner" of the reference)
            /// </summary>
            private Decision Decision { get; }
            /// <summary>
            /// Decision unique name
            /// </summary>
            public string Name => Decision.Name;
            /// <summary>
            /// Type of the decision
            /// </summary>
            public Type DecisionType => Decision.GetType();

            /// <summary>
            /// Private CTOR - accessible from "owner class" via <see cref="RefCtor"/>
            /// </summary>
            /// <param name="decision">Decision to create the reference for</param>
            private Ref(Decision decision)
            {
                Decision = decision;
            }
        }

        /// <summary>
        /// Decision reference that can be used in other builders
        /// </summary>
        public Ref Reference { get; }

        /// <summary>
        /// Decision unique name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Decision required inputs (input variables)
        /// </summary>
        protected List<Variable.Ref> RequiredInputs { get; } = new List<Variable.Ref>();

        /// <summary>
        /// List of decisions, the decision depends on
        /// </summary>
        protected List<Ref> RequiredDecisions { get; } = new List<Ref>();

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="variables"><see cref="VariableCatalog"/> managing the definition builder variables</param>
        /// <param name="decisions"><see cref="DecisionCatalog"/> managing the definition builder decisions</param>
        /// <param name="name">Unique name of the decision</param>
        protected Decision(VariableCatalog variables, DecisionCatalog decisions, string name) : base(variables,
            decisions)
        {
            if (name is null) throw new ArgumentNullException(nameof(name));
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Missing name", nameof(name));

            Name = name;
            Reference = RefCtor(this);
        }

        /// <summary>
        /// Adds the required input reference to the decision.
        /// </summary>
        /// <remarks>Required inputs represents the "link" between input and decision in a model.
        /// Technically, the input requirements (existence of the input) are not checked during the execution,
        /// it's more for better understanding the DMN model</remarks>
        /// <param name="input">Reference to the input variable</param>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        protected void AddRequiredInput(Variable.Ref input)
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Decision is already built");
            if (input == null) throw new ArgumentNullException(nameof(input));
            if (!input.IsInputParameter)
                throw Logger.Error<DmnBuilderException>($"Variable {input.Name} is not an input parameter");

            if(Variables[input]==null) throw Logger.Error<DmnBuilderException>($"Can't get the variable from reference {input.Name}");

            if (!RequiredInputs.Contains(input))
                RequiredInputs.Add(input);
        }

        /// <summary>
        /// Adds the required decision reference to the decision.
        /// </summary>
        /// <remarks>When executing the decision, the engine checks for required decisions and executes them before executing this decision</remarks>
        /// <param name="decision">Reference to the decision this decision depends on </param>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        protected void AddRequiredDecision(Ref decision)
        {
            if (IsBuilt) throw Logger.Error<DmnBuilderException>("Decision is already built");
            if (decision == null) throw new ArgumentNullException(nameof(decision));

            if (Decisions[decision] == null) throw Logger.Error<DmnBuilderException>($"Can't get the decision from reference {decision.Name}");

            if (!RequiredDecisions.Contains(decision))
                RequiredDecisions.Add(decision);
        }

        /// <inheritdoc />
        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"{Name} {GetType().Name}";
        }
    }
}