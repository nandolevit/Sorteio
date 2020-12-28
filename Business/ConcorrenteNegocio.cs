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

        public ConcorrenteColecao CadTest()
        {
            if (cnx.Conectar())
            {
                DataTable dataTable = (DataTable)cnx.ExecutarComandoMySql("cadconcorrente", enumExecutar.DataTable);
                if (dataTable != null)
                    return PreencherConcorrenteColecao(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public object ExecutarConcorrente(enumCRUD en, ConcorrenteInfo info = null, bool vendedor = false)
        {
            if (cnx.Conectar())
            {
                int n = 0;
                ConcorrenteAdd(info, cnx);

                switch (en)
                {
                    case enumCRUD.select:

                        DataTable dataTable;

                        if (info == null)
                        {
                            if (vendedor)
                                dataTable = (DataTable)cnx.ExecutarComandoMySql("spConsultarVendedor", enumExecutar.DataTable);
                            else
                                dataTable = (DataTable)cnx.ExecutarComandoMySql("spConsultarTodosConcorrente", enumExecutar.DataTable);
                            //else
                            //    dataTable = (DataTable)cnx.ExecutarComandoMySql("spConsultarConcorrente", enumExecutar.DataTable);
                        }
                        else
                            dataTable = (DataTable)cnx.ExecutarComandoMySql("spConsultarConcorrenteCpf", enumExecutar.DataTable);

                        if (dataTable != null)
                            return PreencherConcorrenteColecao(dataTable);
                        else
                            return null;

                    case enumCRUD.insert:

                        if (vendedor)
                            n = Convert.ToInt32(cnx.ExecutarComandoMySql("spInsertVendedor", enumExecutar.Scalar));
                        else
                            n = Convert.ToInt32(cnx.ExecutarComandoMySql("spInsertConcorrente", enumExecutar.Scalar));
                        break;
                    case enumCRUD.update:
                        break;
                    case enumCRUD.delete:
                        break;
                    default:
                        break;
                }

                return n;
            }
            else
                return 0;
        }

        #region ADD

        private void ConcorrenteAdd(ConcorrenteInfo a, Cnx cnz)
        {
            if (a != null)
            {
                cnz.AddMySqlParameterCollection("@id", a.concorrenteid);
                cnz.AddMySqlParameterCollection("@cpf", a.concorrentecpf);
                cnz.AddMySqlParameterCollection("@nome", a.concorrentenome);
                cnz.AddMySqlParameterCollection("@email", a.concorrenteemail);
                cnz.AddMySqlParameterCollection("@tel", a.concorrentetelefone);
            }
        }

        #endregion

        #region PREENCHER

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
                concorrentevendedor = Convert.ToBoolean(row["concorrentevendedor"]),
            };

            return info;
        }
        #endregion
    }
}
