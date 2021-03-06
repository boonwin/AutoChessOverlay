﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using AutoChessOverlay.Model;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using System.Windows.Threading;
using System.Media;
using WpfAnimatedGif;

namespace AutoChessOverlay.View
{
    /// <summary>
    /// Interaktionslogik für DataInput.xaml
    /// </summary>
    public partial class DataInput
    {
        private readonly MainWindow _mainWindow;
        private DispatcherTimer dispatcherTimer;
 
        private string gameFilePath = null;
        private string skinConfigPath = null;
        public DataInput(MainWindow mainWindow)
        {
         
            _mainWindow = mainWindow;
            InitializeComponent();

            var filePath = new FilePathes();
            DataContext = new HsBattlegroundsHeroes();
            gameFilePath = filePath.gameResultPath;
            skinConfigPath = filePath.skinConfigPath;

            //Create a timer with interval of 2 secs
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);

        
        }


        List<Ranks> ranks = new List<Ranks>();


        private void btnEnterData_Click(object sender, RoutedEventArgs e)
        {
        

            if (String.IsNullOrEmpty(gameFilePath) == true)
            {
                MessageBox.Show("Please choose a Game", "Boonwins Autobattler Overlay", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                var history = new GameHistory(gameFilePath);
                history.Show();
            }
        }


        public void SetTextBoxValue(Ranks rank)
        {
            tbRank1Amount.Text = rank.rank1Amount.ToString();
            tbRank2Amount.Text = rank.rank2Amount.ToString();
            tbRank3Amount.Text = rank.rank3Amount.ToString();
            tbRank4Amount.Text = rank.rank4Amount.ToString();
            tbRank5Amount.Text = rank.rank5Amount.ToString();
            tbRank6Amount.Text = rank.rank6Amount.ToString();
            tbRank7Amount.Text = rank.rank7Amount.ToString();
            tbRank8Amount.Text = rank.rank8Amount.ToString();
        }

        private void btnr1plus1_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(gameFilePath) == true)
            {
                MessageBox.Show("Please choose a Game before +1", "Boonwins Autobattler Overlay", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                tbRank1Amount.Text = setRanksPlusOne(tbRank1Amount.Text);
                CreateRanksAndSetMainWindow();
                saveRound("1st");

                if (File.Exists(skinConfigPath))
                {

                    var skin = File.ReadAllText(skinConfigPath);
                    if (skin == "Benice")
                    {
                        //Things which happen before the timer starts
                        var controller = ImageBehavior.GetAnimationController(_mainWindow.imgBg);
                        if (controller.IsComplete == true)
                        {
                            controller.GotoFrame(0);
                        }
                        controller.Play();
                        

                    }
                }

            }
        }


        private void btnr2plus1_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(gameFilePath) == true)
            {
                MessageBox.Show("Please choose a Game before +1", "Boonwins Autobattler Overlay", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                tbRank2Amount.Text = setRanksPlusOne(tbRank2Amount.Text);
                CreateRanksAndSetMainWindow();
                saveRound("2nd");
            }
        }
        private void btnr3plus1_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(gameFilePath) == true)
            {
                MessageBox.Show("Please choose a Game before +1", "Boonwins Autobattler Overlay", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                tbRank3Amount.Text = setRanksPlusOne(tbRank3Amount.Text);
                CreateRanksAndSetMainWindow();
                saveRound("3rd");
            }

        }
        private void btnr4plus1_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(gameFilePath) == true)
            {
                MessageBox.Show("Please choose a Game before +1", "Boonwins Autobattler Overlay", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                tbRank4Amount.Text = setRanksPlusOne(tbRank4Amount.Text);
                CreateRanksAndSetMainWindow();
                saveRound("4th");
            }
        }
        private void btnr5plus1_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(gameFilePath) == true)
            {
                MessageBox.Show("Please choose a Game before +1", "Boonwins Autobattler Overlay", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                tbRank5Amount.Text = setRanksPlusOne(tbRank5Amount.Text);
                CreateRanksAndSetMainWindow();
                saveRound("5th");
            }
        }
        private void btnr6plus1_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(gameFilePath) == true)
            {
                MessageBox.Show("Please choose a Game before +1", "Boonwins Autobattler Overlay", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                tbRank6Amount.Text = setRanksPlusOne(tbRank6Amount.Text);
                CreateRanksAndSetMainWindow();
                saveRound("6th");
            }
        }
        private void btnr7plus1_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(gameFilePath) == true)
            {
                MessageBox.Show("Please choose a Game before +1", "Boonwins Autobattler Overlay", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                tbRank7Amount.Text = setRanksPlusOne(tbRank7Amount.Text);
                CreateRanksAndSetMainWindow();
                saveRound("7th");
            }
        }
        private void btnr8plus1_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(gameFilePath) == true)
            {
                MessageBox.Show("Please choose a Game before +1", "Boonwins Autobattler Overlay", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                tbRank8Amount.Text = setRanksPlusOne(tbRank8Amount.Text);
                CreateRanksAndSetMainWindow();
                saveRound("8th");
                
                if (File.Exists(skinConfigPath))
                {
                   
                   var skin = File.ReadAllText(skinConfigPath);
                   if (skin == "Benice")
                    {
                        //Things which happen before the timer starts
                        _mainWindow.klinsi.Visibility = Visibility.Visible;
                        //SoundPlayer mediaPlayer = new SoundPlayer(@"F:\Projekte\AutoChessOverlay\AutoChessOverlay\Skins\Benice\lache.wav");                       
                        //mediaPlayer.Play();
                        //Start the timer
                        dispatcherTimer.Start();
                    }
                }
            }                
        }
        private void btnr1plus1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (String.IsNullOrEmpty(gameFilePath) == true)
            {
                MessageBox.Show("Please choose a Game before +1", "Boonwins Autobattler Overlay", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                tbRank1Amount.Text = setRanksMinusOne(tbRank1Amount.Text);
                CreateRanksAndSetMainWindow();
            }

        }
        private void btnr2plus1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (String.IsNullOrEmpty(gameFilePath) == true)
            {
                MessageBox.Show("Please choose a Game before +1", "Boonwins Autobattler Overlay", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                tbRank2Amount.Text = setRanksMinusOne(tbRank2Amount.Text);
                CreateRanksAndSetMainWindow();
            }
        }
        private void btnr3plus1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (String.IsNullOrEmpty(gameFilePath) == true)
            {
                MessageBox.Show("Please choose a Game before +1", "Boonwins Autobattler Overlay", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                tbRank3Amount.Text = setRanksMinusOne(tbRank3Amount.Text);
                CreateRanksAndSetMainWindow();
            }
        }
        private void btnr4plus1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (String.IsNullOrEmpty(gameFilePath) == true)
            {
                MessageBox.Show("Please choose a Game before +1", "Boonwins Autobattler Overlay", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                tbRank4Amount.Text = setRanksMinusOne(tbRank4Amount.Text);
                CreateRanksAndSetMainWindow();
            }
        }
        private void btnr5plus1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (String.IsNullOrEmpty(gameFilePath) == true)
            {
                MessageBox.Show("Please choose a Game before +1", "Boonwins Autobattler Overlay", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                tbRank5Amount.Text = setRanksMinusOne(tbRank5Amount.Text);
                CreateRanksAndSetMainWindow();
            }
        }
        private void btnr6plus1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (String.IsNullOrEmpty(gameFilePath) == true)
            {
                MessageBox.Show("Please choose a Game before +1", "Boonwins Autobattler Overlay", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                tbRank6Amount.Text = setRanksMinusOne(tbRank6Amount.Text);
                CreateRanksAndSetMainWindow();
            }
        }
        private void btnr7plus1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (String.IsNullOrEmpty(gameFilePath) == true)
            {
                MessageBox.Show("Please choose a Game before +1", "Boonwins Autobattler Overlay", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                tbRank7Amount.Text = setRanksMinusOne(tbRank7Amount.Text);
                CreateRanksAndSetMainWindow();
            }
        }
        private void btnr8plus1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (String.IsNullOrEmpty(gameFilePath) == true)
            {
                MessageBox.Show("Please choose a Game before +1", "Boonwins Autobattler Overlay", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                tbRank8Amount.Text = setRanksMinusOne(tbRank8Amount.Text);
                CreateRanksAndSetMainWindow();
            }
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
            rank.rank1Amount = Int32.Parse(tbRank1Amount.Text);
            rank.rank2Amount = Int32.Parse(tbRank2Amount.Text);
            rank.rank3Amount = Int32.Parse(tbRank3Amount.Text);
            rank.rank4Amount = Int32.Parse(tbRank4Amount.Text);
            rank.rank5Amount = Int32.Parse(tbRank5Amount.Text);
            rank.rank6Amount = Int32.Parse(tbRank6Amount.Text);
            rank.rank7Amount = Int32.Parse(tbRank7Amount.Text);
            rank.rank8Amount = Int32.Parse(tbRank8Amount.Text);
            ranks.Add(rank);

            _mainWindow.SetTextBoxValue(rank);

        }

        private void cbGame_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var filePath = new FilePathes();
            if (cbGame.SelectedItem.ToString() == "Battlegrounds")
            {
                DataContext = new HsBattlegroundsHeroes();
                gameFilePath = filePath.gameResultPath;
            }
            if (cbGame.SelectedItem.ToString() == "Underlords")
            {
                DataContext = new UnderlordsHeroes();
                gameFilePath = filePath.underlordsGameResultPath;
            }
        }

        private void saveRound(string rank)
        {

            var line = DateTime.Now.ToString("yyyyMMdd") + ";" + rank + "\r\n";
            File.AppendAllText(gameFilePath, line);

        }
        private void mnuThemes_Click(object sender, RoutedEventArgs e)
        {
            var skin = new Skins(_mainWindow);
            skin.Show();
        }
        private void mnuResetStats_Click(object sender, RoutedEventArgs e)
        {
            var rank = new Ranks();
            rank.rank1Amount = 0;
            rank.rank2Amount = 0;
            rank.rank3Amount = 0;
            rank.rank4Amount = 0;
            rank.rank5Amount = 0;
            rank.rank6Amount = 0;
            rank.rank7Amount = 0;
            rank.rank8Amount = 0;
            ranks.Add(rank);
            tbRank1Amount.Text = rank.rank1Amount.ToString();
            tbRank2Amount.Text = rank.rank2Amount.ToString();
            tbRank3Amount.Text = rank.rank3Amount.ToString();
            tbRank4Amount.Text = rank.rank4Amount.ToString();
            tbRank5Amount.Text = rank.rank5Amount.ToString();
            tbRank6Amount.Text = rank.rank6Amount.ToString();
            tbRank7Amount.Text = rank.rank7Amount.ToString();
            tbRank8Amount.Text = rank.rank8Amount.ToString();
            _mainWindow.SetTextBoxValue(rank);
        }

        private void tbMmr_TextChanged(object sender, TextChangedEventArgs e)
        {
            _mainWindow.tbMmrValueText.Content = tbMmr.Text;
        }

        private void tbMmrNow_TextChanged(object sender, TextChangedEventArgs e)
        {
            _mainWindow.tbMmrNowValueText.Content = tbMmrNow.Text;
        }

        private void mnuExit_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(tbMmrNow.Text)){
                var file = new FilePathes();
                if(Int32.Parse(tbMmrNow.Text) > 0)
                {
                    File.WriteAllText(file.mmrPath, tbMmrNow.Text);
                }
            }
            App.Current.Shutdown();
        }

        private void cbAllMmrActive_Checked(object sender, RoutedEventArgs e)
        {
            _mainWindow.ShowMMR();
        }
        private void cbAllMmrActive_Unchecked(object sender, RoutedEventArgs e)
        {
            _mainWindow.HideMMR();

        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            //Things which happen after 1 timer interval
           
            _mainWindow.klinsi.Visibility = System.Windows.Visibility.Collapsed;

            //Disable the timer
            dispatcherTimer.IsEnabled = false;
        }

   
    }
}
