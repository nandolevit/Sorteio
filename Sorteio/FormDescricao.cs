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
    public enum enumTexto
    {
        num,
        moeda,
        texto
    }

    public partial class FormDescricao : Form
    {
        public string Descricao { get; set; }
        enumTexto Txt;
        string Lab { get; set; }

        public FormDescricao(enumTexto txt, string lbl)
        {
            Inicializar();
            Txt = txt;
            Lab = lbl;
        }

        private void Inicializar()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
        }

        private void FormDescricao_Load(object sender, EventArgs e)
        {
            labelDesc.Text = Lab;

            switch (Txt)
            {
                case enumTexto.num:
                    textBox1.TextChanged += new EventHandler(numeric_Click);
                    break;
                case enumTexto.moeda:
                    textBox1.TextChanged += new EventHandler(moeda_Click);
                    break;
                case enumTexto.texto:
                    break;
                default:
                    break;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Descricao = textBox1.Text;
            this.DialogResult = DialogResult.Yes;
        }

        private void numeric_Click(object sender, EventArgs e)
        {
            FormTextoFormat.NumericTexto(sender);
        }

        private void moeda_Click(object sender, EventArgs e)
        {
            FormTextoFormat.MoedaFormat(sender);
        }
    }
}
