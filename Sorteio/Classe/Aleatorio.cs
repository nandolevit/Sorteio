using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
