﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace Converters
{
    /// <summary>
    ///     Convert a hexadecimal color string to a corresponding brush
    /// </summary>
    public class HexStringToSolidColorBrushConverter : IValueConverter
    {
        private static readonly Dictionary<String, Brush> Brushes = new Dictionary<String, Brush>();

        /// <summary>
        ///     Convert a hexadecimal color string to a corresponding brush
        /// </summary>
        /// <param name="value">Value to convert</param>
        /// <param name="targetType">Target type requiered</param>
        /// <param name="parameter">Converter parameter</param>
        /// <param name="language">language information</param>
        /// <returns>The corresponding brush</returns>
        public object Convert(object value,
                              Type targetType,
                              object parameter,
                              String language)
        {
            String color = ((String)value).Replace("#",
                                                    "");
            Brush colorBrush = null;

            if (color.Length == 6)
            {
                if (Brushes.ContainsKey(color))
                {
                    return Brushes[color];
                }

                colorBrush = new SolidColorBrush(Color.FromArgb(255,
                                                                byte.Parse(color.Substring(0,
                                                                                           2),
                                                                           NumberStyles.HexNumber),
                                                                byte.Parse(color.Substring(2,
                                                                                           2),
                                                                           NumberStyles.HexNumber),
                                                                byte.Parse(color.Substring(4,
                                                                                           2),
                                                                           NumberStyles.HexNumber)));

                Brushes[color] = colorBrush;
            }

            return colorBrush;
        }

        /// <summary>
        ///     Not implemented
        /// </summary>
        /// <param name="value">Value to convert</param>
        /// <param name="targetType">Target type requiered</param>
        /// <param name="parameter">Converter parameter</param>
        /// <param name="language">language information</param>
        /// <returns>An inverted boolean</returns>
        public object ConvertBack(object value,
                          Type targetType,
                          object parameter,
                          String language)
        {
            throw new NotImplementedException();
        }
    }
}
