
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorteio
{
    public enum EnumDias { Hoje, Amanha, Depois, Ontem, Anteontem }
    public static class FormTextoFormat
    {

        public const string Alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static string PalavraMaiuscula(string s)
        {
            string[] Preposicao = new string[] { "em", "a", "de", "da", "das", "do", "dos", "para", "com", "por", "pelo", "pela", "pelos", "pelas", "e" };
            string[] nome = s.Split(' ');
            string novo = string.Empty;
            bool prox = false;
            foreach (string n in nome)
            {
                //foreach (string p in Preposicao)
                //    if (p.Contains(n.ToLower())) { prox = true; break; }

                if (Preposicao.Contains(n.ToLower())) { prox = true; break; }

                if (prox)
                {
                    novo = string.IsNullOrEmpty(novo) ? n.ToLower() : string.Join(" ", novo, n.ToLower());
                    prox = false;
                    continue;
                }
                else
                {
                    string nsp = string.Empty;
                    string[] sp = n.Split('/');

                    if (sp.Length > 1)
                    {
                        foreach (string no in sp)
                            nsp += string.IsNullOrWhiteSpace(nsp) ? FormTextoFormat.Nome(no) : string.Concat("/", FormTextoFormat.Nome(no));

                        novo = string.IsNullOrEmpty(novo) ? nsp : string.Join(" ", novo, nsp); ;
                    }
                    else
                        novo = string.IsNullOrEmpty(novo) ? FormTextoFormat.Nome(n) : string.Join(" ", novo, FormTextoFormat.Nome(n));
                }
            }

            return novo;
        }

        public static EnumDias CompararDias(DateTime date)
        {
            int iDias;

            switch (DateTime.Now.Date.CompareTo(date.Date))
            {
                case 0:
                    return EnumDias.Hoje;
                case 1:
                    iDias = DateTime.Now.Day - date.Day;

                    if (iDias == 1)
                        return EnumDias.Ontem;
                    else
                        return EnumDias.Anteontem;
                default:
                    iDias = date.Day - DateTime.Now.Day;

                    if (iDias == 1)
                        return EnumDias.Amanha;
                    else
                        return EnumDias.Depois;
            }
        }

        public static void NumericTexto(object sender, int casas = 0, int numMax = 0)
        {
            TextBox box = (TextBox)sender;

            if (box.Text.Length > 0)
            {
                string t = box.Text;
                char c = t[t.Length - 1];

                if (!char.IsNumber(c) || c == '-')
                {
                    if (c != '-')
                    {
                        if (!(c == (char)46 || c == (char)44))
                            box.Text = t.Substring(0, t.Length - 1);
                    }
                    else
                    {
                        if (box.Text.Length != 1)
                            box.Text = t.Substring(0, t.Length - 1);
                    }
                }
                else if (casas > 1)
                {
                    string z = string.Empty;
                    int n = Convert.ToInt32(box.Text);

                    if (numMax > 0)
                        if (n.CompareTo(numMax) == 1)
                            n = numMax;

                    for (int i = 0; i < casas; i++)
                        z += "0";

                    box.Text = string.Format("{0:" + z + "}", n).Substring(0, casas);

                }

                box.SelectionStart = box.Text.Length;
            }
        }

        public static void NovoTextoUpper(TextBox texto)
        {
            NovoTextoTxt(texto);
        }

        public static string Nome(string nome)
        {
            string primeiroNome = string.Empty;
            if (nome.Length > 1)
                primeiroNome = nome.Substring(0, 1).ToUpper() + nome.Substring(1).ToLower();

            return primeiroNome;
        }

        public static string NomeSimples(string nome)
        {
            string[] compNome = nome.Trim().Split(' ');
            string pNome = compNome[0];
            string uNome = string.Empty;
            if (compNome.Length > 1)
                uNome = compNome[compNome.Length - 1];

            return (Nome(pNome) + " " + Nome(uNome)).Trim();
        }

        public static string MoedaExtenso(object sender)
        {
            TextBox box = (TextBox)sender;
            string[] casas = box.Text.Replace(".", "").Split(',');
            int num = Convert.ToInt32(casas[0]);
            int cent = casas[0].Length;
            int centavos = Convert.ToInt32(casas[1]);
            string extenso = string.Empty;

            if (num < 999999)
            {
                if (num > 0)
                {
                    switch (cent)
                    {
                        case 1:
                            extenso = Unidade(num);
                            break;
                        case 2:
                            extenso = Dezena(num);
                            break;
                        case 3:
                            extenso = Centena(num);
                            break;
                        case 4:
                        case 5:
                        case 6:
                            extenso = Milhar(num);
                            break;
                        default:
                            return "";
                    }

                    if (num > 1)
                        extenso += " reais";
                    else
                        extenso += " real";
                }

                if (centavos > 0)
                {
                    if (!string.IsNullOrEmpty(extenso))
                        extenso += " e ";

                    if (centavos > 1)
                        extenso += Dezena(centavos) + " centavos";
                    else
                        extenso += Dezena(centavos) + " centavo";

                }
            }

            return extenso;
        }

        private static string Milhar(int num)
        {
            string milhar = string.Empty;
            string n = Convert.ToString(num);
            int casasMilhar = n.Substring(0, n.Length - 3).Length;
            int milhares = Convert.ToInt16(n.Substring(0, n.Length - 3));

            int centenas = Convert.ToInt16(n.Substring(casasMilhar));
            string cent = n.Substring(casasMilhar);

            switch (casasMilhar)
            {
                case 1:
                    milhar = Unidade(milhares) + " mil";
                    break;
                case 2:
                    milhar = Dezena(milhares) + " mil";
                    break;
                case 3:
                    milhar = Centena(milhares) + " mil";
                    break;
                default:
                    break;
            }

            milhar += " e " + Centena(centenas);



            return milhar;
        }

        private static string Centena(int num)
        {
            string centena = string.Empty;
            string dezena = string.Empty;

            if (num > 99)
            {
                int d = Convert.ToInt16(Convert.ToString(num).Substring(0, 1));
                int dez = Convert.ToInt16(Convert.ToString(num).Substring(1));

                switch (d)
                {
                    case 1:
                        centena = "cem";
                        dezena = Dezena(dez);
                        if (!string.IsNullOrEmpty(dezena))
                            centena = "cento e " + dezena;
                        break;
                    case 2:
                        centena = "duzentos";
                        dezena = Dezena(dez);
                        if (!string.IsNullOrEmpty(dezena))
                            centena += " e " + dezena;
                        break;
                    case 3:
                        centena = "trezentos";
                        dezena = Dezena(dez);
                        if (!string.IsNullOrEmpty(dezena))
                            centena += " e " + dezena;
                        break;
                    case 4:
                        centena = "quatrocentos";
                        dezena = Dezena(dez);
                        if (!string.IsNullOrEmpty(dezena))
                            centena += " e " + dezena;
                        break;
                    case 5:
                        centena = "quinhentos";
                        dezena = Dezena(dez);
                        if (!string.IsNullOrEmpty(dezena))
                            centena += " e " + dezena;
                        break;
                    case 6:
                        centena = "seiscentos";
                        dezena = Dezena(dez);
                        if (!string.IsNullOrEmpty(dezena))
                            centena += " e " + dezena;
                        break;
                    case 7:
                        centena = "setecento";
                        dezena = Dezena(dez);
                        if (!string.IsNullOrEmpty(dezena))
                            centena += " e " + dezena;
                        break;
                    case 8:
                        centena = "oitocentos";
                        dezena = Dezena(dez);
                        if (!string.IsNullOrEmpty(dezena))
                            centena += " e " + dezena;
                        break;
                    case 9:
                        centena = "novecentos";
                        dezena = Dezena(dez);
                        if (!string.IsNullOrEmpty(dezena))
                            centena += " e " + dezena;
                        break;
                    default:
                        centena = Dezena(dez);
                        break;
                }
            }
            else
                centena = Dezena(num);

            return centena;
        }

        private static string Dezena(int num)
        {
            string dezena = string.Empty;
            if (num > 9)
            {
                switch (num)
                {
                    case 10:
                        dezena = "dez";
                        break;
                    case 11:
                        dezena = "onze";
                        break;
                    case 12:
                        dezena = "doze";
                        break;
                    case 13:
                        dezena = "treze";
                        break;
                    case 14:
                        dezena = "quartorze";
                        break;
                    case 15:
                        dezena = "quinze";
                        break;
                    case 16:
                        dezena = "dezesseis";
                        break;
                    case 17:
                        dezena = "dezessete";
                        break;
                    case 18:
                        dezena = "dezoito";
                        break;
                    case 19:
                        dezena = "dezenove";
                        break;
                    default:

                        string unidade = string.Empty;
                        int d = Convert.ToInt16(Convert.ToString(num).Substring(0, 1));
                        int u = Convert.ToInt16(Convert.ToString(num).Substring(1));
                        switch (d)
                        {
                            case 2:

                                dezena = "vinte";
                                unidade = Unidade(u);

                                if (!string.IsNullOrEmpty(unidade))
                                    dezena += " e " + unidade;
                                break;
                            case 3:
                                dezena = "trinta";
                                unidade = Unidade(u);

                                if (!string.IsNullOrEmpty(unidade))
                                    dezena += " e " + unidade;
                                break;
                            case 4:
                                dezena = "quarenta";
                                unidade = Unidade(u);

                                if (!string.IsNullOrEmpty(unidade))
                                    dezena += " e " + unidade;
                                break;
                            case 5:
                                dezena = "ciquenta";
                                unidade = Unidade(u);

                                if (!string.IsNullOrEmpty(unidade))
                                    dezena += " e " + unidade;
                                break;
                            case 6:
                                dezena = "sessenta";
                                unidade = Unidade(u);

                                if (!string.IsNullOrEmpty(unidade))
                                    dezena += " e " + unidade;
                                break;
                            case 7:
                                dezena = "setenta";
                                unidade = Unidade(u);

                                if (!string.IsNullOrEmpty(unidade))
                                    dezena += " e " + unidade;
                                break;
                            case 8:
                                dezena = "oitenta";
                                unidade = Unidade(u);

                                if (!string.IsNullOrEmpty(unidade))
                                    dezena += " e " + unidade;
                                break;
                            case 9:
                                dezena = "noventa";
                                unidade = Unidade(u);

                                if (!string.IsNullOrEmpty(unidade))
                                    dezena += " e " + unidade;
                                break;
                            default:
                                break;
                        }
                        break;
                }
            }
            else
                dezena = Unidade(num);

            return dezena;
        }
        private static string Unidade(int num)
        {
            string unidade = string.Empty;
            switch (num)
            {
                case 1:
                    unidade = "um";
                    break;
                case 2:
                    unidade = "dois";
                    break;
                case 3:
                    unidade = "três";
                    break;
                case 4:
                    unidade = "quatro";
                    break;
                case 5:
                    unidade = "cinco";
                    break;
                case 6:
                    unidade = "seis";
                    break;
                case 7:
                    unidade = "sete";
                    break;
                case 8:
                    unidade = "oito";
                    break;
                case 9:
                    unidade = "nove";
                    break;
                default:
                    break;
            }

            return unidade;
        }

        public static void MoedaFormat(object sender)
        {
            TextBox box = (TextBox)sender;

            if (double.TryParse(box.Text, out double cod))
            {
                string n = string.Empty;
                decimal v = 0;

                n = box.Text.Replace(",", "").Replace(".", "").Replace("R$", "");
                if (string.IsNullOrEmpty(n))
                    n = "";

                n = n.PadLeft(3, '0');
                if (n.Length > 3 && n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);

                v = Convert.ToDecimal(n) / 100;
                box.Text = string.Format("{0:N}", v);
                box.SelectionStart = box.Text.Length;
            }
            else
                box.Text = "0";
        }

        public static void Format3casasdecimais(object sender)
        {
            TextBox box = (TextBox)sender;
            string n = string.Empty;
            decimal v = 0;

            n = box.Text.Replace(",", "").Replace(".", "");
            if (string.IsNullOrEmpty(n))
                n = "";

            n = n.PadLeft(3, '0');
            if (n.Length > 3 && n.Substring(0, 1) == "0")
                n = n.Substring(1, n.Length - 1);

            v = Convert.ToDecimal(n) / 1000;
            box.Text = string.Format("{0:0.000}", v);
            box.SelectionStart = box.Text.Length;
        }

        private static void NovoTextoTxt(TextBox box)
        {
            int cursor = box.SelectionStart;


            box.Text = TextoSemAcento(box.Text);
            box.SelectionStart = cursor;
        }

        public static string PalavraSemAcento(string palavra)
        {
            string p = string.Empty;
            for (int i = 0; i < palavra.Length; i++)
            {
                p += TextoSemAcento(palavra.Substring(0, i + 1)).Substring(i, 1);
            }

            return p;
        }

        private static string TextoSemAcento(string palavra)
        {
            string novoTexto = palavra.Substring(0, palavra.Length - 1);

            for (int i = palavra.Length - 1; i < palavra.Length; i++)
            {
                char letra;
                //captura a última letra digitada
                letra = palavra[palavra.Length - 1];
                //verifica se há acento e remove
                char novaLetra = RemoveAcentos(letra);
                novoTexto += novaLetra;
            }

            return novoTexto;
        }

        private static char RemoveAcentos(char l)
        {
            string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            string semAcentos = "AAAAAAAAAAAEEEEEEEEIIIIIIIIOOOOOOOOOOUUUUUUUCC";
            char letra;

            if (comAcentos.IndexOf(l) != -1)
            {
                int num = comAcentos.IndexOf(l);
                letra = semAcentos[num];
                return letra;
            }
            else
            {
                return letra = l;
            }

        }

        public static bool ValidaEmail(string texto)
        {
            string padrao = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$"; //@"(@\w+\.\w+)(\.\w+)*$"; 

            string novoTexto = FormatarEmail(texto).Trim();

            Regex er = new Regex(padrao, RegexOptions.IgnoreCase);

            if (er.IsMatch(novoTexto))
                return true;
            else
            {
                FormMessage.ShowMessegeWarning(texto + " EMAIL INVÁLIDO!");
                return false;
            }
        }

        private static string FormatarEmail(string email)
        {
            string[] novoEmail = email.Split('-');

            if (novoEmail.Length > 1)
                return novoEmail[1];
            else
                return novoEmail[0];
        }

        public static int CalcularAnos(DateTime date)
        {
            int ano = 0;
            DateTime niver = new DateTime(DateTime.Now.Date.Year, date.Month, date.Day);
            DateTime two = DateTime.Now.Date;
            switch (niver.CompareTo(two))
            {
                case 0:
                    ano = two.Year - date.Year;
                    break;
                case 1:
                    ano = (two.Year - date.Year) - 1;
                    break;
                default:
                    ano = two.Year - date.Year;
                    break;
            }

            return ano;
        }

        public static int CalcularMeses(DateTime date)
        {
            int Meses = 0;
            TimeSpan span = DateTime.Now.Date - date.Date;
            Meses = span.Days / 30;
            return Meses;
        }

        public static void AniversarioMensagem(DateTime one, string texto)
        {
            DateTime niver = new DateTime(DateTime.Now.Date.Year, one.Month, one.Day);
            DateTime two = DateTime.Now.Date;

            switch (niver.CompareTo(two))
            {
                case 0:
                    MessageBox.Show("Hoje, está completando mais 1 ano de " + texto + "!");
                    break;
                case 1:
                    int resta = 0;
                    TimeSpan dias = niver - two;
                    resta = dias.Days;
                    if (resta > 0 && resta < 7)
                    {
                        if (resta == 1)
                            MessageBox.Show("Amanhã estará completando mais 1 ano de " + texto + "!");
                        else
                            MessageBox.Show("Faltam " + resta + " dias para completar mais 1 ano de " + texto + "!");
                    }

                    break;
                default:
                    break;
            }
        }

        public static string MesNome(DateTime m)
        {
            return MesNome(m.Month);
        }

        public static string MesNome(int m)
        {
            string[] sMes = new string[] { "", "JANEIRO", "FEVEREIRO", "MARÇO", "ABRIL", "MAIO", "JUNHO", "JULHO", "AGOSTO", "SETEMBRO", "OUTUBRO", "NOVEMBRO", "DEZEMBRO", };
            return sMes[m];
        }
    }
}
