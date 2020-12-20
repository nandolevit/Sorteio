using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Obejct;
using DB;
using System.Data;

namespace Business
{
    public class SorteioNegocio
    {
        Cnx cnx = new Cnx();


        public int DeleteBilheteIdConcorrente(int id)
        {
            if (cnx.Conectar())
            {
                cnx.AddMySqlParameterCollection("@id", id);
                return Convert.ToInt32(cnx.ExecutarComandoMySql("spDeleteBilheteIdConcorrente", enumExecutar.Scalar));
            }
            else
                return 0;
        }
        public int InsertBilhete(BilheteInfo b)
        {
            if (cnx.Conectar())
            {
                cnx.AddMySqlParameterCollection("@conc", b.bilheteidconcorrente.concorrenteid);
                cnx.AddMySqlParameterCollection("@vend", b.bilheteidVendedor.concorrenteid);
                cnx.AddMySqlParameterCollection("@sort", b.bilheteidsorteio.sorteioid);
                cnx.AddMySqlParameterCollection("@num", b.bilhetenum);

                return Convert.ToInt32(cnx.ExecutarComandoMySql("spInsertBilhete", enumExecutar.Scalar));
            }
            else
                return 0;
        }

        public ProdutoColecao ConsultarProdutoIdSorteio(int id)
        {
            if (cnx.Conectar())
            {
                cnx.AddMySqlParameterCollection("@id", id);
                DataTable dataTable = (DataTable)cnx.ExecutarComandoMySql("spConsultarProdutoIdSorteio", enumExecutar.DataTable);
                if (dataTable != null)
                {
                    return PreencherProdutoColecao(dataTable);
                }
                else
                    return null;
            }
            else
                return null;
        }

        public int InsertProduto(ProdutoInfo prod)
        {
            if (cnx.Conectar())
            {
                cnx.AddMySqlParameterCollection("@descricao", prod.produtodescricao);
                cnx.AddMySqlParameterCollection("@foto", prod.produtofoto);
                cnx.AddMySqlParameterCollection("@sort", prod.produtoidsorteio);
                cnx.AddMySqlParameterCollection("@quant", prod.produtoquant);
                cnx.AddMySqlParameterCollection("@valor", prod.produtovalor);

                return Convert.ToInt32(cnx.ExecutarComandoMySql("spInsertProduto", enumExecutar.Scalar));
            }
            else
                return 0;
        }

        public BilheteColecao ConsultarBilheteIdSorteio(int id)
        {
            if (cnx.Conectar())
            {
                cnx.AddMySqlParameterCollection("@id", id);
                DataTable table = (DataTable)cnx.ExecutarComandoMySql("spConsultarBilheteIdSorteio", enumExecutar.DataTable);

                if (table != null)
                {
                    return PreencherBilheteColecao(table);
                }
                else
                    return null;
            }
            else
                return null;
        }

        public SorteioInfo ConsultarSorteioId(int id)
        {
            if (cnx.Conectar())
            {
                cnx.AddMySqlParameterCollection("@id", id);
                DataTable table = (DataTable)cnx.ExecutarComandoMySql("spConsultarSorteioId", enumExecutar.DataTable);

                if (table != null)
                {
                    return PreencherSorteioColecao(table)[0];
                }
                else
                    return null;
            }
            else
                return null;
        }

        public SorteioColecao ConsultarSorteio()
        {
            if (cnx.Conectar())
            {
                DataTable table = (DataTable)cnx.ExecutarComandoMySql("spConsultarSorteio", enumExecutar.DataTable);

                if (table != null)
                {
                    return PreencherSorteioColecao(table);
                }
                else
                    return null;
            }
            else
                return null;
        }

        public int InsertSorteio(SorteioInfo sort)
        {
            if (cnx.Conectar())
            {
                cnx.AddMySqlParameterCollection("@descricao", sort.sorteiodescricao);
                cnx.AddMySqlParameterCollection("@quant", sort.sorteioquant);
                cnx.AddMySqlParameterCollection("@sdata", sort.sorteiodata);

                return Convert.ToInt32(cnx.ExecutarComandoMySql("spInsertSorteio", enumExecutar.Scalar));
            }
            else
                return 0;
        }

        private ProdutoColecao PreencherProdutoColecao(DataTable dataTable)
        {
            var colecao = new ProdutoColecao();
            foreach (DataRow row in dataTable.Rows)
            {
                ProdutoInfo info = new ProdutoInfo
                {
                    produtodescricao = Convert.ToString(row["produtodescricao"]),
                    produtofoto = (byte[])(row["produtofoto"]),
                    produtoid = Convert.ToInt32(row["produtoid"]),
                    produtoidsorteio = Convert.ToInt32(row["produtoidsorteio"]),
                    produtoquant = Convert.ToInt32(row["produtoquant"]),
                    produtovalor = Convert.ToDecimal(row["produtovalor"]),
                };

                colecao.Add(info);
            }

            return colecao;
        }

        private BilheteColecao PreencherBilheteColecao(DataTable table)
        {
            var colecao = new BilheteColecao();
            foreach (DataRow row in table.Rows)
            {
                BilheteInfo info = new BilheteInfo
                {
                    bilheteid = Convert.ToInt32(row["bilheteid"]),
                    bilhetenum = Convert.ToInt32(row["bilhetenum"]),
                };

                info.bilheteidconcorrente = new ConcorrenteInfo { concorrenteid = Convert.ToInt32(row["bilheteidconcorrente"]) };
                info.bilheteidsorteio = new SorteioInfo { sorteioid = Convert.ToInt32(row["bilheteidsorteio"]) };

                colecao.Add(info);

            }

            return colecao;
        }

        private SorteioColecao PreencherSorteioColecao(DataTable table)
        {
            var colecao = new SorteioColecao();
            foreach (DataRow row in table.Rows)
            {
                SorteioInfo info = new SorteioInfo
                {
                    sorteiodata = Convert.ToDateTime(row["sorteiodata"]),
                    sorteiodatacad = Convert.ToDateTime(row["sorteiodatacad"]),
                    sorteiodescricao = Convert.ToString(row["sorteiodescricao"]),
                    sorteioid = Convert.ToInt32(row["sorteioid"]),
                    sorteioquant = Convert.ToInt32(row["sorteioquant"]),
                };

                colecao.Add(info);

            }

            return colecao;
        }
    }
}
