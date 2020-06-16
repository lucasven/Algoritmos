using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmos.Fatorial
{
    public static class Fatorial
    {
        public static int Gerar(int fat)
        {
            if (fat == 0)
                return 1;

            return fat * Gerar(fat - 1);
        }
    }
}
