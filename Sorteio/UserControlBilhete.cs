using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Object;

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

        SorteadoInfo infoS;

        public UserControlBilhete(SorteadoInfo info)
        {
            Inicializar();
            infoS = info;
        }

        public UserControlBilhete()
        {
            Inicializar();
        }

        private void Inicializar()
        {
            InitializeComponent();
            Cor = button1.BackColor;
            Fonte = button1.Font;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (infoS == null)
                formatBotao();
            else
            {
                if (button1.BackColor == Color.Blue)
                {
                    formatBotao();
                    FormNumSorteio frm = (FormNumSorteio)this.Parent.Parent;
                    frm.RevelarNum();
                }
                else if (button1.BackColor == Color.GreenYellow || button1.BackColor == Color.Gray)
                {
                    FormMessage.ShowMessegeWarning("Prêmio: " + infoS.Prod.produtodescricao + "Ganhador: " + infoS.Bilhete.bilheteidconcorrente.concorrentenome);
                    button1.BackColor = Color.Gray;
                }
            }

            Botao = button1;
        }

        private void formatBotao()
        {
            if (button1.BackColor == Color.GreenYellow)
            {
                button1.BackColor = Cor;
                button1.Font = Fonte;
            }
            else
            {
                button1.BackColor = Color.GreenYellow;
                button1.Font = new Font(button1.Font, FontStyle.Bold);
            }
        }

        private void UserControlBilhete_Load(object sender, EventArgs e)
        {
            button1.Name += Nome;
            button1.Text = Texto;

            Botao = button1;
        }

        public void MudarCorBotao(Color back, Color fore)
        {
            button1.BackColor = back;
            button1.ForeColor = fore;
        }

        public void Sorteado(SorteadoInfo sorteado)
        {
            infoS = sorteado;
        }
    }
}
