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

            GravarTxt(txt.ToString(), "listaconcorrente.txt");

        }

        static public void GravarTxt(string str, string filelName)
        {
            FileInfo f = new FileInfo(path + filelName);

            if (f.Exists)
                f.Delete();

            using (StreamWriter sw = f.AppendText())
            {
                sw.Write(str);
            }

            //FormMessage.ShowMessageSave();

            FormMessage.ShowMessegeInfo("Relatório realizado com sucesso! Foi criada uma pasta na ÁREA DE TRABALHO/BANCOSORTEIO, lá estará os relatório!");
        }

        static public void Serial()
        {
            SerializarNegocios sn = new SerializarNegocios(path);
            SorteioNegocio negSort = new SorteioNegocio();
            ConcorrenteNegocio negoConc = new ConcorrenteNegocio();
            ConcorrenteColecao colC = (ConcorrenteColecao)negoConc.ExecutarConcorrente(enumCRUD.select);
            sn.SerializarObjeto(colC, "colC.lvt", true);
            ConcorrenteColecao colV = (ConcorrenteColecao)negoConc.ExecutarConcorrente(enumCRUD.select, null, true);
            sn.SerializarObjeto(colV, "colV.lvt", true);
            BilheteColecao colB = (BilheteColecao)negSort.ExecutarBilhete(enumCRUD.select, new BilheteInfo { bilheteidsorteio = new SorteioInfo { sorteioid = 1 }, bilheteidconcorrente = new ConcorrenteInfo(), bilheteidvendedor = new ConcorrenteInfo() });
            sn.SerializarObjeto(colB, "colB.lvt", true);
            ProdutoColecao colP = (ProdutoColecao)negSort.ExecutarProduto(enumCRUD.select);
            sn.SerializarObjeto(colP, "colP.lvt", true);
            SorteioItemColecao colI = (SorteioItemColecao)negSort.ExecutarSorteioItem(enumCRUD.select, new SorteioItemInfo { Sort = new SorteioInfo { sorteioid = 1}, Prod = new ProdutoInfo() });
            sn.SerializarObjeto(colI, "colI.lvt", true);
        }

        static public void desSerial()
        {
            SerializarNegocios sn = new SerializarNegocios(path);
            Form1.colC = (ConcorrenteColecao)sn.DesserializarObjeto("colC.lvt");
            Form1.colV = (ConcorrenteColecao)sn.DesserializarObjeto("colV.lvt");
            Form1.colB = (BilheteColecao)sn.DesserializarObjeto("colB.lvt");
            Form1.colP = (ProdutoColecao)sn.DesserializarObjeto("colP.lvt");
            Form1.colI = (SorteioItemColecao)sn.DesserializarObjeto("colI.lvt");
        }

        static public bool TodosArquivosExiste()
        {
            string[] arquivo = { "colC.lvt", "colV.lvt", "colB.lvt", "colP.lvt", "colI.lvt"};

            if (Directory.Exists(path))
            {
                string[] dir = Directory.GetFiles(path);

                foreach (var item in arquivo)
                {
                    if (dir.Where(w => w.EndsWith(item)).FirstOrDefault() == null)
                        return false;
                }

                return true;
            }
            else
                return false;

        }

        static public bool ArquivoExiste(string fileName)
        {
            try
            {
                string[] arquivos = Directory.GetFiles(path);

                foreach (var item in arquivos)
                {

                }

                if (File.Exists(Path.Combine(Path.GetDirectoryName(path), fileName)))
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        public static void ListaVendedor(int idsort)
        {
            ConcorrenteNegocio neg = new ConcorrenteNegocio();
            ConcorrenteColecao colecao = (ConcorrenteColecao)neg.ExecutarConcorrente(enumCRUD.select, null, true);
            SorteioNegocio negSort = new SorteioNegocio();
            SorteioColecao colSort = (SorteioColecao)negSort.ExecutarSorteio(enumCRUD.select);
            SorteioInfo infoSort = colSort.Where(w => w.sorteioid == idsort).FirstOrDefault();
            BilheteColecao colB = (BilheteColecao)negSort.ExecutarBilhete(enumCRUD.select, new BilheteInfo { bilheteidconcorrente = new ConcorrenteInfo(), bilheteidsorteio = infoSort, bilheteidvendedor = new ConcorrenteInfo() });

            if (colecao != null)
            {
                StringBuilder sb = new StringBuilder();

                int total = colB.Count();
                if (total > 0)
                {
                    //adiciona os valores gerais
                    //adiciona 2 nós com soma total de bilhete vendidos e o valor total
                    sb.AppendLine("**TOTAL GERAL**");
                    sb.AppendLine("\t - Total de vendedores: " + string.Format("{0:000}", colB.GroupBy(gp => gp.bilheteidvendedor.concorrenteid).ToList().Count - 1));
                    sb.AppendLine("\t - Total de concorrentes: " + string.Format("{0:000}", colB.GroupBy(gp => gp.bilheteidconcorrente.concorrenteid).ToList().Count - 1));
                    sb.AppendLine("\t - Total de Bilhetes Vendidos: " + string.Format("{0:000}", total));
                    sb.AppendLine("\t\t - Valor Total Vendidos: " + string.Format("{0:C2}", total * infoSort.sorteiobilhetevalor)); 
                    sb.AppendLine();
                }

                foreach (var item in colecao.OrderBy(o => o.concorrentenome))
                {
                    int totalBilhete = colB.Where(w => w.bilheteidvendedor.concorrenteid == item.concorrenteid).Count();

                    //adiciona os nomes dos vendedores
                    sb.AppendLine(item.concorrentenome);
                    if (totalBilhete > 0)
                    {
                        //adiciona 2 nós com soma total de bilhete vendidos e o valor total
                        sb.AppendLine("\t - Total de Bilhetes Vendidos: " + string.Format("{0:000}", totalBilhete));
                        sb.AppendLine("\t\t - Valor Total Vendidos: " + string.Format("{0:C2}", totalBilhete * infoSort.sorteiobilhetevalor));
                    }

                    BilheteColecao bc = new BilheteColecao();
                    foreach (var item1 in colB.Where(w => w.bilheteidvendedor.concorrenteid == item.concorrenteid).OrderBy(o => o.bilheteidconcorrente.concorrentenome))
                    {
                        if (bc.Where(w => w.bilheteidconcorrente.concorrenteid == item1.bilheteidconcorrente.concorrenteid).FirstOrDefault() == null)
                        {
                            bc.Add(item1);
                            int totalBilhete2 = colB.Where(w => w.bilheteidconcorrente.concorrenteid == item1.bilheteidconcorrente.concorrenteid && w.bilheteidvendedor.concorrenteid == item.concorrenteid).Count();

                            //adiciona os nomes dos compradores
                            sb.AppendLine("\t\t\t" + item1.bilheteidconcorrente.concorrentenome);
                            if (totalBilhete2 > 0)
                            {
                                sb.AppendLine("\t\t\t\t - Total de Bilhetes Comprados: " + string.Format("{0:000}", totalBilhete2));
                                sb.AppendLine("\t\t\t\t\t - Valor Total Comprados: " + string.Format("{0:C2}", totalBilhete2 * infoSort.sorteiobilhetevalor));
                            }
                        }
                    }
                }

                GravarTxt(sb.ToString(), "vendedores.txt");
            }
        }
    }
}
