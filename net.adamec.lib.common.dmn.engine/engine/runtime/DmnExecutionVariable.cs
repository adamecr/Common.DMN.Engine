using System;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.logging;

namespace net.adamec.lib.common.dmn.engine.engine.runtime
{
    /// <summary>
    /// Runtime (execution) variable
    /// </summary>
    public class DmnExecutionVariable
    {
        /// <summary>
        /// Logger
        /// </summary>
        protected static ILogger Logger = CommonLogging.CreateLogger<DmnExecutionVariable>();

        /// <summary>
        /// Variable definition
        /// </summary>
        private readonly DmnVariableDefinition definition;

        /// <summary>
        /// Unique variable name
        /// </summary>
        public string Name => definition.Name;
        /// <summary>
        /// Variable type or null if not defined
        /// </summary>
        public Type Type => definition.Type;

        /// <summary>
        /// Flag whether the variable is input parameter
        /// </summary>
        public bool IsInputParameter => definition.IsInputParameter;

        /// <summary>
        /// Backing field for <see cref="Value"/> property
        /// </summary>
        // ReSharper disable once InconsistentNaming
        private object _value;

        /// <summary>
        /// Variable value
        /// </summary>
        /// <exception cref="DmnExecutorException">Setter: Can't override input parameter</exception>
        /// <exception cref="DmnExecutorException">Setter: Can't cast value to target type</exception>
        public object Value
        {
            get => _value;
            set
            {
                if (IsInputParameter) throw Logger.Error<DmnExecutorException>("Can't override input parameter");
                try
                {
                    _value = Type != null && value != null
                        ? Convert.ChangeType(value, Type)
                        : value;
                }
                catch (Exception ex)
                {
                    // ReSharper disable once InvertIf
                    if (ex is InvalidCastException || ex is FormatException || ex is OverflowException || ex is ArgumentNullException)
                    {
                        //most probably from Convert.ChangeType
                        throw Logger.Error<DmnExecutorException>($"Can't cast value to target type: {Type?.Name??"[null]"}. Value is: {value}");
                    }

                    Logger.Fatal(ex,$"Unexpected exception while setting the variable {Name}",null);
                    throw; //another exception, just re-throw
                }
            }
        }


        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="definition">Variable definition</param>
        /// <exception cref="ArgumentNullException"><paramref name="definition"/> is null</exception>
        /// <exception cref="DmnExecutorException">Missing variable name</exception>
        public DmnExecutionVariable(DmnVariableDefinition definition)
        {
            if(definition==null) throw Logger.Fatal<ArgumentNullException>($"{nameof(definition)} is null");
            if (string.IsNullOrWhiteSpace(definition.Name?.Trim()))
                throw Logger.Fatal<DmnExecutorException>($"Missing variable name");

            this.definition = definition;
        }

        /// <summary>
        /// Clones the variable
        /// </summary>
        /// <returns>Cloned variable</returns>
        public DmnExecutionVariable Clone()
        {
            var retVal = new DmnExecutionVariable(definition)
            {
                Value = Value //new DmnExecutionVariable.Value=this.Value - it's just bit confusing here ;-)
            };
            return retVal;
        }

        /// <summary>
        /// Sets the input parameter variable value
        /// </summary>
        /// <remarks>It's not possible to set the input parameter variable value using the <see cref="Value"/> property setter by design.
        /// This dedicated method it to be used to ensure that the input parameter value is set intentionally (from <see cref="DmnExecutionContext"/>)</remarks>
        /// <param name="value">Value to be set</param>
        /// <exception cref="DmnExecutorException">Variable is not an input parameter</exception>
        public void SetInputParameterValue(object value)
        {
            if (!IsInputParameter) throw Logger.Error<DmnExecutorException>($"{Name} is not an input parameter");
            _value = value;
        }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return $"{Name}{(Type == null ? "" : ":" + Type)}={Value ?? "[null]"}";
        }

        /// <summary>
        /// Gets the variable hashcode from name and value
        /// </summary>
        /// <returns>Variable hashcode</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var hash = 17;
                hash = hash * 23 + Name.GetHashCode();
                hash = hash * 23 + (Value?.GetHashCode() ?? 0);
                return hash;
            }
        }
    }
}
