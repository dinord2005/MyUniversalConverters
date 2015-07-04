using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Converters
{
    /// <summary>
    /// Converts a string to its upper
    /// </summary>
    public class StringToUpper : IValueConverter
    {
        /// <summary>
        /// Converts a string to its upper case
        /// </summary>
        /// <param name="value">The string to convert</param>
        /// <param name="targetType">The target type</param>
        /// <param name="parameter">The parameter</param>
        /// <param name="language">The language</param>
        /// <returns>The uppercase string</returns>
        public object Convert(object value,
                              Type targetType,
                              object parameter,
                              String language)
        {
            if (value != null)
            {
                string str = value.ToString();
                return str.ToUpper();
            }
            return null;
        }

        /// <summary>
        /// Converts a string to its lower case
        /// </summary>
        /// <param name="value">The string to convert</param>
        /// <param name="targetType">The target type</param>
        /// <param name="parameter">The parameter</param>
        /// <param name="language">The language</param>
        /// <returns>The lowercase string</returns>
        public object ConvertBack(object value,
                                  Type targetType,
                                  object parameter,
                                  String language)
        {
            var str = value as string;

            if (str != null)
            {
                return str.ToLower();
            }

            return null;
        }
    }
}
