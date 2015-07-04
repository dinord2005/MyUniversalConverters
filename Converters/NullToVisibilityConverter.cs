using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace Converters
{
    /// <summary>
    /// Convert a null value a <see cref="Visibility" /> value
    /// </summary>
    public class NullToVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Converts a null value a <see cref="Visibility" /> value
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

            Boolean collapse = false;
            //check if value is null
            collapse = (value == null);

            //if value is string, check if is empty
            collapse = (value is string && string.IsNullOrEmpty(value as string));

            return value == null
                ? Visibility.Collapsed
                : Visibility.Visible;
        }

        /// <summary>
        /// Not implemented
        /// </summary>
        /// <param name="value">The <see cref="Visibility" /> value to convert</param>
        /// <param name="targetType">The target binding value</param>
        /// <param name="parameter">The binding parameter</param>
        /// <param name="language">The language</param>
        /// <returns>Not implemented</returns>
        public object ConvertBack(object value,
                                  Type targetType,
                                  object parameter,
                                  String language)
        {
            throw new NotImplementedException();
        }
    }
}
