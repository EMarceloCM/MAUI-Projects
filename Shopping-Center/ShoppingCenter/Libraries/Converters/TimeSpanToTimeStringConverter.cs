using ShoppingCenter.Models;
using System.Globalization;

namespace ShoppingCenter.Libraries.Converters
{
    public class TimeSpanToTimeStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return "";

            Ticket ticket = (Ticket)value;

            var dif = new TimeSpan(ticket.DateOut.Ticks - ticket.DateIn.Ticks);
            return string.Format("{0:D2}h {1:D2}m", dif.Hours, dif.Minutes);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
