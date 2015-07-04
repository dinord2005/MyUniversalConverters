using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Converters
{
    /// <summary>
    /// Reverse <see cref="bool" />
    /// </summary>
    public class BoolToBoolNegationConverter : IValueConverter
    {
        /// <summary>
        /// Reverse a <see cref="Boolean" /> value
        /// </summary>
        /// <param name="value">The <see cref="Boolean" /> value to convert</param>
        /// <param name="targetType">The target binding value</param>
        /// <param name="parameter">The binding parameter</param>
        /// <param name="language">The language</param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return !(bool)value;
        }

        /// <summary>
        /// Reverse a <see cref="Boolean" /> value
        /// </summary>
        /// <param name="value">The <see cref="Boolean" /> value to convert</param>
        /// <param name="targetType">The target binding value</param>
        /// <param name="parameter">The binding parameter</param>
        /// <param name="language">The language</param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return !(bool)value;
        }
    }
}
