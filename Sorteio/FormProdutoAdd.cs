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
    public partial class FormProdutoAdd : Form
    {
        SorteioNegocio negSort;
        ProdutoInfo infoProd;
        Image img;
        public FormProdutoAdd()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.FormBorderStyle = FormBorderStyle.None;
            buttonFechar.ForeColor = Color.White;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

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
                        try
                        {
                            img = Image.FromStream(open.OpenFile());
                            pictureBox1.Image = img;
                        }
                        catch (Exception)
                        {
                            FormMessage.ShowMessegeWarning("A imagem apresentou algum tipo de incompatibilidade, selecione outra!");
                            PreencherProd();
                        }
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                if (string.IsNullOrEmpty(textBoxDescricaoProd.Text))
                {
                    FormMessage.ShowMessegeWarning("Informe uma descrição para este prêmio!");
                    textBoxDescricaoProd.Select();
                    return;
                }

                infoProd = new ProdutoInfo
                {
                    produtodescricao = textBoxDescricaoProd.Text,
                    produtofoto = ConvertImagem(img),
                    produtovalor = Convert.ToDecimal(textBoxValor.Text)
                };

                negSort = new SorteioNegocio();
                negSort.ExecutarProduto(enumCRUD.insert, infoProd);
                FormMessage.ShowMessegeInfo("Prêmio lançado com sucesso!");

                pictureBox1.Image = Properties.Resources.portateis;
                textBoxDescricaoProd.Clear();
                textBoxDescricaoProd.Select();
                textBoxValor.Text = "1,00";

                FormProduto formProduto = (FormProduto)Application.OpenForms["FormProduto"];
                formProduto.PreencherLista();
            }
            else
                FormMessage.ShowMessegeWarning("Selecione uma imagem para este prêmio!");
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

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FormProdutoAdd_Load(object sender, EventArgs e)
        {

        }

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {
            FormTextoFormat.MoedaFormat(sender);
        }
    }
}
