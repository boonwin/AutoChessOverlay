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

            if (File.Exists(FilePathes.gameResultPath)){ 
            var data = File.ReadAllLines(FilePathes.gameResultPath).ToList();
            var rankHistoryList = new List<RankHistory>();
            foreach (var line in data)
            {
                rankHistoryList.Add(RankHistory.parse(line));
            };


            var result = rankHistoryList.GroupBy(x => new { x.Dates, x.Rank })
                   .Select(g => new { g.Key.Dates, g.Key.Rank, Amount = g.Count() })

                   .ToList();

            var dates = new List<string>();
            var allRanks = new List<string>
            {
                "1st"
                ,"2nd"
                ,"3rd"
                ,"4th"
                ,"5th"
                ,"6th"
                ,"7th"
                ,"8th"
            };

            foreach (var entry in result)
            {
                dates.Add(entry.Dates);
            }
            var singleDates = dates.GroupBy(x => x).Select(grp => grp.First()).ToArray();
            Labels = singleDates;

            foreach (var ran in allRanks)
            {
                foreach (var day in singleDates)
                {
                    if (ran == "1st")
                    {
                        if (result.Exists(x => x.Dates == day && x.Rank == ran) == true)
                        {                 
                        SeriesCollection[0].Values.Add(result.Where(w => w.Dates == day && w.Rank == ran).Select(x => x.Amount).First());
                        }
                        else SeriesCollection[0].Values.Add(0);
                    }

                    if (ran == "2nd")
                    {
                        if (result.Exists(x => x.Dates == day && x.Rank == ran) == true)
                        {
                            SeriesCollection[1].Values.Add(result.Where(w => w.Dates == day && w.Rank == ran).Select(x => x.Amount).First());
                        }
                        else SeriesCollection[1].Values.Add(0);
                    }
                    if (ran == "3rd")
                    {
                        if (result.Exists(x => x.Dates == day && x.Rank == ran) == true)
                        {
                            SeriesCollection[2].Values.Add(result.Where(w => w.Dates == day && w.Rank == ran).Select(x => x.Amount).First());
                        }
                        else SeriesCollection[2].Values.Add(0);
                    }
                    if (ran == "4th")
                    {
                        if (result.Exists(x => x.Dates == day && x.Rank == ran) == true)
                        {
                            SeriesCollection[3].Values.Add(result.Where(w => w.Dates == day && w.Rank == ran).Select(x => x.Amount).First());
                        }
                        else SeriesCollection[3].Values.Add(0);
                    }
                    if (ran == "5th")
                    {
                        if (result.Exists(x => x.Dates == day && x.Rank == ran) == true)
                        {
                            SeriesCollection[4].Values.Add(result.Where(w => w.Dates == day && w.Rank == ran).Select(x => x.Amount).First());
                        }
                        else SeriesCollection[4].Values.Add(0);
                    }
                    if (ran == "6th")
                    {
                        if (result.Exists(x => x.Dates == day && x.Rank == ran) == true)
                        {
                            SeriesCollection[5].Values.Add(result.Where(w => w.Dates == day && w.Rank == ran).Select(x => x.Amount).First());
                        }
                        else SeriesCollection[5].Values.Add(0);
                    }
                    if (ran == "7th")
                    {
                        if (result.Exists(x => x.Dates == day && x.Rank == ran) == true)
                        {
                            SeriesCollection[6].Values.Add(result.Where(w => w.Dates == day && w.Rank == ran).Select(x => x.Amount).First());
                        }
                        else SeriesCollection[6].Values.Add(0);
                    }
                    if (ran == "8th")
                    {
                        if (result.Exists(x => x.Dates == day && x.Rank == ran) == true)
                        {
                            SeriesCollection[7].Values.Add(result.Where(w => w.Dates == day && w.Rank == ran).Select(x => x.Amount).First());
                        }
                        else SeriesCollection[7].Values.Add(0);
                    }

                }
            }




            }




            DataContext = this;
        }


        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<int, string> YFormatter { get; set; }
    }
}
