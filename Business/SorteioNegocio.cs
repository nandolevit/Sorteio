using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Object;
using DB;
using System.Data;

namespace Business
{
    public enum enumCRUD
    {
        select,
        insert,
        update,
        delete
    }

    public class SorteioNegocio
    {
        Cnx cnx = new Cnx();


        public SorteioItemColecao ConsultarItemIdSorteio(int id)
        {
            if (cnx.Conectar())
            {
                cnx.AddMySqlParameterCollection("@id", id);
                DataTable dataTable = (DataTable)cnx.ExecutarComandoMySql("spConsultarItemIdSorteio", enumExecutar.DataTable);

                if (dataTable != null)
                {
                    return PreencherSorteioItemColecao(dataTable);
                }
                else
                    return null;
            }
            else
                return null;
        }

        public int InsertSorteioItem(SorteioItemInfo item)
        {
            if (cnx.Conectar())
            {
                cnx.AddMySqlParameterCollection("@prod", item.Prod.produtoid);
                cnx.AddMySqlParameterCollection("@sort", item.Sort.sorteioid);
                cnx.AddMySqlParameterCollection("@quant", item.Quant);

                return Convert.ToInt32(cnx.ExecutarComandoMySql("spInsertSorteioItem", enumExecutar.Scalar));
            }
            else
                return 0;
        }

        public int DeleteBilheteIdConcorrente(int id, int idsort)
        {
            if (cnx.Conectar())
            {
                cnx.AddMySqlParameterCollection("@id", id);
                cnx.AddMySqlParameterCollection("@idsort", idsort);
                return Convert.ToInt32(cnx.ExecutarComandoMySql("spDeleteBilheteIdConcorrente", enumExecutar.Scalar));
            }
            else
                return 0;
        }

        public object ExecutarBilhete(enumCRUD en, BilheteInfo b = null)
        {
            if (cnx.Conectar())
            {
                BilheteAdd(b, cnx);

                switch (en)
                {
                    case enumCRUD.select:
                        return 0;
                    case enumCRUD.insert:
                        return Convert.ToInt32(cnx.ExecutarComandoMySql("spInsertBilhete", enumExecutar.Scalar));
                    case enumCRUD.update:
                        return 0;
                    case enumCRUD.delete:
                        return 0;
                    default:
                        return 0;
                }
            }
            else
                return 0;
        }

        private void BilheteAdd(BilheteInfo a, Cnx cnz)
        {
            if (a != null)
            {
                cnz.AddMySqlParameterCollection("@conc", a.bilheteidconcorrente.concorrenteid);
                cnz.AddMySqlParameterCollection("@vend", a.bilheteidVendedor.concorrenteid);
                cnz.AddMySqlParameterCollection("@sort", a.bilheteidsorteio.sorteioid);
                cnz.AddMySqlParameterCollection("@num", a.bilhetenum);
            }
        }

        public object ExecutarProduto(enumCRUD en, ProdutoInfo prod = null)
        {
            if (cnx.Conectar())
            {
                ProdutoAdd(prod, cnx);

                switch (en)
                {
                    case enumCRUD.select:

                        DataTable dataTable = (DataTable)cnx.ExecutarComandoMySql("spConsultarProduto", enumExecutar.DataTable);
                        if (dataTable != null)
                            return PreencherProdutoColecao(dataTable);
                        else
                            return null;

                    case enumCRUD.insert:
                        return Convert.ToInt32(cnx.ExecutarComandoMySql("spInsertProduto", enumExecutar.Scalar));
                    case enumCRUD.update:
                        return 0;
                    case enumCRUD.delete:
                        return 0;
                    default:
                        return 0;
                }
            }
            else
                return 0;
        }

        private void ProdutoAdd(ProdutoInfo a, Cnx cnz)
        {
            if (a != null)
            {
                cnz.AddMySqlParameterCollection("@descricao", a.produtodescricao);
                cnz.AddMySqlParameterCollection("@foto", a.produtofoto);
                cnz.AddMySqlParameterCollection("@valor", a.produtovalor);
            }
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

        public object ExecutarSorteio(enumCRUD en, SorteioInfo sort = null)
        {
            if (cnx.Conectar())
            {
                SorteioAdd(sort, cnx);

                switch (en)
                {
                    case enumCRUD.select:

                        DataTable table = (DataTable)cnx.ExecutarComandoMySql("spConsultarSorteio", enumExecutar.DataTable);
                        if (table != null)
                            return PreencherSorteioColecao(table);
                        else
                            return null;

                    case enumCRUD.insert:
                        return Convert.ToInt32(cnx.ExecutarComandoMySql("spInsertSorteio", enumExecutar.Scalar));
                    case enumCRUD.update:
                        cnx.AddMySqlParameterCollection("@id", sort.sorteioid);
                        return Convert.ToInt32(cnx.ExecutarComandoMySql("spUpdateSorteio", enumExecutar.Scalar));
                    case enumCRUD.delete:
                        return 0;
                    default:
                        return 0;
                }
            }
            else
                return 0;
        }

        private void SorteioAdd(SorteioInfo a, Cnx cnz)
        {
            if (a != null)
            {
                cnz.AddMySqlParameterCollection("@descricao", a.sorteiodescricao);
                cnz.AddMySqlParameterCollection("@quantb", a.sorteiobilhetequant);
                cnz.AddMySqlParameterCollection("@valor", a.sorteiobilhetevalor);
                cnz.AddMySqlParameterCollection("@sdata", a.sorteiodata);
            } 
           
        }

        private ProdutoColecao PreencherProdutoColecao(DataTable dataTable)
        {
            var colecao = new ProdutoColecao();
            foreach (DataRow row in dataTable.Rows)
                colecao.Add(PreencherProdutoInfo(row));

            return colecao;
        }

        private ProdutoInfo PreencherProdutoInfo(DataRow row)
        {
            ProdutoInfo info = new ProdutoInfo
            {
                produtodescricao = Convert.ToString(row["produtodescricao"]),
                produtofoto = (byte[])(row["produtofoto"]),
                produtoid = Convert.ToInt32(row["produtoid"]),
                produtovalor = Convert.ToDecimal(row["produtovalor"]),
            };

            return info;
        }

        private SorteioItemColecao PreencherSorteioItemColecao( DataTable dataTable)
        {
            var colecao = new SorteioItemColecao();
            foreach (DataRow row in dataTable.Rows)
            {
                var sort = new SorteioItemInfo
                {
                    Prod = PreencherProdutoInfo(row),
                    Sort = PreencherSorteioInfo(row),
                    Quant = Convert.ToInt32(row["itemprodquant"]),
                };

                colecao.Add(sort);
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
                    bilheteidconcorrente = ConcorrenteNegocio.PreencherConcorrenteInfo(row),
                    bilheteidsorteio = PreencherSorteioInfo(row)
                };

                info.bilheteidVendedor = new ConcorrenteInfo { concorrenteid = Convert.ToInt32(row["bilheteidVendedor"]) };

                colecao.Add(info);

            }

            return colecao;
        }

        private SorteioColecao PreencherSorteioColecao(DataTable table)
        {
            var colecao = new SorteioColecao();
            foreach (DataRow row in table.Rows)
                colecao.Add(PreencherSorteioInfo(row));

            return colecao;
        }

        private SorteioInfo PreencherSorteioInfo(DataRow row)
        {
            SorteioInfo info = new SorteioInfo
            {
                sorteiodata = Convert.ToDateTime(row["sorteiodata"]),
                sorteiodatacad = Convert.ToDateTime(row["sorteiodatacad"]),
                sorteiodescricao = Convert.ToString(row["sorteiodescricao"]),
                sorteioid = Convert.ToInt32(row["sorteioid"]),
                sorteiobilhetequant = Convert.ToInt32(row["sorteiobilhetequant"]),
                sorteiobilhetevalor = Convert.ToDecimal(row["sorteiobilhetevalor"]),
            };

            return info;
        }
    }
}
