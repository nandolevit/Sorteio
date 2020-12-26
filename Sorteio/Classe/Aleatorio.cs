using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Object;
using Business;

namespace Sorteio.Classe
{
    public static class Aleatorio
    {
        static Random rnd = new Random();


        public static List<int> Gerar(int nMax, int total)
        {
            List<int> num = new List<int>();

            for (int i = 0; i < total; i++)
            {
                int num2;
                do
                {
                    num2 = rnd.Next(1, nMax);
                } while (num.Contains(num2));


                num.Add(num2);
            }

            return num;
        }


        static public Control[] NumSorteio()
        {
            Control[] listBilhete = new Control[1000];
            for (int i = 0; i < 1000; i++)
            {
                UserControlBilhete b = new UserControlBilhete();
                b.Texto = (i + 1).ToString();
                b.Nome = "_" + (i + 1).ToString();
                //b.Enabled = false;
                listBilhete[i] = b;
            }

            return listBilhete;
        }

        static public void BilheteAleatorio()
        {
            SorteioNegocio negSort = new SorteioNegocio();
            BilheteColecao colB = (BilheteColecao)negSort.ExecutarBilhete(enumCRUD.select, new BilheteInfo { bilheteidsorteio = new SorteioInfo { sorteioid = 1 }, bilheteidconcorrente = new ConcorrenteInfo(), bilheteidvendedor = new ConcorrenteInfo() });
            StringBuilder txt = new StringBuilder();
            List<int> l = Gerar(colB.Count + 1, colB.Count);

            txt.Append("LISTA DOS CONCORRENTES DO " + colB.First().bilheteidsorteio.sorteiodescricao);
            txt.AppendLine();

            for (int i = 0; i < l.Count; i++)
            {
                BilheteInfo b = colB[i];
                b.bilhetenum = l[i];

                negSort.ExecutarBilhete(enumCRUD.update, b);

                txt.Append("Bilhete: " + string.Format("{0:000}", b.bilhetenum) + "; " + "Concorrente: " + b.bilheteidconcorrente.concorrentenome + "; Vendedor: " + b.bilheteidvendedor.concorrentenome);
                txt.AppendLine();
            }

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            FileInfo f = new FileInfo(path + "listaconcorrente.txt");

            if (f.Exists)
                f.Delete();

            using (StreamWriter sw = f.AppendText())
            {
                sw.WriteLine();
            }
            FormMessage.ShowMessageSave();
        }

    }
}
