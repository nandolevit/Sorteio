using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Object;

namespace Sorteio
{
    public partial class FormConsultar_Cod_Descricao : Form
    {

        private static DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        public Form_Consultar Selecionado { get; set; }
        Form_ConsultarColecao colecaoConsult;

        public FormConsultar_Cod_Descricao(Form_ConsultarColecao consultar, string titulo)
        {
            InitializeComponent();
            dataGridViewConsultar.AutoGenerateColumns = false;
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.Text = titulo;
            colecaoConsult = consultar;
            dataGridViewConsultar.DataSource = colecaoConsult;
            //ativa cor de linhas alternadas
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewConsultar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Selecionar()
        {
            if (dataGridViewConsultar.SelectedRows.Count > 0)
            {
                Selecionado = (Form_Consultar)dataGridViewConsultar.SelectedRows[0].DataBoundItem;
                DialogResult = DialogResult.Yes;
            }
            else
                FormMessage.ShowMessegeWarning("Selecione um item da lista!");
        }

        private void FormConsultar_Cod_Descricao_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                Selecionar();
                return;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void FormConsultar_Cod_Descricao_Load(object sender, EventArgs e)
        {

            textBoxDescricao.Select();
        }

        private void DataGridViewConsultar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
                Selecionar();
        }

        private void textBoxDescricao_TextChanged(object sender, EventArgs e)
        {
            var c = colecaoConsult.Where(w => FormTextoFormat.PalavraSemAcento(w.Descricao).ToUpper().Contains(textBoxDescricao.Text.ToUpper())).ToList();
            dataGridViewConsultar.DataSource = null;
            dataGridViewConsultar.DataSource = c;
        }

        private void dataGridViewConsultar_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            labelRegistro.Text = string.Format("{0:000}", dataGridViewConsultar.Rows.Count) +  " registros...";
        }
    }
}
