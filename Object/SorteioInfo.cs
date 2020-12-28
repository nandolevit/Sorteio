using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    [Serializable]
    public class SorteioInfo
    {
        public int sorteioid { get; set; }
        public string sorteiodescricao { get; set; }
        public int sorteiobilhetequant { get; set; }
        public decimal sorteiobilhetevalor { get; set; }
        public DateTime sorteiodata { get; set; }
        public DateTime sorteiodatacad { get; set; }

    }
}
