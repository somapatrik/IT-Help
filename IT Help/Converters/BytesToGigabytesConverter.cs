using System.Globalization;
using System.Windows.Data;

namespace IT_Help.Converters
{
	public class BytesToGigabytesConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is long)
			{
				long giga = (long)value / 1073741824;
				return Math.Round((decimal)giga, 1).ToString() + " GB";
			}
			return value;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
