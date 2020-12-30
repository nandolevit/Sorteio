using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sorteio.Classe;
using Object;
using Business;

namespace Sorteio
{
    public partial class Form1 : Form
    {
        static public bool Online;
        SorteioAdd sort;

        static public ConcorrenteColecao colC;
        static public ConcorrenteColecao colV;
        static public BilheteColecao colB;
        static public ProdutoColecao colP;
        static public SorteioItemColecao colI;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Online = TestarConexao();

            if (Online)
            {
                SorteioNegocio neg = new SorteioNegocio();

                if (neg.ModoOffline())
                {
                    Online = false;

                    if (!Aleatorio.TodosArquivosExiste())
                        Aleatorio.Serial();
                }
                else if (neg.Active())
                    bancoSortearToolStripMenuItem.Visible = true;
            }

            if (!Online)
            {
                sorteioToolStripMenuItem.Enabled = false;
                Aleatorio.desSerial();
                FormMessage.ShowMessegeWarning("O sistema funcionará no MODO OFFLINE!");
            }
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

        private void sortearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bancoSortearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormMessage.ShowMessegeQuestion("Deseja embaralhar os bilhetes?") == DialogResult.Yes)
            {
                Aleatorio.BilheteAleatorio();
                Aleatorio.Serial();
            }

            Aleatorio.ListaVendedor(1);
            Aleatorio.ListaTxt();
        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private bool TestarConexao()
        {
            try
            {
                if (Dns.GetHostAddresses("empresadb.mysql.uhserver.com") != null)
                {
                    //IPAddress[] ip = Dns.GetHostAddresses("empresadb.mysql.uhserver.com");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void realizarSorteioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSortear formSortear = new FormSortear();
            formSortear.MdiParent = this;
            formSortear.Show();
        }

        private void listarVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
