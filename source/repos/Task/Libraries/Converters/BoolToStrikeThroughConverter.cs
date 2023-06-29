using System.Globalization;

namespace Task.Libraries.Converters
{
    class BoolToStrikeThroughConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isCompleted = (bool)value;

            return isCompleted ? TextDecorations.Strikethrough : TextDecorations.None;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
