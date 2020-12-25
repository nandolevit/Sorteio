using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Sorteio.Classe;
using System.IO;
using Object;
using Business;

namespace Sorteio
{
    public partial class FormNumSorteio : Form
    {
        UserControlProd UserProd;
        SorteioInfo infoSort;
        SorteioItemColecao colItens;
        BilheteColecao colBilhete;
        ConcorrenteColecao colVenderdor;
        SorteadoColecao colSorteado;

        SorteioNegocio negSort;
        ConcorrenteNegocio negConc;

        public FormNumSorteio(SorteioInfo sort, SorteioItemColecao item, BilheteColecao bilhete)
        {
            Inicializar();
            infoSort = sort;
            colItens = item;
            colBilhete = bilhete;
        }

        public FormNumSorteio(UserControlProd user, SorteioInfo sort)
        {
            Inicializar();
            this.UserProd = user;
            infoSort = sort;
        }

        private void Inicializar()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void NumSorteio(int n, bool limp = false)
        {
            flowLayoutPanelBilhete.Controls.Clear();
            for (int i = 0; i < n; i++)
            {
                SorteadoInfo bi = new SorteadoInfo();
                UserControlBilhete b = new UserControlBilhete(bi);
                b.Texto = (i + 1).ToString();
                b.Nome = "_" + (i + 1).ToString();

                if (limp)
                {
                    b.MudarCorBotao(Color.White, Color.White);
                }

                flowLayoutPanelBilhete.Controls.Add(b);
            }
        }

        private void FormNumSorteio_Load(object sender, EventArgs e)
        {
            NumSorteio(infoSort.sorteiobilhetequant);
            negConc = new ConcorrenteNegocio();
            colVenderdor = (ConcorrenteColecao)negConc.ExecutarConcorrente(enumCRUD.select, null, true);

        }

        private void buttonSortear_Click(object sender, EventArgs e)
        {

            flowLayoutPanelBilhete.Controls.Clear();
            NumSorteio(infoSort.sorteiobilhetequant, true);

            //gera uma lista de numeros sorteados baseado na quantidade de prêmios
            List<int> num = Aleatorio.Gerar(colBilhete.Count + 1, colItens.Sum(i => i.Quant));

            //gera uma lista de número não repetido baseado na quantidade produto
            List<int> num2 = Aleatorio.Gerar(colItens.Sum(i => i.Quant) + 1, colItens.Sum(i => i.Quant));
            List<ProdutoInfo> lProd = new List<ProdutoInfo>();

            //adiciona os prêmios retidas vezes baseado na quantidade do mesmo
            foreach (var item in colItens)
                for (int i = 0; i < item.Quant; i++)
                    lProd.Add(item.Prod);

            int cont = 0;
            colSorteado = new SorteadoColecao();
            for (int i = 0; i < num.Count; i++)
            {
                foreach (var item in flowLayoutPanelBilhete.Controls)
                {
                    UserControlBilhete b = (UserControlBilhete)item;

                    if (Convert.ToInt32(b.Botao.Text) == colBilhete[num[i] - 1].bilhetenum)
                    {
                        SorteadoInfo s = new SorteadoInfo
                        {
                            Prod = lProd[num2[cont++] - 1], //seleciona o prêmio de forma aleatória e vincula a um sorteado
                            Bilhete = colBilhete.Where(w => w.bilhetenum == colBilhete[num[i] - 1].bilhetenum).FirstOrDefault(),
                        };

                        s.Bilhete.bilheteidvendedor = colVenderdor.Where(w => w.concorrenteid == s.Bilhete.bilheteidvendedor.concorrenteid).FirstOrDefault();
                        colSorteado.Add(s);
                        b.Sorteado(s);
                        b.Botao.BackColor = Color.Blue;
                        b.Botao.ForeColor = Color.Blue;
                    }
                }
            }

            SalvarTxt();

        }

        private void SalvarTxt()
        {
            FileInfo f = new FileInfo(@"C:\Users\Public\ResultadoSorteio.txt");
            //f.Create();
            StringBuilder txt = new StringBuilder();
            txt.AppendLine("id;nome;bilhete;idprod;descricao");
            foreach (var item in colSorteado)
            {
                txt.Append(item.Bilhete.bilheteidconcorrente.concorrenteid + ";");
                txt.Append(item.Bilhete.bilheteidconcorrente.concorrentenome + ";");
                txt.Append(item.Bilhete.bilhetenum + ";");
                txt.Append(item.Prod.produtoid + ";");
                txt.Append(item.Prod.produtodescricao + ";");
                txt.AppendLine();
            }
            if (f.Exists)
                f.Delete();

            using( StreamWriter sw = f.AppendText())
            {
                sw.WriteLine(txt);
            }
        }

        public void RevelarNum()
        {
            int n = 0;
            foreach (var item in flowLayoutPanelBilhete.Controls)
            {
                UserControlBilhete b = (UserControlBilhete)item;

                if (b.Botao.BackColor == Color.Blue)
                    ++n;
            }

            if (n == 0)
            {
                foreach (var item in flowLayoutPanelBilhete.Controls)
                {
                    UserControlBilhete b = (UserControlBilhete)item; if (b.Botao.BackColor == Color.White)
                    {
                        b.Botao.ForeColor = Color.Black;
                    }
                }
            }

        }

        private void FormNumSorteio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o formulário e cancelar o sorteio?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
