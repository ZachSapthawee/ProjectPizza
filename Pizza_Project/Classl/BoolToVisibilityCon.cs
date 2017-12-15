using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pizza_Project
{
    public class BoolToVisibilityCon : IMultiValueConverter
    {
        public object Convert(object[] Values, Type TargetType, object Parameter,CultureInfo culture)
        {
            bool hasText = !(bool)Values[0];
            bool hasFocus = (bool)Values[1];
            if (hasText || hasFocus)
                return Visibility.Collapsed;
            return Visibility.Visible;
        }

    }

    public interface IMultiValueConverter
    {
    }
}
