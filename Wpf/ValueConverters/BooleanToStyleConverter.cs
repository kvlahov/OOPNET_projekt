using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Wpf.ValueConverters
{
    public class BooleanToStyleConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Count() != 2)
            {
                return null;
            }

            var element = values[0] as FrameworkElement;
            var booleanValue = values[1] as bool?;

            if (!booleanValue.HasValue || element == null)
            {
                return null;
            }

            return booleanValue.Value ? element.FindResource("HomeTeamStyle") : element.FindResource("AwayTeamStyle");
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return new object[] { };
        }
    }
}
