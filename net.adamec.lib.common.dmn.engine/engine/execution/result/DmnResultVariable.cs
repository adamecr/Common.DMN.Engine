using System;
using System.Diagnostics.CodeAnalysis;
using net.adamec.lib.common.dmn.engine.engine.execution.context;

namespace net.adamec.lib.common.dmn.engine.engine.execution.result
{
    /// <summary>
    /// Execution result variable
    /// </summary>
    public class DmnResultVariable
    {
        /// <summary>
        /// Unique variable name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Variable type or null if not defined
        /// </summary>
        public Type Type { get; }

        /// <summary>
        /// Flag whether the variable is input parameter
        /// </summary>
        public bool IsInputParameter { get; }
        
        /// <summary>
        /// Variable value
        /// </summary>
        public object Value { get; }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="executionVariable">Execution variable to build the result variable from</param>
        /// <exception cref="ArgumentNullException"><paramref name="executionVariable"/> is null</exception>
        /// <exception cref="ArgumentException">Missing variable name in <paramref name="executionVariable"/></exception>
        public DmnResultVariable(DmnExecutionVariable executionVariable)
        {
            if (executionVariable == null) throw new ArgumentNullException(nameof(executionVariable));
            if (string.IsNullOrWhiteSpace(executionVariable.Name?.Trim()))
                throw new ArgumentException("Missing variable name",nameof(executionVariable));
           
            Name = executionVariable.Name;
            Type = executionVariable.Type;
            IsInputParameter = executionVariable.IsInputParameter;
            Value = executionVariable.Value;
        }

        /// <summary>
        /// CTOR used by <see cref="Clone"/>
        /// </summary>
        /// <param name="cloneFrom">Variable to be cloned</param>
        private DmnResultVariable(DmnResultVariable cloneFrom)
        {
            if (cloneFrom == null) throw new ArgumentNullException(nameof(cloneFrom));
            Name = cloneFrom.Name;
            Type = cloneFrom.Type;
            IsInputParameter = cloneFrom.IsInputParameter;
            if (cloneFrom.Value is ICloneable cloneableValue)
            {
                Value = cloneableValue.Clone();
            }
            else
            {
                Value = cloneFrom.Value;
            }
        }
        /// <summary>
        /// Clones the variable
        /// </summary>
        /// <returns>Cloned variable</returns>
        public virtual DmnResultVariable Clone()
        {
            var retVal = new DmnResultVariable(this);
            return retVal;
        }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"{Name}{(Type == null ? "" : ":" + Type)}={Value ?? "[null]"}";
        }

    }
}
