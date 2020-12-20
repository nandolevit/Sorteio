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
    public partial class FormVendedor : Form
    {
        int id = 0;
        //SorteioNegocio negSort;
        ConcorrenteNegocio negCon;
        public ConcorrenteInfo infoConc;
        ConcorrenteColecao colecao;

        public FormVendedor()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
        }

        private void FormVendedor_Load(object sender, EventArgs e)
        {
            negCon = new ConcorrenteNegocio();
            colecao = negCon.ConsultarVendedor();
            dataGridView1.DataSource = colecao;
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

                    id = negCon.InsertConcorrente(con, true);
                    con.concorrenteid = id;
                    infoConc = con;

                    if (this.Modal)
                    {
                        DialogResult = DialogResult.Yes;
                    }
                    else
                    {
                        negCon = new ConcorrenteNegocio();
                        colecao = negCon.ConsultarVendedor();
                        dataGridView1.DataSource = colecao;
                        buttonSave.Visible = false;
                        maskedTextBoxCpf.Text = string.Empty;
                        maskedTextBoxTel.Text = string.Empty;
                        textBoxNome.Clear();
                        textBoxEmail.Clear();
                        maskedTextBoxCpf.Select();
                    }
                }

            }
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            //ConcorrenteColecao conc = colecao;
            dataGridView1.DataSource = colecao.Where(c => c.concorrentenome.Contains(textBoxNome.Text)).ToList();

            if (dataGridView1.Rows.Count == 0)
            {
                buttonSave.Visible = true;
            }
            else
                buttonSave.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                infoConc = (ConcorrenteInfo)dataGridView1.SelectedRows[0].DataBoundItem;

                if (this.Modal)
                {
                    DialogResult = DialogResult.Yes;
                }
            }
        }
    }
}
