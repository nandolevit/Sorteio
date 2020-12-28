using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    [Serializable]
    public class ConcorrenteInfo
    {
        public int concorrenteid { get; set; }
        public string concorrentecpf { get; set; }
        public string concorrentenome { get; set; }
        public string concorrenteemail { get; set; }
        public string concorrentetelefone { get; set; }
        public bool concorrentevendedor { get; set; }


    }
}
