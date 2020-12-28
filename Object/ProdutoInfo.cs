using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    [Serializable]
    public class ProdutoInfo
    {
        public int produtoid { get; set; }
        public decimal produtovalor { get; set; }
        public string produtodescricao { get; set; }
        public byte[] produtofoto { get; set; }
    }
}
