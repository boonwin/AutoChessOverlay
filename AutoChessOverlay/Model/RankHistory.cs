using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AutoChessOverlay.Model
{
    class RankHistory
    {

        public string Dates { get; set; }
        public string Rank { get; set; }

        public static RankHistory parse(string data)
        {

            var result = new RankHistory();    
            var splitedLine = data.Split(';');            
            result.Dates = splitedLine[0];            
            result.Rank = splitedLine[1];

            return result;
        }
    }
}

