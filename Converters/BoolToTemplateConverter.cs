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
    ///     Convert a Boolean value to a corresponding <see cref="DataTemplate" />
    /// </summary>
    public class BoolToTemplateConverter : IValueConverter
    {
        /// <summary>
        ///     <see cref="DataTemplate" /> to use when value is true
        /// </summary>
        public DataTemplate TrueTemplate
        {
            get;
            set;
        }

        /// <summary>
        ///     <see cref="DataTemplate" /> to use when value is false
        /// </summary>
        public DataTemplate FalseTemplate
        {
            get;
            set;
        }

        /// <summary>
        ///     Convert a Boolean to a <see cref="DataTemplate" /> value
        /// </summary>
        /// <param name="value">Value to convert</param>
        /// <param name="targetType">Target type requiered</param>
        /// <param name="parameter">Converter parameter</param>
        /// <param name="language">language information</param>
        /// <returns>A <see cref="DataTemplate" /> instance</returns>
        public object Convert(object value,
                              Type targetType,
                              object parameter,
                              String language)
        {
            var val = (Boolean)value;

            return (val)
                ? TrueTemplate
                : FalseTemplate;
        }

        /// <summary>
        ///     Not implemented
        /// </summary>
        /// <param name="value">Value to convert</param>
        /// <param name="targetType">Target type requiered</param>
        /// <param name="parameter">Converter parameter</param>
        /// <param name="language">language information</param>
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
