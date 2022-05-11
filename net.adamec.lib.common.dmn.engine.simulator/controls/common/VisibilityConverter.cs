using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.common
{
    /// <summary>
    /// General <see cref="Visibility"/> converter.
    /// When <see cref="IsEqual"/> is set, the value is compared with <see cref="IsEqual"/> otherwise,
    /// it checks the bool value, non-null for objects and non-null and non-whitespace for strings.
    /// If the check is positive, the <see cref="TrueValue"/> (<see cref="Visibility.Visible"/> by default) is returned,
    /// otherwise <see cref="FalseValue"/> (<see cref="Visibility.Collapsed"/> by default) is returned.
    /// The result can be also inverted using the <see cref="Inverted"/> property.
    /// </summary>
    public sealed class VisibilityConverter : MarkupExtension,IValueConverter
    {
        /// <summary>
        /// Optional value to compare with the value being converted for equivalency. This is the top priority check.
        /// </summary>
        public object? IsEqual { get; set; }

        /// <summary>
        /// Value to return when the check is positive
        /// </summary>
        public Visibility TrueValue { get; set; }
        /// <summary>
        /// Value to return when the check is negative
        /// </summary>
        public Visibility FalseValue { get; set; }
        /// <summary>
        /// Flag whether to invert the check result
        /// </summary>
        public bool Inverted { get; set; }

        public VisibilityConverter()
        {
            TrueValue = Visibility.Visible;
            FalseValue = Visibility.Collapsed;
            IsEqual = null;
        }

        /// <summary>
        /// Converts a value to a <see cref="Visibility" /> enumeration value.
        /// When <see cref="IsEqual"/> is set, the <paramref name="value"/> is compared with <see cref="IsEqual"/> otherwise,
        /// it checks the bool value, non-null for objects and non-null and non-whitespace for strings.
        /// If the check is positive, the <see cref="TrueValue"/> (<see cref="Visibility.Visible"/> by default) is returned,
        /// otherwise <see cref="FalseValue"/> (<see cref="Visibility.Collapsed"/> by default) is returned.
        /// The result can be also inverted using the <see cref="Inverted"/> property.
        /// </summary>
        /// <param name="value">The value to check, it can be boolean, string or object</param>
        /// <param name="targetType">This parameter is not used.</param>
        /// <param name="parameter">This parameter is not used.</param>
        /// <param name="culture">This parameter is not used.</param>
        /// <returns>
        /// <see cref="TrueValue"/> (<see cref="Visibility.Visible"/> by default) when the check is positive,
        /// otherwise <see cref="FalseValue"/> (<see cref="Visibility.Collapsed"/> by default) is returned.
        /// The result can be also inverted using the <see cref="Inverted"/> property.
        /// </returns>
        public object Convert(object? value, Type targetType, object parameter, CultureInfo culture)
        {
            bool resultValue;
            if (IsEqual != null)
            {
                resultValue = value == IsEqual;
            }
            else
            {
                resultValue = value switch
                {
                    bool b => b,
                    null => false,
                    string s => !string.IsNullOrWhiteSpace(s),
                    _ => false
                };
            }

            if (Inverted)
            {
                return resultValue ? FalseValue : TrueValue;
            }

            return resultValue ? TrueValue : FalseValue;
        }

        /// <summary>
        /// Back conversion is not supported, <see cref="NotImplementedException"/> is thrown when trying to do the back conversion
        /// </summary>
        /// <param name="value">This parameter is not used.</param>
        /// <param name="targetType">This parameter is not used.</param>
        /// <param name="parameter">This parameter is not used.</param>
        /// <param name="culture">This parameter is not used.</param>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
