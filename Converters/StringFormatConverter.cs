using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace Converters
{
    /// <summary>
    /// Convert a <see cref="bool" /> value a <see cref="Visibility" /> value
    /// </summary>
    public class StringFormatConverter : IValueConverter
    {
        /// <summary>
        /// Converts a <see cref="Boolean" /> value a <see cref="Visibility" /> value
        /// </summary>
        /// <param name="value">The <see cref="Boolean" /> value to convert</param>
        /// <param name="targetType">The target binding value</param>
        /// <param name="parameter">The binding parameter</param>
        /// <param name="language">The language</param>
        /// <returns>A <see cref="Visibility" /> value</returns>
        public object Convert(object value,
                              Type targetType,
                              object parameter,
                              String language)
        {
            if (!(parameter is String))
            {
                throw new FormatException(String.Format("Format incorrecte,le paramètre doit être de type string (type actuel : valeur {0} / paramètre {1}", value.GetType(), parameter.GetType()));
            }

            if (value is string)
            {
                return String.Format((string)parameter, (string)value);
            }
            else if (value is DateTime)
            {
                return ((DateTime)value).ToString((string)parameter, CultureInfo.InvariantCulture);
            }

            return string.Empty;
        }

        /// <summary>
        /// Converts a <see cref="Visibility" /> value a <see cref="Boolean" /> value
        /// </summary>
        /// <param name="value">The <see cref="Visibility" /> value to convert</param>
        /// <param name="targetType">The target binding value</param>
        /// <param name="parameter">The binding parameter</param>
        /// <param name="language">The language</param>
        /// <returns>A <see cref="Boolean" /> value</returns>
        public object ConvertBack(object value,
                                  Type targetType,
                                  object parameter,
                                  String language)
        {
            var visibility = (Visibility)value;

            return visibility == Visibility.Visible;
        }
    }
}
