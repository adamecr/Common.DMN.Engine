using System;
using System.Globalization;
using System.Windows.Data;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.zoomcontrol.converters
{
    /// <summary>
    /// Converter from <see cref="double"/> value to <see cref="Math.Log10"/> <see cref="double"/> value and vice versa.
    /// </summary>
    public sealed class DoubleToLog10Converter : IValueConverter
    {
        /// <inheritdoc />
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var val = (double)value;
            return Math.Log10(val);
        }

        /// <inheritdoc />
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var val = (double)value;
            return Math.Pow(10, val);
        }
    }
}
