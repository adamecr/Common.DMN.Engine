using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using net.adamec.lib.common.dmn.engine.engine.decisions;

namespace net.adamec.lib.common.dmn.engine.engine.definition.builder
{
    /// <summary>
    /// Catalog holding the decision definition builders used in <see cref="DmnDefinitionBuilder"/> and their reference
    /// </summary>
    public sealed class DecisionCatalog
    {
        /// <summary>
        /// Flag whether the definition has been already built.
        /// </summary>
        /// <remarks>When set to true, the definition can't be modified anymore -
        /// the modification functions will throw <see cref="DmnBuilderException"/> when called</remarks>
        public bool IsBuilt { get; private set; }

        /// <summary>
        /// Dictionary containing the decisions definition builders by decision name
        /// </summary>
        public IReadOnlyDictionary<string, Decision> Decisions => decisions;

        /// <summary>
        /// Internal dictionary containing the decisions definition builders by decision name
        /// </summary>
        private readonly Dictionary<string, Decision> decisions = new Dictionary<string, Decision>();

        /// <summary>
        /// Internal dictionary containing the decisions definition builders by reference
        /// </summary>
        private Dictionary<Decision.Ref, Decision> DecisionsByRef { get; } = new Dictionary<Decision.Ref, Decision>();

        /// <summary>
        /// Retrieves the <see cref="Decision"/> definition builder by its <see cref="Decision.Ref">reference</see>
        /// </summary>
        /// <param name="reference">Decision definition builder reference</param>
        /// <returns>Decision definition builder or null when the reference is not found</returns>
        public Decision this[Decision.Ref reference] =>
            DecisionsByRef.TryGetValue(reference, out var decision) ? decision : null;

        /// <summary>
        /// Adds a decision to catalog
        /// </summary>
        /// <param name="decision">Decision definition builder to add</param>
        /// <returns>This decision catalog</returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the catalog has already been built</exception>
        public DecisionCatalog AddDecision(Decision decision)
        {
            if (IsBuilt) throw new DmnBuilderException("Decision catalog is already built");
            if (decision == null) throw new ArgumentNullException(nameof(decision));

            var name = decision.Name;
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Missing decision name", nameof(name));

            decisions.Add(name, decision);
            DecisionsByRef.Add(decision.Reference, decision);

            return this;
        }

        /// <summary>
        /// Builds all decision definitions stored in the catalog
        /// </summary>
        /// <returns>Dictionary of the variable definitions by variable name</returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the catalog has already been built</exception>
        internal IReadOnlyDictionary<string, IDmnDecision> Build()
        {
            if (IsBuilt) throw new DmnBuilderException("Decision catalog is already built");
            var retVal = Decisions
                .Values
                .Select(b => b.GetResultOrBuild())
                .ToDictionary(
                    v => v.Name,
                    v => v);
            IsBuilt = true;
            return retVal;
        }

        /// <inheritdoc />
        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"Is built: {IsBuilt}, {Decisions.Count} decisions";
        }
    }
}