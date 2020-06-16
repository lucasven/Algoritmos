using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmos.Search
{
    public static class SentinelLinearSearch
    {
        public static int Search(int[] A, int n, int x)
        {
            int last = A[n - 1];

            A[n - 1] = x;
            int i = 0;

            while (A[i] != x)
                i++;

            A[n - 1] = last;

            if (i < n - 1 || x == A[n - 1])
            {
                return i;
            }
            else
                return -1;
        }
    }
}
