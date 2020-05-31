using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Wpf.Resources;

namespace Wpf.ValueConverters
{
    public sealed class EnumToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            { return null; }

            return StringResources.ResourceManager.GetString(value.ToString().ToLower());
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string str = (string)value;

            foreach (object enumValue in Enum.GetValues(targetType))
            {
                if (str == StringResources.ResourceManager.GetString(enumValue.ToString().ToLower()))
                { return enumValue; }
            }

            throw new ArgumentException(null, "value");
        }
    }
}
