using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Object;
using DB;

namespace Business
{
    public class ConcorrenteNegocio
    {
        Cnx cnx = new Cnx();

        public ConcorrenteInfo ConsultarConcorrenteCpf(string cpf)
        {
            if (cnx.Conectar())
            {
                cnx.AddMySqlParameterCollection("@cpf", cpf);
                DataTable dataTable = (DataTable)cnx.ExecutarComandoMySql("spConsultarConcorrenteCpf", enumExecutar.DataTable);
                if (dataTable != null)
                {
                    return PreencherConcorrenteColecao(dataTable)[0];
                }
                else
                    return null;
            }
            else
                return null;
        }

        public ConcorrenteColecao ConsultarConcorrente(bool vend)
        {
            if (cnx.Conectar())
            {
                DataTable dataTable;

                if (vend)
                    dataTable = (DataTable)cnx.ExecutarComandoMySql("spConsultarVendedor", enumExecutar.DataTable);
                else
                    dataTable = (DataTable)cnx.ExecutarComandoMySql("spConsultarConcorrente", enumExecutar.DataTable);

                if (dataTable != null)
                {
                    return PreencherConcorrenteColecao(dataTable);
                }
                else
                    return null;
            }
            else
                return null;
        }

        public int InsertConcorrente(ConcorrenteInfo info, bool vendedor = false)
        {
            if (cnx.Conectar())
            {
                cnx.AddMySqlParameterCollection("@cpf", info.concorrentecpf);
                cnx.AddMySqlParameterCollection("@nome", info.concorrentenome);
                cnx.AddMySqlParameterCollection("@email", info.concorrenteemail);
                cnx.AddMySqlParameterCollection("@tel", info.concorrentetelefone);

                int n = 0;
                if (vendedor)
                    n = Convert.ToInt32(cnx.ExecutarComandoMySql("spInsertVendedor", enumExecutar.Scalar));
                else
                    n = Convert.ToInt32(cnx.ExecutarComandoMySql("spInsertConcorrente", enumExecutar.Scalar));

                return n;
            }
            else
                return 0;
        }

        private ConcorrenteColecao PreencherConcorrenteColecao(DataTable dataTable)
        {
            var colecao = new ConcorrenteColecao();
            foreach (DataRow row in dataTable.Rows)
                colecao.Add(PreencherConcorrenteInfo(row));

            return colecao;
        }

        static public ConcorrenteInfo PreencherConcorrenteInfo(DataRow row)
        {
            ConcorrenteInfo info = new ConcorrenteInfo
            {
                concorrentecpf = Convert.ToString(row["concorrentecpf"]),
                concorrenteemail = Convert.ToString(row["concorrenteemail"]),
                concorrenteid = Convert.ToInt32(row["concorrenteid"]),
                concorrentenome = Convert.ToString(row["concorrentenome"]),
                concorrentetelefone = Convert.ToString(row["concorrentetelefone"]),
            };

            return info;
        }
    }
}
