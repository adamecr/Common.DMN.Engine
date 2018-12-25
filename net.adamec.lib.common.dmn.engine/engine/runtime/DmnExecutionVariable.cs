using System;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.logging;

namespace net.adamec.lib.common.dmn.engine.engine.runtime
{
    public class DmnExecutionVariable
    {
        protected static ILogger Logger = CommonLogging.CreateLogger<DmnExecutionVariable>();

        private readonly DmnVariableDefinition definition;

        public string Name => definition.Name;
        public Type Type => definition.Type;

        public bool IsInputParameter => definition.IsInputParameter;
        
        // ReSharper disable once InconsistentNaming
        private object _value;

        public object Value
        {
            get => _value;
            set
            {
                if (IsInputParameter) throw Logger.Error<DmnExecutorException>("Can't override input parameter");
                _value = Type != null && value != null ? Convert.ChangeType(value, Type) : value; //TODO Cast exception
            }
        }



        public DmnExecutionVariable(DmnVariableDefinition definition)
        {
            if (string.IsNullOrWhiteSpace(definition?.Name?.Trim()))
                throw Logger.Fatal<DmnExecutorException>($"Missing variable name");
            this.definition = definition;
        }

        public DmnExecutionVariable Clone()
        {
            var retVal = new DmnExecutionVariable(definition)
            {
                Value = Value,
            };
            return retVal;
        }

        public void SetInputParameterValue(object value)
        {
            if (!IsInputParameter) throw Logger.Error<DmnExecutorException>($"{Name} is not an input parameter");
            _value = value;
        }

        public override string ToString()
        {
            return $"{Name}{(Type == null ? "" : ":" + Type)}={Value ?? "[null]"}";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hash = 17;
                hash = hash * 23 + (Name.GetHashCode());
                hash = hash * 23 + (Value?.GetHashCode() ?? 0);
                return hash;
            }
        }
    }
}
