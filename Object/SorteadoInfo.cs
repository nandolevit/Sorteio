using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    [Serializable]
    public class SorteadoInfo
    {
        public ProdutoInfo Prod { get; set; }
        public BilheteInfo Bilhete { get; set; }
    }
}
