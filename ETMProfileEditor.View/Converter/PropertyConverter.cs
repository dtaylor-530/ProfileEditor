﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace ETMProfileEditor.View
{
    public class PropertyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.GetType().GetProperty((string)parameter).GetValue(value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}