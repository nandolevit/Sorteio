using System;
using System.Drawing;
using System.Windows.Forms;
using Obejct;

namespace Sorteio
{
    public partial class UserControlProd : UserControl
    {
        public ProdutoInfo Produto { get; set; }
        //public string Descricao { get; set; }
        //public int Quant { get; set; }
        //public decimal Valor { get; set; }
        public Image Foto { get; set; }

        public UserControlProd()
        {
            InitializeComponent();
        }

        private void UserControlProd_Load(object sender, EventArgs e)
        {
            labelDescricao.Text = Produto.produtodescricao;
            pictureBox1.Image = Foto;
            labelQuant.Text = string.Format("{0:00}", Produto.produtoquant);
        }

        private void UserControlProd_Click(object sender, EventArgs e)
        {
        }
    }
}
