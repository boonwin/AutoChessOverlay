using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace AutoChessOverlay.Model
{
    public class Mmr
    {
                public int mmrChange(int mmrActual, int mmrLastRound)
        {
          return mmrLastRound-mmrActual;
        }

    }
}
