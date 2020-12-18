using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Obejct;
using Business;

namespace Sorteio
{
    public partial class FormConcorrente : Form
    {
        int id = 0;
        SorteioNegocio negSort;
        ConcorrenteNegocio negCon;

        public FormConcorrente()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            negSort = new SorteioNegocio();
            SorteioInfo info = negSort.ConsultarSorteioId(1);
            textBoxDescricaoSort.Text = info.sorteiodescricao;
            textBoxIdSort.Text = Convert.ToString(info.sorteioid);
            NumSorteio(info.sorteioquant);
            BilheteSelecionado();
            groupBoxNum.Enabled = true;
            buttonSelecionar.Enabled = true;
        }

        private void BilheteSelecionado()
        {
            negSort = new SorteioNegocio();
            BilheteColecao colecao = negSort.ConsultarBilheteIdSorteio(1);

            if (colecao != null)
            {
                foreach (var bi in colecao)
                {
                    foreach (var bu in flowLayoutPanel1.Controls)
                    {
                        UserControlBilhete b = (UserControlBilhete)bu;

                        if (b.ForeColor == Color.Green)
                            break;

                        if (bi.bilhetenum == Convert.ToInt32(b.Texto))
                        {
                            b.Enabled = false;
                            break;
                        }

                    }
                }
            }
            
        }

        private void NumSorteio(int n)
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < n; i++)
            {
                UserControlBilhete b = new UserControlBilhete();
                b.Texto = (i + 1).ToString();
                b.Nome = "_" + (i + 1).ToString();

                //if (i % 2 == 0)
                //    b.Enabled = false;

                flowLayoutPanel1.Controls.Add(b);
            }
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

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
           
        }

        private void FormConcorrente_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(textBoxNome.Text) && string.IsNullOrEmpty(textBoxEmail.Text) && string.IsNullOrEmpty(maskedTextBoxTel.Text)))
            {
                negCon = new ConcorrenteNegocio();
                if (id == 0)
                {
                    ConcorrenteInfo con = new ConcorrenteInfo
                    {
                        concorrentecpf = maskedTextBoxCpf.Text,
                        concorrenteemail = textBoxEmail.Text,
                        concorrentenome = textBoxNome.Text,
                        concorrentetelefone = maskedTextBoxTel.Text
                    };

                    id = negCon.InsertConcorrente(con);
                }

                groupBoxVendedor.Enabled = true;
                groupBoxSorteio.Enabled = true;
                groupBoxNum.Enabled = true;
                groupBoxNome.Enabled = false;
            }
        }
    }
}
