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
using Business;

namespace Sorteio
{
    public partial class FormConcorrente : Form
    {
        int id = 0;
        SorteioNegocio negSort;
        ConcorrenteNegocio negCon;
        SorteioInfo infoSort;
        ConcorrenteInfo infoConc;
        ConcorrenteInfo infoVend;

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
            SorteioColecao colSort = (SorteioColecao)negSort.ExecutarSorteio(enumCRUD.select);

            var colecao = new Form_ConsultarColecao();
            foreach (var item in colSort)
            {
                Form_Consultar form = new Form_Consultar
                {
                    Cod = string.Format("{0:00000}", item.sorteioid),
                    Descricao = item.sorteiodescricao,
                    Objeto = item,
                };

                colecao.Add(form);
            }

            using (FormConsultar_Cod_Descricao consult = new FormConsultar_Cod_Descricao(colecao, "SORTEIO"))
            {
                if (consult.ShowDialog(this) == DialogResult.Yes)
                {
                    textBoxIdSort.Text = consult.Selecionado.Cod;
                    textBoxDescricaoSort.Text = consult.Selecionado.Descricao;
                    infoSort = (SorteioInfo)consult.Selecionado.Objeto;
                    ListaBilhete();
                }
            }

        }

        private void ListaBilhete()
        {

            NumSorteio(infoSort.sorteiobilhetequant);
            BilheteSelecionado();
            groupBoxNum.Enabled = true;
            buttonSelecionar.Enabled = true;
            buttonLimpar.Enabled = true;
            buttonSalvar.Enabled = true;
        }

        private void BilheteSelecionado()
        {
            negSort = new SorteioNegocio();
            BilheteInfo b3 = new BilheteInfo { bilheteidconcorrente = new ConcorrenteInfo(), bilheteidsorteio = infoSort, bilheteidVendedor = new ConcorrenteInfo() };
            BilheteColecao colecao = (BilheteColecao)negSort.ExecutarBilhete(enumCRUD.select, b3);

            if (colecao != null)
            {
                foreach (var bi in colecao)
                {
                    foreach (var bu in flowLayoutPanel1.Controls)
                    {
                        UserControlBilhete b = (UserControlBilhete)bu;

                        BilheteInfo info = colecao.Where(b1 => b1.bilheteidconcorrente.concorrenteid == infoConc.concorrenteid)
                            .Where(b2 => b2.bilhetenum == Convert.ToInt32(b.Texto)).FirstOrDefault();

                        if (info != null)
                        {
                            b.Botao.BackColor = Color.Green;
                            b.Botao.Font = new Font(b.Font, FontStyle.Bold);
                            b.Botao.ForeColor = Color.White;
                        }

                        if (bi.bilhetenum == Convert.ToInt32(b.Texto))
                        {
                            if (b.Botao.BackColor != Color.Green)
                            {
                                b.Enabled = false;
                                break;
                            }
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
            if (string.IsNullOrEmpty(textBoxNome.Text) || string.IsNullOrEmpty(textBoxIdSort.Text) || string.IsNullOrEmpty(textBoxVendCod.Text))
            {
                if (string.IsNullOrEmpty(textBoxNome.Text))
                {
                    FormMessage.ShowMessegeWarning("Selecione o concorrente!");
                    button1.Select();
                    return;
                }

                if (string.IsNullOrEmpty(textBoxIdSort.Text))
                {
                    FormMessage.ShowMessegeWarning("Selecione um sorteio!");
                    buttonSort.Select();
                    return;
                }

                if (string.IsNullOrEmpty(textBoxVendCod.Text))
                {
                    FormMessage.ShowMessegeWarning("Selecione o vendedor!");
                    buttonVendBuscar.Select();
                    return;
                }
            }

            if (FormMessage.ShowMessegeQuestion("Salvar?") == DialogResult.Yes)
            {
                int id = 0;
                BilheteInfo b1 = new BilheteInfo { bilheteidconcorrente = infoConc, bilheteidsorteio = infoSort };
                negSort.ExecutarBilhete(enumCRUD.delete, b1);
                foreach (var item in flowLayoutPanel1.Controls)
                {
                    UserControlBilhete bi = (UserControlBilhete)item;

                    if (bi.Botao.BackColor == Color.Green)
                    {
                        BilheteInfo b = new BilheteInfo
                        {
                            bilheteidconcorrente = infoConc,
                            bilheteidsorteio = infoSort,
                            bilheteidVendedor = infoVend,
                            bilhetenum = Convert.ToInt32(bi.Botao.Text)
                        };
                        id = (int)negSort.ExecutarBilhete(enumCRUD.insert, b);
                    }
                }

                if (id > 0)
                {
                    FormMessage.ShowMessageSave();
                    Limpar();
                }
                else
                    FormMessage.ShowMessegeWarning("Nenhum bilhete selecionado!");
            }
        }

        private void Limpar()
        {
            maskedTextBoxCpf.Text = string.Empty;
            textBoxNome.Clear();
            textBoxEmail.Text = "sem@email.com";
            maskedTextBoxTel.Text = string.Empty;
            textBoxVendCod.Clear();
            textBoxVendNome.Clear();
            textBoxDescricaoSort.Clear();
            textBoxIdSort.Clear();
            flowLayoutPanel1.Controls.Clear();
            numericUpDown1.Value = 1;
            //groupBoxNome.Enabled = true;
            //groupBoxNum.Enabled = false;
            //groupBoxSorteio.Enabled = false;
            //groupBoxVendedor.Enabled = false;
            maskedTextBoxCpf.Select();
        }

        private void FormConcorrente_Load(object sender, EventArgs e)
        {

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            NumSorteio(infoSort.sorteiobilhetequant);
            BilheteSelecionado();
        }

        private void buttonVendAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonVendBuscar_Click(object sender, EventArgs e)
        {

            using (FormVendedor formVendedor = new FormVendedor(true))
            {
                if (formVendedor.ShowDialog(this) == DialogResult.Yes)
                {
                    infoVend = formVendedor.infoConc;
                    textBoxVendCod.Text = string.Format("{0:0000}", infoVend.concorrenteid);
                    textBoxVendNome.Text = infoVend.concorrentenome;
                }
            }
        }

        private void maskedTextBoxCpf_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maskedTextBoxCpf.Text))
            {
                if (maskedTextBoxCpf.Text.Length == 11)
                {
                    ValidarCpfCnpj cpf = new ValidarCpfCnpj(maskedTextBoxCpf.Text);
                    if (cpf.CpfCpnjValido())
                    {
                        negCon = new ConcorrenteNegocio();
                        ConcorrenteInfo c = new ConcorrenteInfo { concorrentecpf = maskedTextBoxCpf.Text };
                        infoConc = (ConcorrenteInfo)negCon.ExecutarConcorrente(enumCRUD.select, c);
                        if (infoConc != null)
                        {
                            textBoxNome.Text = infoConc.concorrentenome;
                            textBoxEmail.Text = infoConc.concorrenteemail;
                            maskedTextBoxTel.Text = infoConc.concorrentetelefone;
                            groupBoxVendedor.Enabled = true;
                            groupBoxSorteio.Enabled = true;
                            groupBoxNum.Enabled = true;
                            groupBoxNome.Enabled = false;
                        }
                    }
                    else
                        maskedTextBoxCpf.Text = string.Empty;
                }
                else
                    maskedTextBoxCpf.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FormVendedor formVendedor = new FormVendedor(false))
            {
                if (formVendedor.ShowDialog(this) == DialogResult.Yes)
                {
                    infoConc = formVendedor.infoConc;
                    maskedTextBoxCpf.Text = infoConc.concorrentecpf;
                    textBoxNome.Text = infoConc.concorrentenome;
                    textBoxEmail.Text = infoConc.concorrenteemail;
                    maskedTextBoxTel.Text = infoConc.concorrentetelefone;
                    buttonSort.Enabled = true;

                    if (!string.IsNullOrEmpty(textBoxIdSort.Text))
                        ListaBilhete();
                }
            }
        }
    }
}
