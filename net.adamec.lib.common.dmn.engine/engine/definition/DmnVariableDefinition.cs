using System;
using System.Collections.Generic;
using System.Linq;
using net.adamec.lib.common.dmn.engine.utils;

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
        /// Label of the variable (used for input parameters)
        /// </summary>
        public string Label { get; }

        /// <summary>
        /// Name with label information in case <see cref="Label"/> is different than <see cref="Name"/>
        /// </summary>
        public string NameWithLabel => DmnUtils.NameWithLabel(Name, Label);

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
        /// List of extensions that can be used to any related data.
        /// Engine doesn't neither manage nor touches the extensions
        /// </summary>
        public List<object> Extensions { get; } = new List<object>();

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="name">Name of the variable</param>
        /// <param name="type">Optional Type of the variable if known</param>
        /// <param name="label">Optional variable label. Name is used when not set</param>
        public DmnVariableDefinition(string name, Type type = null, string label = null)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name not provided", nameof(name));

            Name = name;
            Label = string.IsNullOrWhiteSpace(label) ? name : label;
            Type = type;
        }

        /// <summary>
        /// CTOR - variable for input
        /// </summary>
        /// <param name="name">Name of the variable</param>
        /// <param name="inputName">Name of the input</param>
        /// <param name="type">Optional Type of the variable if known</param>
        /// <param name="label">Optional variable label. Name is used when not set</param>
        public DmnVariableDefinition(string name, string inputName, Type type = null, string label = null) : this(name, type, label)
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
        /// <param name="label">Optional variable label. Name is used when not set</param>
        public DmnVariableDefinition(string name, Type type, bool isInputParameter, List<string> valueSetters, string label = null) : this(name, type, label)
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
        /// Normalize the variable name (trim, replace space with underscore and remove some special characters) and
        /// check that all characters are letters, digits or underscore and that the first character is letter
        /// </summary>
        /// <param name="name">Proposed variable name to be normalized</param>
        /// <exception cref="ArgumentException"><paramref name="name"/> is null or empty or invalid</exception>
        /// <returns>Normalized variable name</returns>
        public static string NormalizeVariableName(string name)
        {
            if (CanNormalizeVariableName(name, out var normalizedName, out var error)) return normalizedName;
            throw new ArgumentException(error, nameof(name));

        }

        /// <summary>
        /// Tries to normalize the variable name (trim, replace space with underscore and remove some special characters) and
        /// check that all characters are letters, digits or underscore and that the first character is letter.
        /// </summary>
        /// <param name="name">Proposed variable name to be normalized</param>
        /// <param name="normalizedName">Normalized variable name when valid</param>
        /// <param name="error">Validation error message when invalid</param>
        /// <returns>True when the <paramref name="name"/> can be normalized (together with <paramref name="normalizedName"/>)
        /// or false when the normalization failed (together with <paramref name="error"/>)</returns>
        public static bool CanNormalizeVariableName(string name, out string normalizedName, out string error)
        {
            error = null;
            var retVal = name?.Trim()
                .Replace(' ', '_')
                .Replace('-', '_')
                .Replace("?", "")
                .Replace("#", "")
                .Replace("$", "")
                .Replace("%", "")
                .Replace("&", "")
                .Replace("*", "")
                .Replace("(", "")
                .Replace(")", "");

            if (string.IsNullOrWhiteSpace(retVal))
            {
                error = $"Variable name is null or empty";
            }
            else if (retVal.Any(c => !(char.IsLetter(c) || char.IsDigit(c) || c == '_')))
            {
                error = $"Variable name '{name}' contains invalid character";
            }
            else if (!char.IsLetter(retVal[0]) && retVal[0]!='_')
            {
                error = $"Variable name '{nameof(name)}' must start with letter or underscore";
            }

            if (error == null)
            {
                normalizedName = retVal;
                return true;
            }

            normalizedName = null;
            return false;
        }
    }
}
