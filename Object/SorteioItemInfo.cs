using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    [Serializable]
    public class SorteioItemInfo
    {
        public int ID { get; set; }
        public ProdutoInfo Prod { get; set; }
        public SorteioInfo Sort { get; set; }
        public int Quant { get; set; }
    }
}
