using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorteio
{
    public partial class UserControlBilhete : UserControl
    {
        public string Texto { get; set; }
        public string Nome { get; set; }
        //public bool Ativo { get; set; }
        public Button Botao { get; set; }
        private Color Cor { get; set; }
        private Font Fonte { get; set; }

        public UserControlBilhete()
        {
            InitializeComponent();
            Cor = button1.BackColor;
            Fonte = button1.Font;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.Green)
            {
                button1.BackColor = Cor;
                button1.Font = Fonte;
                button1.ForeColor = Color.Black;
                //Ativo = false;
            }
            else
            {
                button1.BackColor = Color.Green;
                button1.Font = new Font(button1.Font, FontStyle.Bold);
                button1.ForeColor = Color.White;
                //Ativo = true;
            }

            Botao = button1;
        }

        private void UserControlBilhete_Load(object sender, EventArgs e)
        {
            button1.Name += Nome;
            button1.Text = Texto;

            Botao = button1;
        }
    }
}
