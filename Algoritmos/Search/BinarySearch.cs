using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmos.Search
{
    public static class BinarySearch
    {
        public static int Search(int[] A, int n, int x)
        {
            int p = 0;
            int r = n;

            while(p <= r)
            {
                int q = (p + r) / 2;
                if (A[q] == x)
                    return q;
                else if(A[q] > x)
                {
                    r = q - 1;
                }
                else
                {
                    p = q - 1;
                }
            }

            return -1;
        }
    }
}
