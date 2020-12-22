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


        public static int[] Gerar(int n, int total)
        {
            int[] num = new int[total];

            for (int i = 0; i < total; i++)
                num[i] = rnd.Next(1, n);

            return num;
        }

    }
}
