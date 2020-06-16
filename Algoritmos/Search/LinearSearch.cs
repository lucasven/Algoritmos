using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmos.Search
{
    public static class LinearSearch
    {
        public static int Search(int[] A, int n, int x)
        {
            int resposta = -1;
            for (int i = 0; i < n; i++)
            {
                if (A[i] == x)
                    resposta = i;
            }
            return resposta;
        }
    }
}
