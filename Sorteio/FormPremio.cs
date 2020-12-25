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
using System.IO;

namespace Sorteio
{
    public partial class FormPremio : Form
    {
        SorteadoInfo infoSorteado;
        public FormPremio(SorteadoInfo info)
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.FormBorderStyle = FormBorderStyle.None;
            infoSorteado = info;
        }

        private void FormPremio_Load(object sender, EventArgs e)
        {
            labelProd.Text = infoSorteado.Prod.produtodescricao;
            MemoryStream m = new MemoryStream(infoSorteado.Prod.produtofoto);
            pictureBox1.Image = Image.FromStream(m);
            labelNum.Text = string.Format("{0:000}", infoSorteado.Bilhete.bilhetenum);
            labelConc.Text = infoSorteado.Bilhete.bilheteidconcorrente.concorrentenome;
            labelVend.Text = infoSorteado.Bilhete.bilheteidvendedor.concorrentenome;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
