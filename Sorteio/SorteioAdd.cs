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
using Obejct;
using Business;

namespace Sorteio
{
    public partial class SorteioAdd : Form
    {
        UserControlProd prod;
        SorteioNegocio negSort;
        public SorteioAdd()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
        }

        private void SorteioAdd_Load(object sender, EventArgs e)
        {
            //PreencherProd();
            numericUpDown1.Maximum = 1000;
        }

        private void PreencherProd()
        {
            prod = new UserControlProd();

            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Title = "Selecionar uma foto...";
                open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                open.Filter = "Arquivos(*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                //open.RestoreDirectory = true;

                if (open.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(open.FileName);

                    if (file.Length < 50000)
                    {
                        prod.Produto = new ProdutoInfo();
                        prod.Produto.produtofoto = ConvertImagem(Image.FromStream(open.OpenFile()));
                        prod.Produto.produtodescricao = textBoxDescricaoProd.Text;
                        prod.Produto.produtoquant = Convert.ToInt32(textBoxQuant.Text);
                        prod.Produto.produtovalor = Convert.ToDecimal(textBoxValor.Text);
                        this.flowLayoutPanelProd.Controls.Add(prod);
                        textBoxDescricaoProd.Clear();
                        textBoxQuant.Text = "01";
                        textBoxValor.Text = "1,00";

                        if (!buttonRemover.Enabled)
                            buttonRemover.Enabled = true;

                        if (!buttonSalvar.Enabled)
                            buttonSalvar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Este arquivo possue mais de 50KB, a foto deve ser menor!");
                        PreencherProd();
                    }
                }
            }

            textBoxDescricaoProd.Select();
        }

        private void buttonPict_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxDescricaoProd.Text))
            {
                bool s = true;

                foreach (Control item in flowLayoutPanelProd.Controls)
                {
                    UserControlProd uProd = (UserControlProd)item;

                    if (textBoxDescricaoProd.Text.ToUpper().CompareTo(uProd.Produto.produtodescricao.ToUpper()) == 0)
                        s = false;
                }

                if (s)
                    PreencherProd();
                else
                {
                    MessageBox.Show("Este produto já foi adcionado, adicione outro!");
                    textBoxDescricaoProd.Clear();
                    textBoxDescricaoProd.Select();
                }
            }
            else
            {
                MessageBox.Show("Informe a descrição do produto antes...");
                textBoxDescricaoProd.Select();
            }
        }

        private byte[] ConvertImagem(Image img)
        {
            try
            {
                using (MemoryStream mStream = new MemoryStream())
                {
                    img.Save(mStream, img.RawFormat);
                    return mStream.ToArray();
                }
            }
            catch (Exception)
            {

                throw;
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
                sorteioquant = Convert.ToInt32(numericUpDown1.Value)
            };

            id = negSort.InsertSorteio(sort);

            if (id > 0)
            {
                if (flowLayoutPanelProd.Controls.Count > 0)
                {
                    foreach (Control item in flowLayoutPanelProd.Controls)
                    {
                        UserControlProd uProd = (UserControlProd)item;
                        uProd.Produto.produtoidsorteio = id;
                        negSort.InsertProduto(uProd.Produto);
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

            if (flowLayoutPanelProd.Controls.Count > 0)
                flowLayoutPanelProd.Controls.RemoveAt(flowLayoutPanelProd.Controls.Count - 1);
            else
            {
                buttonRemover.Enabled = false;
                buttonSalvar.Enabled = false;
            }
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
                Salvar();
            }
            else
            {
                FormMessage.ShowMessegeWarning("Insira uma descrição para o sorteio e adicione no mínimo um produto para salvar!");
                textBoxDescricaoSort.Select();
            }

        }
    }
}
