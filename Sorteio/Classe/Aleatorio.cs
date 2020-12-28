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
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\BancoSorteio\\";

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

            for (int i = 0; i < l.Count; i++)
            {
                BilheteInfo b = colB[i];
                b.bilhetenum = l[i];

                negSort.ExecutarBilhete(enumCRUD.update, b);
            }

            FormMessage.ShowMessageSave();
        }

        static public void ListaTxt()
        {
            SerializarNegocios sn = new SerializarNegocios(path);
            sn.CriarPasta();
            SorteioNegocio negSort = new SorteioNegocio();
            ConcorrenteNegocio negoConc = new ConcorrenteNegocio();
            ConcorrenteColecao colC = (ConcorrenteColecao)negoConc.ExecutarConcorrente(enumCRUD.select, null, true);
            BilheteColecao colB = (BilheteColecao)negSort.ExecutarBilhete(enumCRUD.select, new BilheteInfo { bilheteidsorteio = new SorteioInfo { sorteioid = 1 }, bilheteidconcorrente = new ConcorrenteInfo(), bilheteidvendedor = new ConcorrenteInfo() });
            StringBuilder txt = new StringBuilder();

            txt.Append("LISTA DOS CONCORRENTES DO " + colB.First().bilheteidsorteio.sorteiodescricao);
            txt.AppendLine();

            txt.AppendLine("TOTAL DE BILHETES VENDIDOS: " + string.Format("{0:000}", colB.Count) + "\t\tTOTAL EM VENDAS: " + string.Format("{0:C2}", colB.FirstOrDefault().bilheteidsorteio.sorteiobilhetevalor * colB.Count));

            txt.AppendLine();
            txt.AppendLine();

            foreach (var b in colB.OrderBy(o => o.bilhetenum))
            {
                txt.Append("Bilhete: " + string.Format("{0:000}", b.bilhetenum) + "; " + "Concorrente: " + b.bilheteidconcorrente.concorrentenome + "; Vendedor: " + colC.Where(w => w.concorrenteid == b.bilheteidvendedor.concorrenteid).FirstOrDefault().concorrentenome);
                txt.AppendLine();
            }

            FileInfo f = new FileInfo(path + "listaconcorrente.txt");

            if (f.Exists)
                f.Delete();

            using (StreamWriter sw = f.AppendText())
            {
                sw.Write(txt);
            }

            FormMessage.ShowMessageSave();
        }

        static public void Serial()
        {
            SerializarNegocios sn = new SerializarNegocios(path);
            SorteioNegocio negSort = new SorteioNegocio();
            ConcorrenteNegocio negoConc = new ConcorrenteNegocio();
            ConcorrenteColecao colC = (ConcorrenteColecao)negoConc.ExecutarConcorrente(enumCRUD.select);
            sn.SerializarObjeto(colC, "colC.lvt");
            ConcorrenteColecao colV = (ConcorrenteColecao)negoConc.ExecutarConcorrente(enumCRUD.select, null, true);
            sn.SerializarObjeto(colV, "colV.lvt");
            BilheteColecao colB = (BilheteColecao)negSort.ExecutarBilhete(enumCRUD.select, new BilheteInfo { bilheteidsorteio = new SorteioInfo { sorteioid = 1 }, bilheteidconcorrente = new ConcorrenteInfo(), bilheteidvendedor = new ConcorrenteInfo() });
            sn.SerializarObjeto(colB, "colB.lvt");
            ProdutoColecao colP = (ProdutoColecao)negSort.ExecutarProduto(enumCRUD.select);
            sn.SerializarObjeto(colP, "colP.lvt");
        }

        static public void desSerial()
        {
            SerializarNegocios sn = new SerializarNegocios(path);
            ConcorrenteColecao colC = (ConcorrenteColecao)sn.DesserializarObjeto("colC.lvt");
            ConcorrenteColecao colV = (ConcorrenteColecao)sn.DesserializarObjeto("colV.lvt");
            BilheteColecao colB = (BilheteColecao)sn.DesserializarObjeto("colB.lvt");
            ProdutoColecao colP = (ProdutoColecao)sn.DesserializarObjeto("colP.lvt");
        }
    }
}
