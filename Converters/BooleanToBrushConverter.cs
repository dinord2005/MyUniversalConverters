using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace Converters
{
    /// <summary>
    /// Converts a <see cref="bool" /> value to a <see cref="Brush" /> value
    /// </summary>
    public class BooleanToBrushConverter : IValueConverter
    {
        /// <summary>
        /// Brush to use when value is true
        /// </summary>
        public Brush TrueBrush
        {
            get;
            set;
        }

        /// <summary>
        /// Brush to use when the value is false
        /// </summary>
        public Brush FalseBrush
        {
            get;
            set;
        }

        #region IValueConverter Members

        /// <summary>
        /// Convert a Boolean to negation Boolean
        /// </summary>
        /// <param name="value">Value to convert</param>
        /// <param name="targetType">Target type requiered</param>
        /// <param name="parameter">Converter parameter</param>
        /// <param name="language">Language information</param>
        /// <returns>An inverted boolean</returns>
        public object Convert(object value,
                              Type targetType,
                              object parameter,
                              String language)
        {
            var val = (Boolean)value;

            return (val)
                ? TrueBrush
                : FalseBrush;
        }

        /// <summary>
        /// Convert a Boolean to negation Boolean
        /// </summary>
        /// <param name="value">Value to convert</param>
        /// <param name="targetType">Target type requiered</param>
        /// <param name="parameter">Converter parameter</param>
        /// <param name="language">Language information</param>
        /// <returns>An inverted boolean</returns>
        public object ConvertBack(object value,
                                  Type targetType,
                                  object parameter,
                                  String language)
        {
            var brush = value as Brush;

            if (brush == TrueBrush)
                return true;

            return false;
        }

        #endregion
    }
}
