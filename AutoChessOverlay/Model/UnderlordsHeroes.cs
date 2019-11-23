using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoChessOverlay.Model
{
    class UnderlordsHeroes
    {
        public List<string> Names { get; set; }
        public List<string> ImgPaths { get; set; }

        public UnderlordsHeroes()
        {
            Names = new List<string>()
            {
                "Anessix",
                "Hobgen"
            };
        }
    }
}
