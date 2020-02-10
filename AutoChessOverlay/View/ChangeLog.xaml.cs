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
using AutoChessOverlay.Model;
using AutoChessOverlay.Control;
using System.IO;



namespace AutoChessOverlay.View
{
    /// <summary>
    /// Interaktionslogik für ChangeLog.xaml
    /// </summary>
    public partial class ChangeLog : Window
    {
        private readonly MainWindow _mainWindow;

        public ChangeLog(MainWindow mainWindow)
        {

            _mainWindow = mainWindow;
            InitializeComponent();
            tb_changeLog.Text = "In this Version I added a basic Changelog, that will be look more fancy in the future. \n " +
                "I also will add soon a new blueish \"future\" Theme. \n" ;

        }

 
        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            var filePath = new FilePathes();
            if (File.Exists(filePath.changeLogPath)){

               File.WriteAllText(filePath.changeLogPath, Versions.version);

            }

            this.Close();
        }
    }
}
