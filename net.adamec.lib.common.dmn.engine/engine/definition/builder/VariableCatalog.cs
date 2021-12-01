using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace net.adamec.lib.common.dmn.engine.engine.definition.builder
{
    /// <summary>
    /// Catalog holding the variable definitions (builders) used in <see cref="DmnDefinitionBuilder"/> and their reference
    /// </summary>
    public sealed class VariableCatalog
    {
        /// <summary>
        /// Flag whether the definition has been already built.
        /// </summary>
        /// <remarks>When set to true, the definition can't be modified anymore -
        /// the modification functions will throw <see cref="DmnBuilderException"/> when called</remarks>
        public bool IsBuilt { get; private set; }

        /// <summary>
        /// Dictionary containing the variable definition builders by variable name
        /// </summary>
        public IReadOnlyDictionary<string, Variable> Variables => VariablesInternal;

        /// <summary>
        /// Internal dictionary containing the variable definition builders by variable name
        /// </summary>
        private Dictionary<string, Variable> VariablesInternal { get; } = new Dictionary<string, Variable>();

        /// <summary>
        /// Internal dictionary containing the variable definition builders by reference
        /// </summary>
        private Dictionary<Variable.Ref, Variable> VariablesByRef { get; } = new Dictionary<Variable.Ref, Variable>();

        /// <summary>
        /// Input data interface. Input data are stored as Variables with <see cref="IDmnVariable.IsInputParameter"/> flag,
        /// complex objects are supported
        /// </summary>
        public IReadOnlyDictionary<string, Variable> InputData =>
            Variables
                .Where(v => v.Value.IsInputParameter)
                .ToDictionary(i => i.Key, i => i.Value);

        /// <summary>
        /// Retrieves the <see cref="Variable"/> definition builder by its <see cref="Variable.Ref">reference</see>
        /// </summary>
        /// <param name="reference">Variable definition builder reference</param>
        /// <returns>Variable definition builder or null when the reference is not found</returns>
        public Variable this[Variable.Ref reference] =>
            VariablesByRef.TryGetValue(reference, out var variable) ? variable : null;

        /// <summary>
        /// Adds a variable to catalog
        /// </summary>
        /// <param name="variable">Variable definition builder to add</param>
        /// <returns>This variable catalog</returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the catalog has already been built</exception>
        public VariableCatalog AddVariable(Variable variable)
        {
            if (IsBuilt) throw new DmnBuilderException("Variable catalog is already built");
            if (variable == null) throw new ArgumentNullException(nameof(variable));
            var name = DmnVariableDefinition.NormalizeVariableName(variable.Name);
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Missing variable name", nameof(name));

            VariablesInternal.Add(name, variable);
            VariablesByRef.Add(variable.Reference, variable);

            return this;
        }

        /// <summary>
        /// Builds all variable definitions stored in the catalog
        /// </summary>
        /// <returns>Dictionary of the variable definitions by variable name</returns>
        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the catalog has already been built</exception>
        internal IReadOnlyDictionary<string, IDmnVariable> Build()
        {
            var retVal = Variables
                .Values
                .Select(b => b.GetResultOrBuild())
                .ToDictionary(
                    v => v.Name,
                    v => (IDmnVariable)v);
            IsBuilt = true;
            return retVal;
        }

        /// <exception cref="DmnBuilderException">Throws <see cref="DmnBuilderException"/> when the definition has already been built</exception>
        /// <inheritdoc />
        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"Is built: {IsBuilt}, {Variables.Count} total variables ({Variables.Count} inputs)";
        }
    }
}