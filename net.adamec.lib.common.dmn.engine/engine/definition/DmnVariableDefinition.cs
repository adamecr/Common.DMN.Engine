using System;
using System.Collections.Generic;

namespace net.adamec.lib.common.dmn.engine.engine.definition
{
    public class DmnVariableDefinition

    {
        public string Name { get; }
        public Type Type { get; set; }

        public bool IsInputParameter { get; set; }
        public bool HasValueSetter { get; set; } //is there any output to Variable or is Input parameter

        public List<string> ValueSetters { get; } = new List<string>();

        public DmnVariableDefinition(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name}{(Type == null ? "" : ":" + Type)}";
        }

    }
}
