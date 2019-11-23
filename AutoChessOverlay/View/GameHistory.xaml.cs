using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using AutoChessOverlay.Model;
using LiveCharts;
using LiveCharts.Wpf;

namespace AutoChessOverlay.View
{
    /// <summary>
    /// Interaktionslogik für GameHistory.xaml
    /// </summary>
    public partial class GameHistory : Window
    {
        public GameHistory()
        {
            InitializeComponent();
            CreateGraph();
        }

        private void CreateGraph()
        {
            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "1st",
                     Values = new ChartValues<int> {}
                },
                new LineSeries
                {
                    Title = "2nd",
                     Values = new ChartValues<int> {}
                },
                new LineSeries
                {
                    Title = "3rd",
                     Values = new ChartValues<int> {}
                },
                new LineSeries
                {
                    Title = "4th",
                     Values = new ChartValues<int> {}
                },
                new LineSeries
                {
                    Title = "5th",
                     Values = new ChartValues<int> {}
                },
                new LineSeries
                {
                    Title = "6th",
                     Values = new ChartValues<int> {}
                },
                new LineSeries
                {
                    Title = "7th",
                     Values = new ChartValues<int> {}

                },new LineSeries
                {
                    Title = "8th",
                     Values = new ChartValues<int> {}
                }

            };

     
            var data = File.ReadAllLines(FilePathes.gameResultPath).ToList();

            var dates = new List<string>();
            var first = 0;
            var second = 0;
            var third = 0;
            var fourth = 0;
            var fifth = 0;
            var sixt = 0;
            var seventh = 0;
            var eighth = 0;

            foreach (var line in data)
            {
                var splitedLine = line.Split(';');
                dates.Add(splitedLine[0]);
                if (splitedLine[1] == "1st")
                {
                    first++;
                }
                if (splitedLine[1] == "2nd")
                {
                    second++;
                }
                if (splitedLine[1] == "3rd")
                {
                    third++;
                }
                if (splitedLine[1] == "4th")
                {
                    fourth++;
                }
                if (splitedLine[1] == "5th")
                {
                    fifth++;
                }
                if (splitedLine[1] == "6th")
                {
                    sixt++;
                }
                if (splitedLine[1] == "7th")
                {
                    seventh++;
                }
                if (splitedLine[1] == "8th")
                {
                    eighth++;
                }

                var rank = splitedLine[1];
            };

            Labels = dates.GroupBy(test => test)
               .Select(grp => grp.First()).ToArray();

            SeriesCollection[0].Values.Add(first);
            SeriesCollection[1].Values.Add(second);
            SeriesCollection[2].Values.Add(third);
            SeriesCollection[3].Values.Add(fourth);
            SeriesCollection[4].Values.Add(fifth);
            SeriesCollection[5].Values.Add(sixt);
            SeriesCollection[6].Values.Add(seventh);
            SeriesCollection[7].Values.Add(eighth);

            // Labels = new[] { "1", "2", "3", "4", "5" };
            ////modifying any series values will also animate and update the chart



            DataContext = this;
        }

  
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<int, string> YFormatter { get; set; }
    }
}
