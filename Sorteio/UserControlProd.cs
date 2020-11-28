using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sorteio
{
    public partial class UserControlProd : UserControl
    {
        public string Descricao { get; set; }
        public int Quant { get; set; }
        public decimal Valor { get; set; }
        public Image Foto { get; set; }

        public UserControlProd()
        {
            InitializeComponent();
        }

        private void UserControlProd_Load(object sender, EventArgs e)
        {
            labelDescricao.Text = Descricao;
            pictureBox1.Image = Foto;
            labelQuant.Text = Quant.ToString();
        }

        private void UserControlProd_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void UserControlProd_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void UserControlProd_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Descricao);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
    }
}
