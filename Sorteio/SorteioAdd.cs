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

namespace Sorteio
{
    public partial class SorteioAdd : Form
    {
        UserControlProd useProd;
        ProdutoInfo infoProd;
        SorteioInfo infoSort;
        SorteioNegocio negSort;
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
            this.flowLayoutPanelProd.Controls.Add(p);
            this.buttonSalvar.Enabled = true;
            this.buttonRemover.Enabled = true;
        }

        private void buttonPict_Click(object sender, EventArgs e)
        {
            using (FormProduto formProduto = new FormProduto())
            {
                formProduto.ShowDialog(this);
            }
        }


        private void Salvar()
        {
            if (string.IsNullOrEmpty(textBoxDescricaoSort.Text))
            {
                MessageBox.Show("Defina uma descrição para o sorteio!");
                textBoxDescricaoSort.Select();
                return;
            }

            int id;
            negSort = new SorteioNegocio();
            SorteioInfo sort = new SorteioInfo
            {
                sorteiodata = dateTimePicker1.Value,
                sorteiodescricao = textBoxDescricaoSort.Text,
                sorteiobilhetequant = Convert.ToInt32(numericUpDown1.Value),
                sorteiobilhetevalor = Convert.ToDecimal(textBoxValor.Text)
            };

            id = negSort.InsertSorteio(sort);

            if (id > 0)
            {
                sort.sorteioid = id;
                if (flowLayoutPanelProd.Controls.Count > 0)
                {
                    foreach (Control item in flowLayoutPanelProd.Controls)
                    {
                        UserControlProd uProd = (UserControlProd)item;
                        SorteioItemInfo it = new SorteioItemInfo
                        {
                            Prod = uProd.Produto,
                            Quant = uProd.Quant,
                            Sort = sort
                        };
                        negSort.InsertSorteioItem(it);
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

                if (prod.BackColor == Color.Silver)
                {
                    l.Add(prod);
                    ++n;
                }
            }

            if (n == 0)
                FormMessage.ShowMessegeWarning("Selecione um produto para que seja removido!");
            else
                for (int i = 0; i < l.Count; i++)
                    flowLayoutPanelProd.Controls.Remove(l[i]);

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
            SorteioColecao colSort = negSort.ConsultarSorteio();

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
                        SorteioItemColecao colItem = negSort.ConsultarItemIdSorteio(infoSort.sorteioid);

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
                        }
                    }
                }
            }
        }

        private void textBoxValor_TextChanged_1(object sender, EventArgs e)
        {
            FormTextoFormat.MoedaFormat(sender);
        }
    }
}
