using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Converters
{
    /// <summary>
    /// Converts a <see cref="bool" /> value to an opacity value
    /// </summary>
    public class BoolNegationToOpacityConverter : IValueConverter
    {
        /// <summary>
        /// Converts a <see cref="Boolean" /> value a <see cref="Double" /> opacity value
        /// </summary>
        /// <param name="value">The <see cref="Boolean" /> value to convert</param>
        /// <param name="targetType">The target binding value</param>
        /// <param name="parameter">The binding parameter</param>
        /// <param name="language">The language</param>
        /// <returns>A <see cref="Double" /> opacity value</returns>
        public object Convert(object value,
                              Type targetType,
                              object parameter,
                              String language)
        {
            Boolean val = false;

            if (value is Boolean)
            {
                val = (Boolean)value;
            }

            return val
                ? 0.0
                : 1.0;
        }

        /// <summary>
        /// Converts a <see cref="Double" /> opacity value a <see cref="Boolean" /> value
        /// </summary>
        /// <param name="value">The <see cref="Double" /> opacity value to convert</param>
        /// <param name="targetType">The target binding value</param>
        /// <param name="parameter">The binding parameter</param>
        /// <param name="language">The language</param>
        /// <returns>A <see cref="Boolean" /> value</returns>
        public object ConvertBack(object value,
                                  Type targetType,
                                  object parameter,
                                  String language)
        {
            Double opacity;

            if ((value != null) && (Double.TryParse(value.ToString(),
                                                    out opacity)))
            {
                return opacity != 0;
            }

            return false;
        }
    }
}
