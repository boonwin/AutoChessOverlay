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
            tbRank1Amount.Text = (Int32.Parse(tbRank1Amount.Text) + 1).ToString();
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

        private void btnr1plus1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Int32.Parse(tbRank1Amount.Text) != 0) { 
            
            tbRank1Amount.Text = (Int32.Parse(tbRank1Amount.Text) - 1).ToString();
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

        private void btnr2plus1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Int32.Parse(tbRank2Amount.Text) != 0)
            {

                tbRank2Amount.Text = (Int32.Parse(tbRank2Amount.Text) - 1).ToString();
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

        private void btnr2plus1_Click(object sender, RoutedEventArgs e)
        {
            tbRank2Amount.Text = (Int32.Parse(tbRank2Amount.Text) + 1).ToString();
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

        private void btnr3plus1_Click(object sender, RoutedEventArgs e)
        {
            tbRank3Amount.Text = (Int32.Parse(tbRank3Amount.Text) + 1).ToString();
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

        private void btnr4plus1_Click(object sender, RoutedEventArgs e)
        {
            tbRank4Amount.Text = (Int32.Parse(tbRank4Amount.Text) + 1).ToString();
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

        private void btnr5plus1_Click(object sender, RoutedEventArgs e)
        {
            tbRank5Amount.Text = (Int32.Parse(tbRank5Amount.Text) + 1).ToString();
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

        private void btnr6plus1_Click(object sender, RoutedEventArgs e)
        {
            tbRank6Amount.Text = (Int32.Parse(tbRank6Amount.Text) + 1).ToString();
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

        private void btnr7plus1_Click(object sender, RoutedEventArgs e)
        {
            tbRank7Amount.Text = (Int32.Parse(tbRank7Amount.Text) + 1).ToString();
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

        private void btnr8plus1_Click(object sender, RoutedEventArgs e)
        {
            tbRank8Amount.Text = (Int32.Parse(tbRank8Amount.Text) + 1).ToString();
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

        private void btnr8plus1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Int32.Parse(tbRank8Amount.Text) != 0)
            {

                tbRank8Amount.Text = (Int32.Parse(tbRank8Amount.Text) - 1).ToString();
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

        private void btnr7plus1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Int32.Parse(tbRank7Amount.Text) != 0)
            {

                tbRank7Amount.Text = (Int32.Parse(tbRank7Amount.Text) - 1).ToString();
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

        private void btnr6plus1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Int32.Parse(tbRank6Amount.Text) != 0)
            {

                tbRank6Amount.Text = (Int32.Parse(tbRank6Amount.Text) - 1).ToString();
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

        private void btnr5plus1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Int32.Parse(tbRank5Amount.Text) != 0)
            {

                tbRank5Amount.Text = (Int32.Parse(tbRank5Amount.Text) - 1).ToString();
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

        private void btnr4plus1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Int32.Parse(tbRank4Amount.Text) != 0)
            {

                tbRank4Amount.Text = (Int32.Parse(tbRank4Amount.Text) - 1).ToString();
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

        private void btnr3plus1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Int32.Parse(tbRank3Amount.Text) != 0)
            {

                tbRank3Amount.Text = (Int32.Parse(tbRank3Amount.Text) - 1).ToString();
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
}
