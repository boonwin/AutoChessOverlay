using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoChessOverlay
{
    public class Ranks
    {
        public int rank1 { get; set; }
        public int rank2 { get; set; }
        public int rank3 { get; set; }
        public int rank4 { get; set; }
        public int rank5 { get; set; }
        public int rank6 { get; set; }
        public int rank7 { get; set; }
        public int rank8 { get; set; }

    public int maxAmount()
        {

            return Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(rank1, rank2), rank3), rank4), rank5), rank6), rank7), rank8);

        }
    }
}
