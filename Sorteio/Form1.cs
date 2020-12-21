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
    public partial class Form1 : Form
    {
        SorteioAdd sort;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //sort = new SorteioAdd();
            //sort.ShowDialog();
        }

        private void lancarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SorteioAdd sorteioAdd = new SorteioAdd();
            sorteioAdd.MdiParent = this;
            sorteioAdd.Show();
        }

        private void concorrenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConcorrente formConcorrente = new FormConcorrente();
            formConcorrente.MdiParent = this;
            formConcorrente.Show();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVendedor formVendedor = new FormVendedor(true);
            formVendedor.MdiParent = this;
            formVendedor.Show();
        }
    }
}
