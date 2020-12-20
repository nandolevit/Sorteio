using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obejct
{
    public class ProdutoInfo
    {
        public int produtoid { get; set; }
        public int produtoidsorteio { get; set; }
        public decimal produtovalor { get; set; }
        public int produtoquant { get; set; }
        public string produtodescricao { get; set; }
        public byte[] produtofoto { get; set; }
    }
}
