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
            this.AcceptButton = buttonOK;
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
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (Txt != enumTexto.texto)
                {
                    if(Convert.ToInt32(textBox1.Text) == 0)
                    {
                        FormMessage.ShowMessegeWarning("Insira valores diferente de zero!");
                        textBox1.Clear();
                        textBox1.Select();
                        return;
                    }
                }

                Descricao = textBox1.Text;
                this.DialogResult = DialogResult.Yes;
            }
            else
                FormMessage.ShowMessegeWarning("Preencha o campo!");
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
