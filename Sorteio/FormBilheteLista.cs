using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorteio
{
    public partial class FormBilheteLista : Form
    {
        public FormBilheteLista()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
        }

        private void FormBilheteLista_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                UserControlBilhete b = new UserControlBilhete();
                b.Texto = (i + 1).ToString();
                b.Nome = "_" + (i + 1).ToString();

                //if (i % 2 == 0)
                //    b.Enabled = false;

                flowLayoutPanel1.Controls.Add(b);
            }
        }

        private void Contar(object sender, EventArgs e)
        {
            int num = 0;
            foreach (Control item in flowLayoutPanel1.Controls)
            {
                UserControlBilhete userControl = (UserControlBilhete)item;

                if (userControl.Botao.Enabled)
                    num++;

            }

            MessageBox.Show("Total " + num);
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
                return;

            int num = 1;
            foreach (Control item in flowLayoutPanel1.Controls)
            {
                UserControlBilhete userControl = (UserControlBilhete)item;

                if (userControl.Botao.Enabled && userControl.Botao.BackColor != Color.Green)
                {
                    userControl.Botao.BackColor = Color.Green;
                    userControl.Botao.Font = new Font(userControl.Botao.Font, FontStyle.Bold);
                    userControl.Botao.ForeColor = Color.White;
                    num++;

                    if (num > numericUpDown1.Value)
                    {
                        numericUpDown1.Value = 0;
                        break;
                    }
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
