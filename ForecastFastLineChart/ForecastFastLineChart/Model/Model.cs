using System.Windows.Media;

namespace ForecastFastLineChart
{
    public class Model
    {
        public double Year { get; set; }
        public double TotalPopulation { get; set; }
        public double Under25 { get; set; }
        public double Between25to64 { get; set; }
        public double Under15 { get; set; }
        public double Under4 { get; set; }
        public double Above65 { get; set; }

        public Brush Brush1 = new SolidColorBrush(Colors.BlueViolet);
        public Brush Brush2 = new SolidColorBrush(Colors.Green);
        public Brush Brush3 = new SolidColorBrush(Colors.Brown);
        public Brush Brush4 = new SolidColorBrush(Colors.DeepPink);
        public Brush Brush5 = new SolidColorBrush(Colors.DarkBlue);
        public Brush Brush6 = new SolidColorBrush(Colors.Orange);

        public Model(double year, double totalPopulation, double under25, double between25to64, double under15, double under4, double above65)
        {
            Year = year;
            TotalPopulation = totalPopulation;
            Under25 = under25;
            Between25to64 = between25to64;
            Under15 = under15;
            Under4 = under4;
            Above65 = above65;
        }
    }
}
