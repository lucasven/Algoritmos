using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Algoritmos.Sort
{
    public static class SelectionSort
    {
        public static void Sort(int[] A, int n)
        {
            int menor = -1;
            for (int i = 0; i < n; i++)
            {
                menor = i;
                for (int j = i+1; j < n; j++)
                {
                    if (A[j] < A[menor])
                        menor = j;
                }
                var aI = A[i];
                A[i] = A[menor];
                A[menor] = aI;
            }
        }
    }
}
