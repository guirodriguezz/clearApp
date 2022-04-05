using clearApp.Extensions;
using System;
using System.Globalization;
using Xamarin.Forms;

namespace ClearApp.Converters
{
    public class MoedaConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string str = System.Convert.ToString(value);
            if (string.IsNullOrWhiteSpace(str))
                str = "0";
            str = str.OnlyNumbers();
            decimal d = !string.IsNullOrEmpty(str) ? System.Convert.ToDecimal(str) / 100 : 0.0m;
            return string.Format(new CultureInfo("pt-BR"), "{0:C}", d);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string str = System.Convert.ToString(value);
            if (string.IsNullOrWhiteSpace(str))
                str = "0";
            str = str.OnlyNumbers();
            decimal d = !string.IsNullOrEmpty(str) ? System.Convert.ToDecimal(str) / 100 : 0.0m;
            return string.Format("{0:n2}", d);
        }
    }
}
