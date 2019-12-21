using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using AutoChessOverlay.Model;
using AutoChessOverlay.View;
using System.IO;


namespace AutoChessOverlay
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            var data = new DataInput(this);   
            data.Show();
            var filePath = new FilePathes();
            Directory.CreateDirectory(filePath.writePath);
            if (File.Exists(filePath.skinConfigPath))
            {
                var skins = new Skins(this);            
                var skin = File.ReadAllText(filePath.skinConfigPath);
                if(skin == "Base") {
                    skins.changeToBaseSkin();
                }
                if (skin == "Ice") {
                    skins.changeToIceSkin();
                }
                if (skin == "Hs") {
                    skins.changeToHsSkin();
                }
            }

        }

        private void btRankTitle_Click(object sender, RoutedEventArgs e)
        {
            var rank = new Ranks();
            if (rank != null) { 
            rank.rank1Amount = Int32.Parse(lbRank1.Content.ToString().Substring(0, lbRank1.Content.ToString().Length - 1));
            rank.rank2Amount = Int32.Parse(lbRank2.Content.ToString().Substring(0, lbRank2.Content.ToString().Length - 1));
            rank.rank3Amount = Int32.Parse(lbRank3.Content.ToString().Substring(0, lbRank3.Content.ToString().Length - 1));
            rank.rank4Amount = Int32.Parse(lbRank4.Content.ToString().Substring(0, lbRank4.Content.ToString().Length - 1));
            rank.rank5Amount = Int32.Parse(lbRank5.Content.ToString().Substring(0, lbRank5.Content.ToString().Length - 1));
            rank.rank6Amount = Int32.Parse(lbRank6.Content.ToString().Substring(0, lbRank6.Content.ToString().Length - 1));
            rank.rank7Amount = Int32.Parse(lbRank7.Content.ToString().Substring(0, lbRank7.Content.ToString().Length - 1));
            rank.rank8Amount = Int32.Parse(lbRank8.Content.ToString().Substring(0, lbRank8.Content.ToString().Length - 1));
            }
            var data = new DataInput(this);
            data.SetTextBoxValue(rank);
            data.Show();
          
        }
        public void SetTextBoxValue(Ranks rank)
        {
            lbRank1.Content = rank.rank1Amount.ToString() + "x";
            lbRank2.Content = rank.rank2Amount.ToString() + "x";
            lbRank3.Content = rank.rank3Amount.ToString() + "x";
            lbRank4.Content = rank.rank4Amount.ToString() + "x";
            lbRank5.Content = rank.rank5Amount.ToString() + "x";
            lbRank6.Content = rank.rank6Amount.ToString() + "x";
            lbRank7.Content = rank.rank7Amount.ToString() + "x";
            lbRank8.Content = rank.rank8Amount.ToString() + "x";

            int[] numbers = new int[] { rank.rank1Amount, rank.rank2Amount, rank.rank3Amount, rank.rank4Amount, rank.rank5Amount, rank.rank6Amount, rank.rank7Amount, rank.rank8Amount};
            int maximumNumber = numbers.Max();

            if (maximumNumber != 0) { 
            pbRank1.Maximum = maximumNumber;
            pbRank2.Maximum = maximumNumber;
            pbRank3.Maximum = maximumNumber;
            pbRank4.Maximum = maximumNumber;
            pbRank5.Maximum = maximumNumber;
            pbRank6.Maximum = maximumNumber;
            pbRank7.Maximum = maximumNumber;
            pbRank8.Maximum = maximumNumber;
            }

            pbRank1.Value = rank.rank1Amount;
            pbRank2.Value = rank.rank2Amount;
            pbRank3.Value = rank.rank3Amount;
            pbRank4.Value = rank.rank4Amount;
            pbRank5.Value = rank.rank5Amount;
            pbRank6.Value = rank.rank6Amount;
            pbRank7.Value = rank.rank7Amount;
            pbRank8.Value = rank.rank8Amount;

           tbAvgRankText.Content = "Average Rank: " + SetAvgRankValue(rank);
        }



        public string SetAvgRankValue(Ranks rank)
        {
            double totalAmount = rank.rank1Amount + rank.rank2Amount + rank.rank3Amount + rank.rank4Amount + rank.rank5Amount + rank.rank6Amount + rank.rank7Amount + rank.rank8Amount;
            double weightedAmount = (1 * rank.rank1Amount) + (2 * rank.rank2Amount) + (3 * rank.rank3Amount) + (4 * rank.rank4Amount) + (5 * rank.rank5Amount) + (6 * rank.rank6Amount) + (7 * rank.rank7Amount) + (8 * rank.rank8Amount);

            if (totalAmount != 0)
            {
                return Math.Round((weightedAmount / totalAmount), MidpointRounding.AwayFromZero).ToString();
            }
            else return "";
        }

    
    }
}
