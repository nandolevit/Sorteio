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
using System.IO;

namespace Sorteio
{
    public partial class UserControlProdDescricao : UserControl
    {
        public ProdutoInfo Prod { get; set; }
        public UserControlProdDescricao()
        {
            InitializeComponent();
        }

        private void UserControlProdDescricao_Load(object sender, EventArgs e)
        {
            labelDescricao.Text += Environment.NewLine + Prod.produtodescricao;
            labelValor.Text = string.Format("{0:C2}", Prod.produtovalor);
            MemoryStream m = new MemoryStream(Prod.produtofoto);
            pictureBox1.Image = Image.FromStream(m);
        }

        private void UserControlProdDescricao_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void UserControlProdDescricao_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            labelDescricao.Font = new Font(labelDescricao.Font, FontStyle.Regular);
        }

        private void UserControlProdDescricao_Click(object sender, EventArgs e)
        {
            using(FormDescricao descricao = new FormDescricao(enumTexto.num, "Quantidade:"))
            {
                if (descricao.ShowDialog(this) == DialogResult.Yes)
                {
                    FlowLayoutPanel panel = (FlowLayoutPanel)this.Parent;
                    SorteioAdd frm1 = (SorteioAdd)Application.OpenForms["SorteioAdd"];

                    if (frm1 != null)
                    {
                        foreach (var item in panel.Controls)
                        {
                            var desc = (UserControlProdDescricao)item;
                            if (desc.BackColor == Color.GreenYellow && desc.Enabled)
                            {
                                UserControlProd p = new UserControlProd();
                                p.Produto = desc.Prod;
                                p.Quant = Convert.ToInt32(descricao.Descricao);
                                frm1.PreencherProd(p);
                                break;
                            }
                        }
                        Balloon();
                        this.Enabled = false;
                    }

                    this.BackColor = Color.GreenYellow;
                    labelDescricao.Font = new Font(labelDescricao.Font, FontStyle.Bold);
                }
            }

        }

        private void Balloon()
        {
            toolTip1 = new ToolTip();
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Informação";
            toolTip1.Show("Produto adicionado a sua lista!", labelDescricao, 5000);
        }
    }
}
