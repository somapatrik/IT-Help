using System.Globalization;
using System.Windows.Data;

namespace IT_Help.Converters
{
	class ValuesToPercentConverter : IMultiValueConverter
	{
		public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
		{
			double result = 0;
			if (values[0] is long && values[1] is long)
			{
				long val = (long)values[0];
				long all = (long)values[1];
				decimal res = ((decimal)val / all) * 100;
				result = (double)Math.Round(res,1);
			}
			return result;
		}

		public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
