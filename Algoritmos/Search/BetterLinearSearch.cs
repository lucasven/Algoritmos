using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmos.Search
{
    public static class BetterLinearSearch
    {
        public static int Search(int[] A, int n, int x)
        {
            for (int i = 0; i < n; i++)
            {
                if (A[i] == x)
                    return i;
            }

            return -1;
        }
    }
}
