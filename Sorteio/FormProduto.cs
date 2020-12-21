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
    public partial class FormProduto : Form
    {
        public int Quant { get; set; }
        SorteioNegocio negSort;
        ProdutoInfo infoProd;
        public FormProduto()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
        }

        private void buttonPict_Click(object sender, EventArgs e)
        {
            PreencherProd();
        }

        private void PreencherProd()
        {

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
                        pictureBox1.Image = Image.FromStream(open.OpenFile());
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

        private void FormProduto_Load(object sender, EventArgs e)
        {
            PreencherLista();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //UserControlProdDescricao prod = new UserControlProdDescricao();
            infoProd = new ProdutoInfo
            {
                produtodescricao = textBoxDescricaoProd.Text,
                produtofoto = ConvertImagem(pictureBox1.Image),
                produtovalor = Convert.ToDecimal(textBoxValor.Text)
            };

            negSort = new SorteioNegocio();
            negSort.InsertProduto(infoProd);

            PreencherLista();
            pictureBox1.Image = Properties.Resources.eletro;
            textBoxDescricaoProd.Clear();
            textBoxDescricaoProd.Select();
            textBoxValor.Text = "1,00";
        }

        private void PreencherLista()
        {
            negSort = new SorteioNegocio();
            ProdutoColecao colProd = negSort.ConsultarProduto();
            flowLayoutPanel1.Controls.Clear();

            if (colProd != null)
            {
                foreach (var item in colProd)
                {
                    UserControlProdDescricao prod = new UserControlProdDescricao
                    {
                        Prod = item
                    };

                    flowLayoutPanel1.Controls.Add(prod);
                }
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

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {
            FormTextoFormat.MoedaFormat(sender);
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void Selecionar()
        {
            this.DialogResult = DialogResult.Yes;
        }
    }
}
