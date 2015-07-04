using System;
using System.Collections;
using System.Collections.Generic;
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
    public class EmptyListToVisibilityConverter : IValueConverter
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




            Boolean val = true;

            if (value is IList)
            {
                val = !(((IList)value).Count == 0);
            }

            return val
                ? Visibility.Visible
                : Visibility.Collapsed;
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
