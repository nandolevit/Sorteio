using System;
using System.Drawing;
using System.Windows.Forms;
using Object;
using System.IO;

namespace Sorteio
{
    public partial class UserControlProd : UserControl
    {
        bool verd;
        public ProdutoInfo Produto { get; set; }
        public int Quant { get; set; }

        public UserControlProd(bool b)
        {
            InitializeComponent();
            verd = b;
        }

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

            if (verd)
                LimparFlow((FlowLayoutPanel)this.Parent);

            if (this.BackColor == Color.Silver)
                this.BackColor = Color.White;
            else
                this.BackColor = Color.Silver;

            if (verd)
            {
                FormSortear s = (FormSortear)this.Parent.Parent.Parent;
                s.Sortear(this);
            }
        }

        public void AlterarQuant(int n)
        {
            Quant += n;
            labelQuant.Text = string.Format("{0:00}", Quant);
        }

        private void LimparFlow(FlowLayoutPanel flow)
        {
            foreach (var item in flow.Controls)
            {
                UserControlProd b = (UserControlProd)item;
                b.BackColor = Color.White;
            }
        }
    }
}
