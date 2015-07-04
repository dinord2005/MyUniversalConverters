using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Converters
{
    /// <summary>
    /// Convert a boolean value to its negation value
    /// </summary>
    public class BoolToNegationBoolConverter : IValueConverter
    {
        #region IValueConverter Members

        /// <summary>
        /// Converts a boolean value to its negation value
        /// </summary>
        /// <param name="value">The value to inverse</param>
        /// <param name="targetType">The target type value</param>
        /// <param name="parameter">The parameter value</param>
        /// <param name="language">The required language</param>
        /// <returns>An inverted boolean value</returns>
        public object Convert(object value,
                              Type targetType,
                              object parameter,
                              String language)
        {
            var val = (bool)value;

            return !val;

        }

        /// <summary>
        /// Converts back a negation boolean value to its inverted value
        /// </summary>
        /// <param name="value">The value to convert back</param>
        /// <param name="targetType">The target type value</param>
        /// <param name="parameter">The parameter value</param>
        /// <param name="language">The required language</param>
        /// <returns>An converted back boolean value</returns>
        public object ConvertBack(object value,
                                  Type targetType,
                                  object parameter,
                                  String language)
        {
            var val = (bool)value;

            return !val;
        }

        #endregion
    }
}
