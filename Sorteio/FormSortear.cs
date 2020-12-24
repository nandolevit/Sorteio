using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Object;

namespace Sorteio
{
    public partial class FormSortear : Form
    {
        SorteioNegocio negSort;
        SorteioInfo infoSort;
        BilheteColecao colBilhete;
        SorteioItemColecao colItem;

        public FormSortear()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            numericUpDown1.Maximum = 1000;
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            negSort = new SorteioNegocio();
            SorteioColecao colSort = (SorteioColecao)negSort.ExecutarSorteio(enumCRUD.select);

            if (colSort != null)
            {
                var colecao = new Form_ConsultarColecao();
                foreach (var item in colSort)
                {
                    Form_Consultar form = new Form_Consultar
                    {
                        Cod = string.Format("{0:00000}", item.sorteioid),
                        Descricao = item.sorteiodescricao,
                        Objeto = item,
                    };

                    colecao.Add(form);
                }

                using (FormConsultar_Cod_Descricao consult = new FormConsultar_Cod_Descricao(colecao, "SORTEIO"))
                {
                    if (consult.ShowDialog(this) == DialogResult.Yes)
                    {
                        infoSort = (SorteioInfo)consult.Selecionado.Objeto;
                        textBoxDescricaoSort.Text = consult.Selecionado.Descricao;
                        dateTimePicker1.Value = infoSort.sorteiodata;
                        numericUpDown1.Value = infoSort.sorteiobilhetequant;
                        textBoxValor.Text = Convert.ToString(infoSort.sorteiobilhetevalor);

                        flowLayoutPanelProd.Controls.Clear();
                        SorteioItemInfo i = new SorteioItemInfo { Sort = infoSort, Prod = new ProdutoInfo() };
                        colItem = (SorteioItemColecao)negSort.ExecutarSorteioItem(enumCRUD.select, i);

                        if (colItem != null)
                        {
                            foreach (var item in colItem)
                            {
                                UserControlProd prod = new UserControlProd(true)
                                {
                                    Produto = item.Prod,
                                    Quant = item.Quant
                                };

                                flowLayoutPanelProd.Controls.Add(prod);
                            }

                            ContarItens();
                        }

                    }
                }
            }
        }

        private void ContarItens()
        {
            int totalQuant = 0;
            decimal totalValorProd = 0;
            foreach (var item in flowLayoutPanelProd.Controls)
            {
                UserControlProd prod = (UserControlProd)item;

                totalQuant += prod.Quant;
                totalValorProd += (prod.Produto.produtovalor * prod.Quant);
            }

            labelTotalQuant.Text = "Total de Prêmios: " + string.Format("{0:000}", totalQuant);
            labelTotalValorProd.Text = "Valor Total de Prêmios: " + string.Format("{0:C2}", totalValorProd);
            labelTotalValorBilhete.Text = "Valor Total de Bilhetes: " + string.Format("{0:C2}", infoSort != null ? infoSort.sorteiobilhetequant * infoSort.sorteiobilhetevalor : 0);

            ListaBilhete();
        }

        private void ListaBilhete()
        {

            NumSorteio(infoSort.sorteiobilhetequant);
            BilheteSelecionado();
        }

        private void BilheteSelecionado()
        {
            negSort = new SorteioNegocio();
            BilheteInfo b3 = new BilheteInfo { bilheteidconcorrente = new ConcorrenteInfo(), bilheteidsorteio = infoSort, bilheteidvendedor = new ConcorrenteInfo() };
            colBilhete = (BilheteColecao)negSort.ExecutarBilhete(enumCRUD.select, b3);

            if (colBilhete != null)
            {
                int totalBilhe = 0;
                foreach (var bi in colBilhete)
                {
                    foreach (var bu in flowLayoutPanelBilhete.Controls)
                    {
                        UserControlBilhete b = (UserControlBilhete)bu;
                        if (bi.bilhetenum == Convert.ToInt32(b.Texto))
                        {
                            b.Botao.BackColor = Color.GreenYellow;
                            ++totalBilhe;
                        }
                    }
                }

                labelBilheteContar.Text = "Total de bilhetes vendidos: " + string.Format("{0:000}", totalBilhe) + "/" + "Arrecadado: " + string.Format("{0:C2}", totalBilhe * infoSort.sorteiobilhetevalor);
            }
        }

        private void NumSorteio(int n)
        {
            flowLayoutPanelBilhete.Controls.Clear();
            for (int i = 0; i < n; i++)
            {
                UserControlBilhete b = new UserControlBilhete();
                b.Texto = (i + 1).ToString();
                b.Nome = "_" + (i + 1).ToString();
                b.Enabled = false;
                flowLayoutPanelBilhete.Controls.Add(b);
            }
        }

        public void Sortear(UserControlProd prod)
        {
            using (FormNumSorteio formNumSorteio = new FormNumSorteio(prod, infoSort))
            {
                formNumSorteio.ShowDialog(this);
            }
        }

        private void buttonSortear_Click(object sender, EventArgs e)
        {
            using (FormNumSorteio formNumSorteio = new FormNumSorteio(infoSort, colItem, colBilhete))
            {
                formNumSorteio.ShowDialog(this);
            }
        }
    }
}
