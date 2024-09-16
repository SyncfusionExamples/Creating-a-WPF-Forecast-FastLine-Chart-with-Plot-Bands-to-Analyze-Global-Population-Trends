﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Windows.Media;

namespace ForecastFastLineChartWithPlotBand
{
    public class ViewModel
    {
        public ObservableCollection<Model> HistoricalPopulationData { get; set; }
        public ObservableCollection<Model> ForecastPopulationData { get; set; }

        private Geometry path = Geometry.Parse("M5.1533096,11.681885C6.4703086,11.681885 7.5392945,12.749891 7.5392945,14.067898 7.5392945,15.385906 6.4703086,16.454913 5.1533096,16.454913 3.8353343,16.454913 2.7653413,15.385906 2.7653411,14.067898 2.7653413,12.749891 3.8353343,11.681885 5.1533096,11.681885z M14.540176,6.5158539L14.673171,6.5158539C15.313177,7.2518583 16.253166,7.7028609 17.288156,7.7028609 17.553137,7.7028609 17.819155,7.6718608 18.07913,7.6108614 18.356134,7.5468598 18.619131,7.45186 18.866138,7.3258601 19.254133,7.1288582 19.598121,6.8618565 19.888126,6.5358544 19.894108,6.5288544 19.901127,6.5218545 19.906101,6.5158539L20.042116,6.5158539C20.1781,6.5158539 20.308103,6.5408555 20.429106,6.5868555 20.790092,6.6458555 21.325088,6.7698551 21.939094,7.039857 23.003074,7.5008603 24.307043,8.4398652 25.165033,10.154875 25.579029,10.975881 25.886032,11.961886 26.042036,13.135893 27.055023,13.510896 27.776998,14.481902 27.776998,15.625908L27.776998,31.104997C27.776998,31.479999 27.472009,31.786004 27.096008,31.786004 26.719028,31.786004 26.414039,31.479999 26.414039,31.104997L26.414039,15.625908C26.414039,15.321905 26.308023,15.043903 26.133037,14.821902 26.036024,15.313906 25.609028,15.691908 25.088039,15.703907L25.061031,15.703907C24.575044,15.703907 24.161049,15.384907 24.021066,14.940905 23.896068,15.139905 23.823072,15.373905 23.823072,15.625908 23.823072,16.002912 23.517076,16.308911 23.141073,16.308911 22.764065,16.308911 22.459076,16.002912 22.459076,15.625908 22.459076,14.612902 23.026085,13.732897 23.859051,13.283895 23.734052,12.432888 23.515062,11.754885 23.25408,11.211883 22.863062,10.408878 22.380068,9.8888751 21.892097,9.5218716 21.640087,9.3308707 21.385086,9.1858693 21.142109,9.0728703L21.142109,17.354919C21.142109,17.360919 21.141102,17.366918 21.141102,17.374919 21.481092,19.142928 22.016088,23.062949 22.017095,30.227992 22.017095,31.206998 21.2231,32.000003 20.245117,32.000003 19.266126,32.000003 18.47213,31.206998 18.47213,30.227992 18.473137,23.813956 18.028137,20.166932 17.733158,18.454925L16.847153,18.454925C16.780166,18.845925 16.704149,19.335931 16.629167,19.939935 16.373159,21.975946 16.108179,25.278966 16.108179,30.227992 16.108179,31.206998 15.314183,32.000003 14.3362,32.000003 13.355195,32.000003 12.563213,31.206998 12.563213,30.227992 12.56422,23.062949 13.100194,19.141929 13.440216,17.373918 13.439209,17.366918 13.439209,17.360919 13.439209,17.354919L13.439209,10.652879C12.664225,11.936887 11.807212,13.721897 11.331236,15.872909 11.254241,16.22391 11.013246,16.497912 10.709235,16.632913 10.230237,17.476918 9.5422581,18.011922 8.902252,18.298923 8.3862675,18.533923 7.9062632,18.634927 7.5392945,18.675927L7.5392945,22.113946 7.5392945,24.56696 7.5392945,30.840995C7.5392945,31.443999 7.050287,31.932004 6.4483054,31.932004 5.8453167,31.932004 5.3563097,31.443999 5.3563097,30.840995L5.3563097,25.249963 4.9473188,25.249963 4.9473188,30.840995C4.9473188,31.443999 4.4593189,31.932004 3.8573368,31.932004 3.2543483,31.932004 2.7663484,31.443999 2.7663482,30.840995L2.7663482,24.56696 2.7663482,22.113946 2.7663482,19.326928C2.327359,19.974935 1.778355,21.321942 1.6353518,23.958955 1.610358,24.393958 1.2493705,24.730962 0.81837664,24.730962 0.80436919,24.730962 0.78837822,24.730962 0.77238713,24.729959 0.32238106,24.70596 -0.024629646,24.319957 0.0013709203,23.868955 0.16439369,20.915938 0.80037145,19.251929 1.5023576,18.278924 2.2013536,17.303916 2.983356,17.096917 3.156327,17.079917 3.22435,17.069917 3.2943259,17.069917 3.3593271,17.076917 3.3883493,17.072917 3.4183476,17.067916 3.4473389,17.067916L6.8572967,17.067916C6.8632782,17.067916 6.8692902,17.069917 6.8762782,17.069917 6.9103048,17.067916 6.9462846,17.066917 6.9812878,17.069917L6.9833019,17.069917 6.9862926,17.069917C6.9952953,17.069917 7.0152839,17.070916 7.0422919,17.070916 7.2182844,17.071916 7.7292941,17.040917 8.2192781,16.812915 8.5812729,16.639913 8.9342649,16.391913 9.2182577,15.93891 9.1682699,15.768909 9.1612509,15.583907 9.2022665,15.399906 10.37025,10.180876 13.405212,7.0018569 13.476195,6.9188562 13.662198,6.7248564 13.902184,6.6138559 14.150198,6.5878549 14.271198,6.5418549 14.402178,6.5158539 14.540176,6.5158539z M17.366157,0.00081665062C18.79314,0.033816606 20.071108,1.0238221 20.410124,2.4788314 20.674097,3.6078377 20.304107,4.7368441 19.531107,5.4948478 19.446117,5.576849 19.355114,5.65585 19.262129,5.7298499 19.254133,5.7358504 19.247114,5.7408496 19.239118,5.7468501 18.888141,6.0158511 18.47512,6.2168523 18.016144,6.3248525 16.911146,6.5818544 15.807158,6.2318535 15.051186,5.4948478 14.629195,5.0818453 14.314197,4.5488434 14.170187,3.9308398 13.769191,2.20783 14.841198,0.48481945 16.56316,0.083817322 16.833145,0.021816453 17.102154,-0.0051831775 17.366157,0.00081665062z");
        private Geometry path1 = Geometry.Parse("M13.77499,9.1999931C13.999996,9.1999931 14.225003,9.2999954 14.425015,9.5 14.824979,9.8000031 14.824979,10.399994 14.425015,10.800003L9.7249992,15.5 9.7249992,31C9.7249992,31.599991 9.2249982,32 8.7249982,32 8.1249607,32 7.7249973,31.5 7.7249973,31L7.7249973,22.599991 6.925009,22.599991 6.925009,31C6.925009,31.599991 6.4250085,32 5.9250081,32 5.324971,32 4.9250071,31.5 4.9250071,31L4.9250071,15.5 0.22499117,10.800003C-0.074997058,10.399994 -0.074997058,9.8999939 0.22499117,9.5 0.52497906,9.3000031 0.72499138,9.3000031 0.92500389,9.3000031 1.1249551,9.3000031 1.4250042,9.3999939 1.52498,9.5999908L6.0249836,14 8.6249616,14 13.124965,9.5C13.324978,9.2999954,13.549984,9.1999931,13.77499,9.1999931z");
        public Geometry PathData
        {
            set { path = value; }
            get { return path; }
        }

        public Geometry PathData1
        {
            set { path1 = value; }
            get { return path1; }
        }

        public ViewModel()
        {
            HistoricalPopulationData = new ObservableCollection<Model>();
            ForecastPopulationData = new ObservableCollection<Model>();
            ReadCSV("ForecastFastLineChartWithPlotBand.data.csv");
        }

        private void ReadCSV(string fileName)
        {
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            Stream inputStream = executingAssembly.GetManifestResourceStream(fileName);
            if (inputStream != null)
            {
                string line;
                List<string> lines = new List<string>();
                StreamReader reader = new StreamReader(inputStream);
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }

                lines.RemoveAt(0);

                for (int i = 0; i < lines.Count; i++)
                {
                    string input = lines[i];
                    string[] data = input.Split(',');
                    var year = Convert.ToDouble(data[2]);

                    if (year <= 2023)
                    {
                        var model = new Model(year, Convert.ToDouble(data[3]), Convert.ToDouble(data[10]), Convert.ToDouble(data[7]), Convert.ToDouble(data[11]), Convert.ToDouble(data[13]), Convert.ToDouble(data[5]));
                        HistoricalPopulationData.Add(model);
                    }
                    else
                    {
                        var model = new Model(year, Convert.ToDouble(data[4]), Convert.ToDouble(data[9]), Convert.ToDouble(data[8]), Convert.ToDouble(data[12]), Convert.ToDouble(data[14]), Convert.ToDouble(data[6]));
                        ForecastPopulationData.Add(model);
                    }
                }
            }
        }
    }
}
