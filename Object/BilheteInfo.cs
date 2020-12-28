using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{

    [Serializable]
    public class BilheteInfo
    {
        public int bilhetenum { get; set; }
        public SorteioInfo bilheteidsorteio { get; set; }
        public ConcorrenteInfo bilheteidconcorrente { get; set; }
        public ConcorrenteInfo bilheteidvendedor { get; set; }
        public int bilheteid { get; set; }
    }
}
