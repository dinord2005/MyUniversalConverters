using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Converters
{
    /// <summary>
    /// Converts a percentage value to an 360 angle value
    /// </summary>
    public class PercentageValueToAngleConverter : IValueConverter
    {
        /// <summary>
        /// Convert a percentage value to an angle value
        /// </summary>
        /// <param name="value">Value to convert</param>
        /// <param name="targetType">Target type requiered</param>
        /// <param name="parameter">Converter parameter</param>
        /// <param name="language">Language information</param>
        /// <returns>A corresponding angle value</returns>
        public Object Convert(Object value,
                              Type targetType,
                              Object parameter,
                              String language)
        {
            Int32 percentage = (Int32)value;
            return percentage * 3.6;
        }

        /// <summary>
        /// Converts an 360 angle value to a percentage value
        /// </summary>
        /// <param name="value">Value to convert</param>
        /// <param name="targetType">Target type requiered</param>
        /// <param name="parameter">Converter parameter</param>
        /// <param name="language">Language information</param>
        /// <returns>A percentage value</returns>
        public Object ConvertBack(Object value,
                                  Type targetType,
                                  Object parameter,
                                  String language)
        {
            Int32 percentage = (Int32)value;
            return percentage / 3.6;
        }
    }
}
