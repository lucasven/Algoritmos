using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmos.Search
{
    public static class RecursiveLinearSearch
    {
        public static int Search(int[] A, int n, int x, int i)
        {
            if (i >= n)
                return -1;
            else
            {
                if (A[i] == x)
                    return i;
                else
                    return Search(A, n, x, i+1);
            }
        }
    }
}
