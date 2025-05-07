using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Tecoc.DragonBZ.Converters
{
    public class KiColorConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            var ki = System.Convert.ToInt32(value.ToString().Replace(".", ""));
            if (ki > 50000000)
                return Colors.Red;

            if (ki > 40000000)
                return Colors.Orange;

            if (ki == 0)
                return Colors.Green;

          `

        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}