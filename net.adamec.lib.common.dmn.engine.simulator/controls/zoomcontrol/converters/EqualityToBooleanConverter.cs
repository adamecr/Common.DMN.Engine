using System;
using System.CodeDom;
using System.Globalization;
using System.Windows.Data;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.zoomcontrol.converters
{
    /// <summary>
    /// Converter that checks equality between value and parameter.
    /// </summary>
    public sealed class EqualityToBooleanConverter : IValueConverter
    {
        /// <inheritdoc />
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Equals(value, parameter);
        }

        /// <inheritdoc />
        public object? ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is true)
                return parameter;

            if (targetType.IsValueType)
                return Activator.CreateInstance(targetType);

            return null;

            //throw new NotSupportedException($"{nameof(EqualityToBooleanConverter)}: Can't bind back.");
        }
    }
}
