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
        }

        private void btRankTitle_Click(object sender, RoutedEventArgs e)
        {
            var rank = new Ranks();
            rank.rank1 = Int32.Parse(lbRank1.Content.ToString());
            rank.rank2 = Int32.Parse(lbRank2.Content.ToString());
            rank.rank3 = Int32.Parse(lbRank3.Content.ToString());
            rank.rank4 = Int32.Parse(lbRank4.Content.ToString());
            rank.rank5 = Int32.Parse(lbRank5.Content.ToString());
            rank.rank6 = Int32.Parse(lbRank6.Content.ToString());
            rank.rank7 = Int32.Parse(lbRank7.Content.ToString());
            rank.rank8 = Int32.Parse(lbRank8.Content.ToString());

            var data = new DataInput(this);
            data.SetTextBoxValue(rank);
            data.Show();
          
        }
        public void SetTextBoxValue(Ranks rank)
        {
            lbRank1.Content = rank.rank1.ToString();
            lbRank2.Content = rank.rank2.ToString(); 
            lbRank3.Content = rank.rank3.ToString();
            lbRank4.Content = rank.rank4.ToString();
            lbRank5.Content = rank.rank5.ToString();
            lbRank6.Content = rank.rank6.ToString();
            lbRank7.Content = rank.rank7.ToString();
            lbRank8.Content = rank.rank8.ToString();

            int[] numbers = new int[] { rank.rank1, rank.rank2, rank.rank3, rank.rank4, rank.rank5, rank.rank6, rank.rank7, rank.rank8};
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

            pbRank1.Value = rank.rank1;
            pbRank2.Value = rank.rank2;
            pbRank3.Value = rank.rank3;
            pbRank4.Value = rank.rank4;
            pbRank5.Value = rank.rank5;
            pbRank6.Value = rank.rank6;
            pbRank7.Value = rank.rank7;
            pbRank8.Value = rank.rank8;


        }


    }
}
