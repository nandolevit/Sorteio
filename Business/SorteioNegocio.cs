﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Object;
using DB;
using System.Data;

namespace Business
{
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

        public ProdutoColecao ConsultarProduto()
        {
            if (cnx.Conectar())
            {
                DataTable dataTable = (DataTable)cnx.ExecutarComandoMySql("spConsultarProduto", enumExecutar.DataTable);
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
                cnx.AddMySqlParameterCollection("@quantb", sort.sorteiobilhetequant);
                cnx.AddMySqlParameterCollection("@valor", sort.sorteiobilhetevalor);
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
