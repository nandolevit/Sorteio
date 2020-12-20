using System;
using System.Drawing;
using System.Windows.Forms;
using Obejct;
using System.IO;

namespace Sorteio
{
    public partial class UserControlProd : UserControl
    {
        public ProdutoInfo Produto { get; set; }

        public UserControlProd()
        {
            InitializeComponent();
        }

        private void UserControlProd_Load(object sender, EventArgs e)
        {
            MemoryStream m = new MemoryStream(Produto.produtofoto);
            labelDescricao.Text = Produto.produtodescricao;
            pictureBox1.Image = Image.FromStream(m);
            labelQuant.Text = string.Format("{0:00}", Produto.produtoquant);
        }

        private void UserControlProd_Click(object sender, EventArgs e)
        {
        }
    }
}
