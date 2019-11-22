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
using System.Windows.Shapes;

namespace AutoChessOverlay
{
    /// <summary>
    /// Interaktionslogik für DataInput.xaml
    /// </summary>
    public partial class DataInput 
    {
        private readonly MainWindow _mainWindow;

        public DataInput(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            InitializeComponent();
            cbGame.Items.Add("Battlegrounds");
            cbGame.Items.Add("Underlords");
        }

   
        List<Ranks> ranks = new List<Ranks>();

    
        private void btnEnterData_Click(object sender, RoutedEventArgs e)
        {
            CreateRanksAndSetMainWindow();
        }


        public void SetTextBoxValue(Ranks rank)
        {
            tbRank1Amount.Text = rank.rank1.ToString();
            tbRank2Amount.Text = rank.rank2.ToString();
            tbRank3Amount.Text = rank.rank3.ToString();
            tbRank4Amount.Text = rank.rank4.ToString();
            tbRank5Amount.Text = rank.rank5.ToString();
            tbRank6Amount.Text = rank.rank6.ToString();
            tbRank7Amount.Text = rank.rank7.ToString();
            tbRank8Amount.Text = rank.rank8.ToString();
        }

        private void btnr1plus1_Click(object sender, RoutedEventArgs e)
        {
            tbRank1Amount.Text = setRanksPlusOne(tbRank1Amount.Text);
            CreateRanksAndSetMainWindow();
        }

       

        private void btnr2plus1_Click(object sender, RoutedEventArgs e)
        {
            tbRank2Amount.Text = setRanksPlusOne(tbRank2Amount.Text);
            CreateRanksAndSetMainWindow();
        }
        private void btnr3plus1_Click(object sender, RoutedEventArgs e)
        {
            tbRank3Amount.Text = setRanksPlusOne(tbRank3Amount.Text);
            CreateRanksAndSetMainWindow();
        }
        private void btnr4plus1_Click(object sender, RoutedEventArgs e)
        {
            tbRank4Amount.Text = setRanksPlusOne(tbRank4Amount.Text);
            CreateRanksAndSetMainWindow();
        }
        private void btnr5plus1_Click(object sender, RoutedEventArgs e)
        {
            tbRank5Amount.Text = setRanksPlusOne(tbRank5Amount.Text);
            CreateRanksAndSetMainWindow();
        }
        private void btnr6plus1_Click(object sender, RoutedEventArgs e)
        {
            tbRank6Amount.Text = setRanksPlusOne(tbRank6Amount.Text);
            CreateRanksAndSetMainWindow();
        }
        private void btnr7plus1_Click(object sender, RoutedEventArgs e)
        {
            tbRank7Amount.Text = setRanksPlusOne(tbRank7Amount.Text);
            CreateRanksAndSetMainWindow();
        }
        private void btnr8plus1_Click(object sender, RoutedEventArgs e)
        {
            tbRank8Amount.Text = setRanksPlusOne(tbRank8Amount.Text);
            CreateRanksAndSetMainWindow();
        }
        private void btnr1plus1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            tbRank1Amount.Text = setRanksMinusOne(tbRank1Amount.Text);
            CreateRanksAndSetMainWindow();
        }
        private void btnr2plus1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            tbRank2Amount.Text = setRanksMinusOne(tbRank2Amount.Text);
            CreateRanksAndSetMainWindow();
        }
        private void btnr3plus1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            tbRank3Amount.Text = setRanksMinusOne(tbRank3Amount.Text);
            CreateRanksAndSetMainWindow();
        }
        private void btnr4plus1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            tbRank4Amount.Text = setRanksMinusOne(tbRank4Amount.Text);
            CreateRanksAndSetMainWindow();
        }
        private void btnr5plus1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            tbRank5Amount.Text = setRanksMinusOne(tbRank5Amount.Text);
            CreateRanksAndSetMainWindow();
        }
        private void btnr6plus1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            tbRank6Amount.Text = setRanksMinusOne(tbRank6Amount.Text);
            CreateRanksAndSetMainWindow();
        }
        private void btnr7plus1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            tbRank7Amount.Text = setRanksMinusOne(tbRank7Amount.Text);
            CreateRanksAndSetMainWindow();
        }
        private void btnr8plus1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            tbRank8Amount.Text = setRanksMinusOne(tbRank8Amount.Text);
            CreateRanksAndSetMainWindow();
        }

        private string setRanksPlusOne(string tbrankAmount)
        {
            return (Int32.Parse(tbrankAmount) + 1).ToString();
        }

        private string setRanksMinusOne(string tbrankAmount)
        {
            if (Int32.Parse(tbrankAmount) != 0)
            {

                return (Int32.Parse(tbrankAmount) - 1).ToString();

            }
            else return "0";          
        }

        private void CreateRanksAndSetMainWindow()
        {
            var rank = new Ranks();
            rank.rank1 = Int32.Parse(tbRank1Amount.Text);
            rank.rank2 = Int32.Parse(tbRank2Amount.Text);
            rank.rank3 = Int32.Parse(tbRank3Amount.Text);
            rank.rank4 = Int32.Parse(tbRank4Amount.Text);
            rank.rank5 = Int32.Parse(tbRank5Amount.Text);
            rank.rank6 = Int32.Parse(tbRank6Amount.Text);
            rank.rank7 = Int32.Parse(tbRank7Amount.Text);
            rank.rank8 = Int32.Parse(tbRank8Amount.Text);
            ranks.Add(rank);
            _mainWindow.SetTextBoxValue(rank);
        }

    }
}
