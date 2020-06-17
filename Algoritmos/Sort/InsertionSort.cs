using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmos.Sort
{
    public static class InsertionSort
    {
        public static void Sort(int[] A, int n)
        {
            for (int i = 1; i < n; i++)
            {
                var chave = A[i];
                var j = i - 1;
                while(j > 0 && A[j] > chave)
                {
                    A[j + 1] = A[j];
                    j--;
                }
                A[j + 1] = chave;
            }
        }
    }
}
