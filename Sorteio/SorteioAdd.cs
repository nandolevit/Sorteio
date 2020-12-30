using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Object;
using Business;
using Sorteio.Classe;

namespace Sorteio
{
    public partial class SorteioAdd : Form
    {
        UserControlProd useProd;
        ProdutoInfo infoProd;
        SorteioInfo infoSort;
        SorteioNegocio negSort;
        ConcorrenteColecao colConcorrente;
        BilheteColecao colB;
        List<UserControlProd> listProdAdd = new List<UserControlProd>();
        List<UserControlProd> listProdAlt = new List<UserControlProd>();
        List<UserControlProd> listProdRem = new List<UserControlProd>();

        public SorteioAdd()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
        }

        private void SorteioAdd_Load(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 1000;
        }

        public void PreencherProd(UserControlProd p)
        {
            bool b = true;
            UserControlProd p1 = new UserControlProd();

            foreach (var item in this.flowLayoutPanelProd.Controls)
            {
                p1 = (UserControlProd)item;

                if (p1.Produto.produtoid == p.Produto.produtoid)
                {
                    b = false;
                    if (FormMessage.ShowMessegeQuestion("Este Prêmio já foi adicionado a lista! Deseja " + (p.Quant > 0 ? "acrescentar mais " : "REMOVER ") + Environment.NewLine +
                        string.Format("{0:00}", Math.Abs(p.Quant)) + (Math.Abs(p.Quant) > 1 ? " UNIDADES" : " UNIDADE") + "?") == DialogResult.Yes)
                    {
                        p1.AlterarQuant(p.Quant);
                        listProdAlt.Add(p1);
                    }

                    break;
                }
            }

            if (b)
            {
                this.flowLayoutPanelProd.Controls.Add(p);
                this.listProdAdd.Add(p);
                this.buttonSalvar.Enabled = true;
                this.buttonRemover.Enabled = true;
            }

            ContarItens();
        }

        private void buttonPict_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            using (FormProduto formProduto = new FormProduto())
            {
                formProduto.ShowDialog(this);
            }
            this.Cursor = Cursors.Default;
        }


        private void Salvar()
        {
            this.Cursor = Cursors.WaitCursor;
            if (string.IsNullOrEmpty(textBoxDescricaoSort.Text))
            {
                MessageBox.Show("Defina uma descrição para o sorteio!");
                textBoxDescricaoSort.Select();
                return;
            }

            int id;
            negSort = new SorteioNegocio();

            if (infoSort == null)
            {
                infoSort = new SorteioInfo
                {
                    sorteiodata = dateTimePicker1.Value,
                    sorteiodescricao = textBoxDescricaoSort.Text,
                    sorteiobilhetequant = Convert.ToInt32(numericUpDown1.Value),
                    sorteiobilhetevalor = Convert.ToDecimal(textBoxValor.Text)
                };

                id = (int)negSort.ExecutarSorteio(enumCRUD.insert, infoSort);

                if (id > 0)
                {
                    infoSort.sorteioid = id;
                    if (flowLayoutPanelProd.Controls.Count > 0)
                    {
                        foreach (Control item in flowLayoutPanelProd.Controls)
                        {
                            UserControlProd uProd = (UserControlProd)item;
                            SorteioItemInfo it = new SorteioItemInfo
                            {
                                Prod = uProd.Produto,
                                Quant = uProd.Quant,
                                Sort = infoSort
                            };
                            negSort.ExecutarSorteioItem(enumCRUD.insert, it);
                        }

                        FormMessage.ShowMessageSave();

                        if (this.Modal)
                            this.DialogResult = DialogResult.Yes;
                        else
                            this.Close();
                    }
                    else
                        MessageBox.Show("Nenhum produto foi lançado!");
                }
                else
                    FormMessage.ShowMessageFalha();
            }
            else
            {
                id = infoSort.sorteioid;

                infoSort = new SorteioInfo
                {
                    sorteiodata = dateTimePicker1.Value,
                    sorteiodescricao = textBoxDescricaoSort.Text,
                    sorteiobilhetequant = Convert.ToInt32(numericUpDown1.Value),
                    sorteiobilhetevalor = Convert.ToDecimal(textBoxValor.Text),
                    sorteioid = id
                };

                negSort.ExecutarSorteio(enumCRUD.update, infoSort);

                ExProd(listProdRem, enumCRUD.delete);
                ExProd(listProdAdd, enumCRUD.insert);
                ExProd(listProdAlt, enumCRUD.update);


                this.Cursor = Cursors.Default;
                FormMessage.ShowMessageSave();
            }
        }

        private void ExProd(List<UserControlProd> l, enumCRUD e)
        {
            if (l.Count > 0)
            {
                foreach (var item in l)
                {
                    UserControlProd uProd = item;
                    SorteioItemInfo it = new SorteioItemInfo
                    {
                        Prod = uProd.Produto,
                        Quant = uProd.Quant,
                        Sort = infoSort
                    };

                    negSort.ExecutarSorteioItem(e, it);
                }

                l.Clear();
            }
        }

        private void buttonPict_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonPict_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            int n = 0;
            List<UserControlProd> l = new List<UserControlProd>();

            foreach (var item in flowLayoutPanelProd.Controls)
            {
                UserControlProd prod = (UserControlProd)item;

                if (prod.BackColor == Color.Gray)
                {
                    l.Add(prod);
                    ++n;
                }
            }

            if (n == 0)
                FormMessage.ShowMessegeWarning("Selecione um produto para que seja removido!");
            else
            {
                for (int i = 0; i < l.Count; i++)
                {
                    flowLayoutPanelProd.Controls.Remove(l[i]);
                    listProdRem.Add(l[i]);
                }
            }

            ContarItens();
        }

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {
            FormTextoFormat.MoedaFormat(sender);
        }

        private void textBoxQuant_TextChanged(object sender, EventArgs e)
        {
            FormTextoFormat.NumericTexto(sender, 2);
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBoxDescricaoSort.Text) && flowLayoutPanelProd.Controls.Count > 0)
            {
                if (FormMessage.ShowMessegeQuestion("Deseja salvar?") == DialogResult.Yes)
                    Salvar();
            }
            else
            {
                FormMessage.ShowMessegeWarning("Insira uma descrição para o sorteio e adicione no mínimo um produto para salvar!");
                textBoxDescricaoSort.Select();
            }

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
                        this.Cursor = Cursors.WaitCursor;
                        infoSort = (SorteioInfo)consult.Selecionado.Objeto;
                        textBoxDescricaoSort.Text = consult.Selecionado.Descricao;
                        dateTimePicker1.Value = infoSort.sorteiodata;
                        numericUpDown1.Value = infoSort.sorteiobilhetequant;
                        textBoxValor.Text = Convert.ToString(infoSort.sorteiobilhetevalor);

                        flowLayoutPanelProd.Controls.Clear();
                        SorteioItemInfo i = new SorteioItemInfo { Sort = infoSort, Prod = new ProdutoInfo() };
                        SorteioItemColecao colItem = (SorteioItemColecao)negSort.ExecutarSorteioItem(enumCRUD.select, i);

                        if (colItem != null)
                        {
                            foreach (var item in colItem)
                            {
                                UserControlProd prod = new UserControlProd
                                {
                                    Produto = item.Prod,
                                    Quant = item.Quant
                                };

                                flowLayoutPanelProd.Controls.Add(prod);
                            }

                            ContarItens();
                        }

                        
                        PreencherTree();
                        buttonSalvar.Enabled = true;
                        buttonRemover.Enabled = true;
                        this.Cursor = Cursors.Default;
                    }
                }
            }

        }

        private void PreencherTree()
        {
            ConcorrenteNegocio neg = new ConcorrenteNegocio();
            ConcorrenteColecao colecao = (ConcorrenteColecao)neg.ExecutarConcorrente(enumCRUD.select, null, true);
            BilheteInfo b = new BilheteInfo { bilheteidconcorrente = new ConcorrenteInfo(), bilheteidsorteio = infoSort, bilheteidvendedor = new ConcorrenteInfo() };
            colB = (BilheteColecao)negSort.ExecutarBilhete(enumCRUD.select, b);

            if (colB != null)
            {
                colConcorrente = new ConcorrenteColecao();
                foreach (var item in colB)
                {
                    var cc = colConcorrente.Where(c => c.concorrenteid == item.bilheteidconcorrente.concorrenteid).FirstOrDefault();

                    if (cc == null)
                        colConcorrente.Add(item.bilheteidconcorrente);
                }
            }

            treeView1.Nodes.Clear();
            int num = 0;
            if (colecao != null)
            {
                foreach (var item in colecao.OrderBy(o => o.concorrentenome))
                {
                    num++;
                    int num1 = 0;
                    int totalBilhete = colB.Where(w => w.bilheteidvendedor.concorrenteid == item.concorrenteid).Count();

                    //adiciona os nomes dos vendedores
                    treeView1.Nodes.Add(item.concorrentenome);
                    if (totalBilhete > 0)
                    {
                        //adiciona 2 nós com soma total de bilhete vendidos e o valor total
                        treeView1.Nodes[num - 1].Nodes.Add(" - Total de Bilhetes Vendidos: " + string.Format("{0:000}", totalBilhete));
                        treeView1.Nodes[num - 1].Nodes[0].Nodes.Add(" - Valor Total Vendidos: " + string.Format("{0:C2}", totalBilhete * infoSort.sorteiobilhetevalor));
                    }

                    BilheteColecao bc = new BilheteColecao();
                    foreach (var item1 in colB.Where(w => w.bilheteidvendedor.concorrenteid == item.concorrenteid).OrderBy(o => o.bilheteidconcorrente.concorrentenome))
                    {
                        if (bc.Where(w => w.bilheteidconcorrente.concorrenteid == item1.bilheteidconcorrente.concorrenteid).FirstOrDefault() == null)
                        {
                            num1++;
                            bc.Add(item1);
                            int totalBilhete2 = colB.Where(w => w.bilheteidconcorrente.concorrenteid == item1.bilheteidconcorrente.concorrenteid && w.bilheteidvendedor.concorrenteid == item.concorrenteid).Count();

                            //adiciona os nomes dos compradores
                            treeView1.Nodes[num - 1].Nodes[0].Nodes[0].Nodes.Add(item1.bilheteidconcorrente.concorrentenome);
                            if (totalBilhete2 > 0)
                            {
                                treeView1.Nodes[num - 1].Nodes[0].Nodes[0].Nodes[num1 - 1].Nodes.Add(" - Total de Bilhetes Comprados: " + string.Format("{0:000}", totalBilhete2));
                                treeView1.Nodes[num - 1].Nodes[0].Nodes[0].Nodes[num1 - 1].Nodes[0].Nodes.Add(" - Valor Total Comprados: " + string.Format("{0:C2}", totalBilhete2 * infoSort.sorteiobilhetevalor));
                            }
                        }
                    }
                }

                int total = colB.Count();
                if (total > 0)
                {
                    //adiciona os valores gerais
                    treeView1.Nodes.Add("TOTAL GERAL**").NodeFont = new Font(treeView1.Font, FontStyle.Bold);
                    treeView1.Nodes[num].ForeColor = Color.Maroon;
                    //adiciona 2 nós com soma total de bilhete vendidos e o valor total
                    treeView1.Nodes[num].Nodes.Add(" - Total de Bilhetes Vendidos: " + string.Format("{0:000}", total)).ForeColor = Color.Maroon;
                    treeView1.Nodes[num].Nodes[0].Nodes.Add(" - Valor Total Vendidos: " + string.Format("{0:C2}", total * infoSort.sorteiobilhetevalor)).ForeColor = Color.Maroon;
                    treeView1.Nodes[num].Expand();
                    treeView1.Nodes[num].Nodes[0].Expand();
                    treeView1.Nodes[num].Nodes[0].Nodes[0].Expand();

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
        }

        private void textBoxValor_TextChanged_1(object sender, EventArgs e)
        {
            FormTextoFormat.MoedaFormat(sender);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
