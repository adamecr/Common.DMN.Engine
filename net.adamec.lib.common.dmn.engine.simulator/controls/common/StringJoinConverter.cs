using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.common
{
    /// <summary>
    /// Converter from <see cref="IEnumerable"/> value to joined string value
    /// </summary>
    internal sealed class StringJoinConverter : IValueConverter
    {
        /// <summary>
        /// Converts <see cref="IEnumerable"/> value to joined string value
        /// </summary>
        /// <param name="value">Value to convert - any enumerable</param>
        /// <param name="targetType">Should be string</param>
        /// <param name="parameter">Optional parameter - string to be used when the value is "empty"</param>
        /// <param name="culture">Culture info</param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var output = string.Empty;
            if (value is IEnumerable items)
            {
                output = string.Join(", ", items.Cast<object>().Select(i => i?.ToString() ?? "[null]"));
            }

            if (string.IsNullOrEmpty(output) && parameter is string param && !string.IsNullOrEmpty(param))
                output = param;

            return output;
        }

        /// <inheritdoc />
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
