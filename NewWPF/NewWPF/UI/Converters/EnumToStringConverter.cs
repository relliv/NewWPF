﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace NewWPF.UI.Converters
{
    [ValueConversion(typeof(bool), typeof(bool))]
    public class EnumToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return null;
                return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
