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

        }

        private void buttonSortear_Click(object sender, EventArgs e)
        {
                flowLayoutPanelBilhete.Controls.Clear();
                NumSorteio(infoSort.sorteiobilhetequant, true);

            //gera uma lista de numeros sorteados baseado na quantidade de prêmios
            List<int> num = Aleatorio.Gerar(infoSort.sorteiobilhetequant + 1, colItens.Sum(i => i.Quant));

            //gera uma lista de número não repetido baseado na quantidade produto
            List<int> num2 = Aleatorio.Gerar(colItens.Sum(i => i.Quant) + 1, colItens.Sum(i => i.Quant));
            List<ProdutoInfo> lProd = new List<ProdutoInfo>();

            //adiciona os prêmios retidas vezes baseado na quantidade do mesmo
            foreach (var item in colItens)
                for (int i = 0; i < item.Quant; i++)
                    lProd.Add(item.Prod);

            int cont = 0;
            for (int i = 0; i < num.Count; i++)
            {
                foreach (var item in flowLayoutPanelBilhete.Controls)
                {
                    UserControlBilhete b = (UserControlBilhete)item;

                    if (Convert.ToInt32(b.Botao.Text) == num[i])
                    {
                        SorteadoInfo s = new SorteadoInfo
                        {
                            Prod = lProd[num2[cont++] - 1], //seleciona o prêmio de forma aleatória e vincula a um sorteado
                            Bilhete = colBilhete.Where(w => w.bilhetenum == num[i]).FirstOrDefault(),
                        };

                        b.Sorteado(s);
                        b.Botao.BackColor = Color.Blue;
                        b.Botao.ForeColor = Color.Blue;
                    }
                }
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
                        //b.Botao.BackColor = Color.Blue;
                        b.Botao.ForeColor = Color.Black;
                    }

                }
            }
            
        }
    }
}
