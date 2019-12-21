using AutoChessOverlay.Model;
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

namespace AutoChessOverlay.View
{
    /// <summary>
    /// Interaktionslogik für Skins.xaml
    /// </summary>
    public partial class Skins : Window
    {
        private readonly MainWindow _mainWindow;
        public Skins(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

      public void changeToHsSkin()
        {
            _mainWindow.btRankTitle.Foreground = Brushes.Gold;
            _mainWindow.btRankTitle.FontFamily = new FontFamily("LHF Uncial Caps");
            _mainWindow.img1st.Source = new BitmapImage(new Uri("pack://application:,,,/BoonwinsAutobattlerStreamOverlay;component/Skins/Hs/1st.png"));
            _mainWindow.img2nd.Source = new BitmapImage(new Uri("pack://application:,,,/BoonwinsAutobattlerStreamOverlay;component/Skins/Hs/2nd.png"));
            _mainWindow.img3rd.Source = new BitmapImage(new Uri("pack://application:,,,/BoonwinsAutobattlerStreamOverlay;component/Skins/Hs/3rd.png"));
            _mainWindow.img4th.Source = new BitmapImage(new Uri("pack://application:,,,/BoonwinsAutobattlerStreamOverlay;component/Skins/Hs/4th.png"));
            _mainWindow.img5th.Source = new BitmapImage(new Uri("pack://application:,,,/BoonwinsAutobattlerStreamOverlay;component/Skins/Hs/5th.png"));
            _mainWindow.img6th.Source = new BitmapImage(new Uri("pack://application:,,,/BoonwinsAutobattlerStreamOverlay;component/Skins/Hs/6th.png"));
            _mainWindow.img7th.Source = new BitmapImage(new Uri("pack://application:,,,/BoonwinsAutobattlerStreamOverlay;component/Skins/Hs/7th.png"));
            _mainWindow.img8th.Source = new BitmapImage(new Uri("pack://application:,,,/BoonwinsAutobattlerStreamOverlay;component/Skins/Hs/8th.png"));
            _mainWindow.tbAvgRankText.Foreground = Brushes.Gold;
            _mainWindow.tbAvgRankText.FontFamily = new FontFamily("LHF Uncial Caps");

            _mainWindow.lbRank1.Foreground = Brushes.Black;
            _mainWindow.lbRank2.Foreground = Brushes.Black;
            _mainWindow.lbRank3.Foreground = Brushes.Black;
            _mainWindow.lbRank4.Foreground = Brushes.Black;
            _mainWindow.lbRank5.Foreground = Brushes.Black;
            _mainWindow.lbRank6.Foreground = Brushes.Black;
            _mainWindow.lbRank7.Foreground = Brushes.Black;
            _mainWindow.lbRank8.Foreground = Brushes.Black;


            _mainWindow.lbRank1.FontFamily = new FontFamily("LHF Uncial Caps");
            _mainWindow.lbRank2.FontFamily = new FontFamily("LHF Uncial Caps");
            _mainWindow.lbRank3.FontFamily = new FontFamily("LHF Uncial Caps");
            _mainWindow.lbRank4.FontFamily = new FontFamily("LHF Uncial Caps");
            _mainWindow.lbRank5.FontFamily = new FontFamily("LHF Uncial Caps");
            _mainWindow.lbRank6.FontFamily = new FontFamily("LHF Uncial Caps");
            _mainWindow.lbRank7.FontFamily = new FontFamily("LHF Uncial Caps");
            _mainWindow.lbRank8.FontFamily = new FontFamily("LHF Uncial Caps");


            _mainWindow.pbRank1.Foreground = Brushes.Gold;
            _mainWindow.pbRank2.Foreground = Brushes.Gold;
            _mainWindow.pbRank3.Foreground = Brushes.Gold;
            _mainWindow.pbRank4.Foreground = Brushes.Gold;
            _mainWindow.pbRank5.Foreground = Brushes.Gold;
            _mainWindow.pbRank6.Foreground = Brushes.Gold;
            _mainWindow.pbRank7.Foreground = Brushes.Gold;
            _mainWindow.pbRank8.Foreground = Brushes.Gold;

            _mainWindow.pbRank1.Background = Brushes.GhostWhite;
            _mainWindow.pbRank2.Background = Brushes.GhostWhite;
            _mainWindow.pbRank3.Background = Brushes.GhostWhite;
            _mainWindow.pbRank4.Background = Brushes.GhostWhite;
            _mainWindow.pbRank5.Background = Brushes.GhostWhite;
            _mainWindow.pbRank6.Background = Brushes.GhostWhite;
            _mainWindow.pbRank7.Background = Brushes.GhostWhite;
            _mainWindow.pbRank8.Background = Brushes.GhostWhite;

            setStandardSkin("Hs");

          
        }

        internal void changeToBaseSkin()
        {
            _mainWindow.btRankTitle.Foreground = Brushes.Yellow;
            _mainWindow.btRankTitle.FontFamily = new FontFamily("Eras ITC");
            _mainWindow.img1st.Source = new BitmapImage(new Uri("pack://application:,,,/BoonwinsAutobattlerStreamOverlay;component/Skins/Base/1st.png"));
            _mainWindow.img2nd.Source = new BitmapImage(new Uri("pack://application:,,,/BoonwinsAutobattlerStreamOverlay;component/Skins/Base/2nd.png"));
            _mainWindow.img3rd.Source = new BitmapImage(new Uri("pack://application:,,,/BoonwinsAutobattlerStreamOverlay;component/Skins/Base/3rd.png"));
            _mainWindow.img4th.Source = new BitmapImage(new Uri("pack://application:,,,/BoonwinsAutobattlerStreamOverlay;component/Skins/Base/4th.png"));
            _mainWindow.img5th.Source = new BitmapImage(new Uri("pack://application:,,,/BoonwinsAutobattlerStreamOverlay;component/Skins/Base/5th.png"));
            _mainWindow.img6th.Source = new BitmapImage(new Uri("pack://application:,,,/BoonwinsAutobattlerStreamOverlay;component/Skins/Base/6th.png"));
            _mainWindow.img7th.Source = new BitmapImage(new Uri("pack://application:,,,/BoonwinsAutobattlerStreamOverlay;component/Skins/Base/7th.png"));
            _mainWindow.img8th.Source = new BitmapImage(new Uri("pack://application:,,,/BoonwinsAutobattlerStreamOverlay;component/Skins/Base/8th.png"));
            _mainWindow.tbAvgRankText.Foreground = Brushes.Yellow;
            _mainWindow.tbAvgRankText.FontFamily = new FontFamily("Eras ITC");

            _mainWindow.lbRank1.Foreground = Brushes.Black;
            _mainWindow.lbRank2.Foreground = Brushes.Black;
            _mainWindow.lbRank3.Foreground = Brushes.Black;
            _mainWindow.lbRank4.Foreground = Brushes.Black;
            _mainWindow.lbRank5.Foreground = Brushes.Black;
            _mainWindow.lbRank6.Foreground = Brushes.Black;
            _mainWindow.lbRank7.Foreground = Brushes.Black;
            _mainWindow.lbRank8.Foreground = Brushes.Black;


            _mainWindow.lbRank1.FontFamily = new FontFamily("Arial");
            _mainWindow.lbRank2.FontFamily = new FontFamily("Arial");
            _mainWindow.lbRank3.FontFamily = new FontFamily("Arial");
            _mainWindow.lbRank4.FontFamily = new FontFamily("Arial");
            _mainWindow.lbRank5.FontFamily = new FontFamily("Arial");
            _mainWindow.lbRank6.FontFamily = new FontFamily("Arial");
            _mainWindow.lbRank7.FontFamily = new FontFamily("Arial");
            _mainWindow.lbRank8.FontFamily = new FontFamily("Arial");

            _mainWindow.pbRank1.Foreground = Brushes.Lime;
            _mainWindow.pbRank2.Foreground = Brushes.LawnGreen;
            _mainWindow.pbRank3.Foreground = Brushes.GreenYellow;
            _mainWindow.pbRank4.Foreground = Brushes.Yellow;
            _mainWindow.pbRank5.Foreground = Brushes.Gold;
            _mainWindow.pbRank6.Foreground = Brushes.Orange;
            _mainWindow.pbRank7.Foreground = Brushes.OrangeRed;
            _mainWindow.pbRank8.Foreground = Brushes.Red;

            _mainWindow.pbRank1.Background = Brushes.GhostWhite;
            _mainWindow.pbRank2.Background = Brushes.GhostWhite;
            _mainWindow.pbRank3.Background = Brushes.GhostWhite;
            _mainWindow.pbRank4.Background = Brushes.GhostWhite;
            _mainWindow.pbRank5.Background = Brushes.GhostWhite;
            _mainWindow.pbRank6.Background = Brushes.GhostWhite;
            _mainWindow.pbRank7.Background = Brushes.GhostWhite;
            _mainWindow.pbRank8.Background = Brushes.GhostWhite;
            setStandardSkin("Base");
        }

        internal void changeToIceSkin()
        {
            _mainWindow.btRankTitle.Foreground = Brushes.LightSkyBlue;
            _mainWindow.btRankTitle.FontFamily = new FontFamily("Ice kingdom");
            _mainWindow.img1st.Source = new BitmapImage(new Uri("pack://application:,,,/BoonwinsAutobattlerStreamOverlay;component/Skins/Ice/1st.png"));
            _mainWindow.img2nd.Source = new BitmapImage(new Uri("pack://application:,,,/BoonwinsAutobattlerStreamOverlay;component/Skins/Ice/2nd.png"));
            _mainWindow.img3rd.Source = new BitmapImage(new Uri("pack://application:,,,/BoonwinsAutobattlerStreamOverlay;component/Skins/Ice/3rd.png"));
            _mainWindow.img4th.Source = new BitmapImage(new Uri("pack://application:,,,/BoonwinsAutobattlerStreamOverlay;component/Skins/Ice/4th.png"));
            _mainWindow.img5th.Source = new BitmapImage(new Uri("pack://application:,,,/BoonwinsAutobattlerStreamOverlay;component/Skins/Ice/5th.png"));
            _mainWindow.img6th.Source = new BitmapImage(new Uri("pack://application:,,,/BoonwinsAutobattlerStreamOverlay;component/Skins/Ice/6th.png"));
            _mainWindow.img7th.Source = new BitmapImage(new Uri("pack://application:,,,/BoonwinsAutobattlerStreamOverlay;component/Skins/Ice/7th.png"));
            _mainWindow.img8th.Source = new BitmapImage(new Uri("pack://application:,,,/BoonwinsAutobattlerStreamOverlay;component/Skins/Ice/8th.png"));
            _mainWindow.tbAvgRankText.Foreground = Brushes.LightSkyBlue;
            _mainWindow.tbAvgRankText.FontFamily = new FontFamily("Ice kingdom");
            _mainWindow.tbAvgRankText.FontSize = 20;

            _mainWindow.lbRank1.Foreground = Brushes.White;
            _mainWindow.lbRank2.Foreground = Brushes.White;
            _mainWindow.lbRank3.Foreground = Brushes.White;
            _mainWindow.lbRank4.Foreground = Brushes.White;
            _mainWindow.lbRank5.Foreground = Brushes.White;
            _mainWindow.lbRank6.Foreground = Brushes.White;
            _mainWindow.lbRank7.Foreground = Brushes.White;
            _mainWindow.lbRank8.Foreground = Brushes.White;


            _mainWindow.lbRank1.FontFamily = new FontFamily("Ice kingdom");
            _mainWindow.lbRank2.FontFamily = new FontFamily("Ice kingdom");
            _mainWindow.lbRank3.FontFamily = new FontFamily("Ice kingdom");
            _mainWindow.lbRank4.FontFamily = new FontFamily("Ice kingdom");
            _mainWindow.lbRank5.FontFamily = new FontFamily("Ice kingdom");
            _mainWindow.lbRank6.FontFamily = new FontFamily("Ice kingdom");
            _mainWindow.lbRank7.FontFamily = new FontFamily("Ice kingdom");
            _mainWindow.lbRank8.FontFamily = new FontFamily("Ice kingdom");


            _mainWindow.pbRank1.Foreground = Brushes.LightSkyBlue;
            _mainWindow.pbRank2.Foreground = Brushes.LightSkyBlue;
            _mainWindow.pbRank3.Foreground = Brushes.LightSkyBlue;
            _mainWindow.pbRank4.Foreground = Brushes.LightSkyBlue;
            _mainWindow.pbRank5.Foreground = Brushes.LightSkyBlue;
            _mainWindow.pbRank6.Foreground = Brushes.LightSkyBlue;
            _mainWindow.pbRank7.Foreground = Brushes.LightSkyBlue;
            _mainWindow.pbRank8.Foreground = Brushes.LightSkyBlue;

            _mainWindow.pbRank1.Background = Brushes.SteelBlue;
            _mainWindow.pbRank2.Background = Brushes.SteelBlue;
            _mainWindow.pbRank3.Background = Brushes.SteelBlue;
            _mainWindow.pbRank4.Background = Brushes.SteelBlue;
            _mainWindow.pbRank5.Background = Brushes.SteelBlue;
            _mainWindow.pbRank6.Background = Brushes.SteelBlue;
            _mainWindow.pbRank7.Background = Brushes.SteelBlue;
            _mainWindow.pbRank8.Background = Brushes.SteelBlue;
            setStandardSkin("Ice");
        }

        private void btnBaseSkin_Click(object sender, RoutedEventArgs e)
        {
            changeToBaseSkin();
        }

        private void btnIceSkin_Click(object sender, RoutedEventArgs e)
        {
            changeToIceSkin();
        }

       

        private void btnHsSkin_Click(object sender, RoutedEventArgs e)
        {
            changeToHsSkin();
        }

        private void setStandardSkin(string skinName)
        {
            var skinConfigFilePath = new FilePathes();
            var skinConfigFile = skinConfigFilePath.skinConfigPath;
            File.WriteAllText(skinConfigFile, skinName);      
        }
    }
}
