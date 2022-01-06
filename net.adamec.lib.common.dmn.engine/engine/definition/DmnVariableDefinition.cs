using System;
using System.Collections.Generic;
using System.Linq;

namespace net.adamec.lib.common.dmn.engine.engine.definition
{
    /// <summary>
    /// Definition of DMN model variable
    /// </summary>
    public class DmnVariableDefinition : IDmnVariable

    {
        /// <summary>
        /// Name of the variable
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Type of the variable when recognized from the decisions
        /// </summary>
        public Type Type { get; protected set; }

        /// <summary>
        /// Flag whether the variable represents the input parameter of the decision model.
        /// Such variable will be read-only
        /// </summary>
        public bool IsInputParameter { get; }
        /// <summary>
        /// Flag whether the variable has any "setter" - is there any output to Variable or is Input parameter
        /// </summary>
        public bool HasValueSetter { get; protected set; }

        /// <summary>
        /// Enumerable list of value "setters" for the variable.
        /// </summary>
        /// <remarks>
        /// Can be "Input: {inputName}", "Table Decision {decisionName}" or "Expression Decision {decisionName}".
        /// </remarks>
        public IEnumerable<string> ValueSetters => valueSetters;

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
        /// <param name="name">Name of the variable</param>
        /// <param name="type">Optional Type of the variable if known</param>
        public DmnVariableDefinition(string name, Type type = null)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name not provided", nameof(name));

            Name = name;
            Type = type;
        }

        /// <summary>
        /// CTOR - variable for input
        /// </summary>
        /// <param name="name">Name of the variable</param>
        /// <param name="inputName">Name of the input</param>
        /// <param name="type">Optional Type of the variable if known</param>
        public DmnVariableDefinition(string name, string inputName, Type type = null) : this(name, type)
        {
            if (inputName == null) throw new ArgumentNullException(nameof(inputName));
            if (string.IsNullOrWhiteSpace(inputName)) throw new ArgumentException("Input name not provided", nameof(inputName));

            IsInputParameter = true;
            AddValueSetter($"Input: {inputName}");
        }

        /// <summary>
        /// CTOR - variable
        /// </summary>
        /// <param name="name">Name of the variable</param>
        /// <param name="type">Optional Type of the variable if known</param>
        /// <param name="isInputParameter">Flag whether the variable is backing the input</param>
        /// <param name="valueSetters">List of the information about the value setters</param>
        public DmnVariableDefinition(string name, Type type , bool isInputParameter, List<string> valueSetters) : this(name, type)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name not provided", nameof(name));
            
            IsInputParameter = isInputParameter;
            this.valueSetters = valueSetters;
        }
        

        /// <summary>
        /// Adds a value setter information to variable definition
        /// </summary>
        /// <param name="setter">Setter information to add</param>
        public void AddValueSetter(string setter)
        {
            if (setter == null) throw new ArgumentNullException(nameof(setter));
            if (string.IsNullOrWhiteSpace(setter)) throw new ArgumentException("Setter not provided", nameof(setter));

            HasValueSetter = true;
            valueSetters.Add(setter);
        }

        /// <summary>
        /// Sets the variable type if recognized later than constructed.
        /// When the type is already defined, the <see cref="InvalidOperationException"/> is thrown
        /// </summary>
        /// <param name="type">New Type of variable</param>
        public void SetRecognizedType(Type type)
        {
            if (Type != null)
                throw new InvalidOperationException($"The type of variable {Name} can't be set as it's already defined");

            Type = type ?? throw new ArgumentNullException(nameof(type));
        }


        /// <inheritdoc />
        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return $"{Name}{(Type == null ? "" : ":" + Type)}";
        }

        /// <summary>
        /// Normalize the variable name (trim and replace space with underscore) and
        /// check that all characters are letters, digits or underscore and that the first character is letter
        /// </summary>
        /// <param name="name"></param>
        /// <exception cref="ArgumentException"><paramref name="name"/> is null or empty or invalid</exception>
        /// <returns>Normalized variable name</returns>
        public static string NormalizeVariableName(string name)
        {
            var retVal = name?.Trim().Replace(' ', '_');

            if (string.IsNullOrWhiteSpace(retVal))
                throw new ArgumentException($"Variable name is null or empty",nameof(name));

            if (retVal.Any(c => !(char.IsLetter(c) || char.IsDigit(c)  || c == '_')))
                throw new ArgumentException($"Variable name '{name}' contains invalid character", nameof(name));

            if (!char.IsLetter(retVal[0]))
                throw new ArgumentException($"Variable name '{nameof(name)}' must start with letter", nameof(name));

            return retVal;
        }
    }
}
