using System;
using System.Drawing;
using System.Windows.Forms;
using Object;
using System.IO;

namespace Sorteio
{
    public partial class UserControlProd : UserControl
    {
        public ProdutoInfo Produto { get; set; }
        public int Quant { get; set; }

        public UserControlProd()
        {
            InitializeComponent();
        }

        private void UserControlProd_Load(object sender, EventArgs e)
        {
            MemoryStream m = new MemoryStream(Produto.produtofoto);
            labelDescricao.Text = Produto.produtodescricao;
            pictureBox1.Image = Image.FromStream(m);
            labelQuant.Text = string.Format("{0:00}", Quant);
        }

        private void UserControlProd_Click(object sender, EventArgs e)
        {

            if (this.BackColor == Color.Silver)
                this.BackColor = Color.White;
            else
                this.BackColor = Color.Silver;

        }
    }
}
