using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoChessOverlay.Model
{
    public class Ranks
    {
        public int rank1Amount { get; set; }
        public int rank2Amount { get; set; }
        public int rank3Amount { get; set; }
        public int rank4Amount { get; set; }
        public int rank5Amount { get; set; }
        public int rank6Amount { get; set; }
        public int rank7Amount { get; set; }
        public int rank8Amount { get; set; }

        public int maxAmount()
        {

            return Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(rank1Amount, rank2Amount), rank3Amount), rank4Amount), rank5Amount), rank6Amount), rank7Amount), rank8Amount);

        }


        public List<string> makeOutPutTextFromRanks (Ranks ranks){

            var output = new List<string>()
            {
               DateTime.Now.ToString("yyyyMMdd")+ ";1st;" + ranks.rank1Amount.ToString(),
               DateTime.Now.ToString("yyyyMMdd")+ ";2nd;" + ranks.rank2Amount.ToString(),
               DateTime.Now.ToString("yyyyMMdd")+ ";3rd;" + ranks.rank3Amount.ToString(),
               DateTime.Now.ToString("yyyyMMdd")+ ";4th;" + ranks.rank4Amount.ToString(),
               DateTime.Now.ToString("yyyyMMdd")+ ";5th;" + ranks.rank5Amount.ToString(),
               DateTime.Now.ToString("yyyyMMdd")+ ";6th;" + ranks.rank6Amount.ToString(),
               DateTime.Now.ToString("yyyyMMdd")+ ";7th;" + ranks.rank7Amount.ToString(),
               DateTime.Now.ToString("yyyyMMdd")+ ";8th;" + ranks.rank8Amount.ToString()
            };

            return output;
            }
    }
}
