using Syncfusion.UI.Xaml.Charts;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ForecastFastLineChartWithPlotBand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var model = viewModel.HistoricalPopulationData[0];
            series.Interior = series6.Interior = model.Brush1;
            series7.Interior = series1.Interior = model.Brush2;
            series8.Interior = series2.Interior = model.Brush3;
            series9.Interior = series3.Interior = model.Brush4;
            series10.Interior = series4.Interior = model.Brush5;
            series11.Interior = series5.Interior = model.Brush6;
            series6.StrokeDashArray = new System.Windows.Media.DoubleCollection { 10, 3, 2, 3 };
            series7.StrokeDashArray = series8.StrokeDashArray = series9.StrokeDashArray = series10.StrokeDashArray = series11.StrokeDashArray = series6.StrokeDashArray;
        }

        private void NumericalAxis_LabelCreated_1(object sender, LabelCreatedEventArgs e)
        {
            if (e.AxisLabel is ChartAxisLabel label && label.LabelContent is string content && content != "0")
            {
                var value = double.Parse(content) / 1000000000;
                label.LabelContent = value.ToString() + "B";
            }
        }
    }

    public class TooltipValueConverter : IValueConverter
    {
        private const double Billion = 1000000000;
        private const double Million = 1000000;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Model model && parameter is string para && !string.IsNullOrEmpty(para))
            {
                switch (para)
                {
                    case "1":
                        return FormatPopulation(model.TotalPopulation, Billion, "B", 2);
                    case "2":
                        return FormatPopulation(model.Under25, Billion, "B", 2);
                    case "3":
                        return FormatPopulation(model.Between25to64, Billion, "B", 2);
                    case "4":
                        return FormatPopulation(model.Under15, Billion, "B", 2);
                    case "5":
                        return FormatPopulation(model.Under4, Million, "M", 3);
                    case "6":
                        return FormatPopulation(model.Above65, Million, "M", 2);
                    case "0":
                        return $"Population in {model.Year}";
                    case "7":
                        return model.Brush1;
                    case "8":
                        return model.Brush2;
                    case "9":
                        return model.Brush3;
                    case "10":
                        return model.Brush4;
                    case "11":
                        return model.Brush5;
                    case "12":
                        return model.Brush6;
                    default:
                        return value;
                }
            }

            return value;
        }

        private string FormatPopulation(double population, double divisor, string unit, int decimalPlaces)
        {
            return Math.Round(population / divisor, decimalPlaces) + unit;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
