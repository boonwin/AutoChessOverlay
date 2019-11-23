using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AutoChessOverlay.Model
{
    public class Games
    {
        public List<string> GameNames { get; set; }
        public List<string> Heroes { get; set; }
        public Games()
        {
            GameNames = new List<string>()
            {
                "Battlegrounds",
                "Underlords"
            };

        }


    }
}
