using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoChessOverlay.Model
{
    public class FilePathes
    {
        public string writePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\boonwin\data\";     
        public string gameResultPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\boonwin\data\gameresults.dat";
        public string underlordsGameResultPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\boonwin\data\ungameresults.dat";
        public string skinConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\boonwin\data\skinConfig.dat";
        public string mmrPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\boonwin\data\mmr.dat";


    }
}
