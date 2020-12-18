using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Obejct;
using DB;

namespace Business
{
    public class ConcorrenteNegocio
    {
        Cnx cnx = new Cnx();
        public int InsertConcorrente(ConcorrenteInfo info)
        {
            if (cnx.Conectar())
            {
                cnx.AddMySqlParameterCollection("@cpf", info.concorrentecpf);
                cnx.AddMySqlParameterCollection("@nome", info.concorrentenome);
                cnx.AddMySqlParameterCollection("@email", info.concorrenteemail);
                cnx.AddMySqlParameterCollection("@tel", info.concorrentetelefone);

                int n = Convert.ToInt32(cnx.ExecutarComandoMySql("spInsertConcorrente", enumExecutar.Scalar));
                return n;
            }
            else
                return 0;
        }
    }
}
