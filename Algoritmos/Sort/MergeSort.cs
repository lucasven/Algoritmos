using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Algoritmos.Sort
{
    public static class MergeSort
    {
        public static void Sort(int[] A, int left, int right)
        {
            if (left >= right)
                return;
            else
            {
                var middle = (left + right) / 2;
                Sort(A, left, middle);
                Sort(A,  middle + 1, right);
                Merge(A, left, middle, right);
            }
        }

        public static void Merge(int[] A, int left, int middle, int right)
        {
            var sizeB = middle - left + 1;
            var sizeC = right - middle;

            int[] B = new int[sizeB + 1];
            int[] C = new int[sizeC + 1];
            Array.Copy(A, left, B, 0, sizeB);
            Array.Copy(A, middle + 1, C, 0, sizeC);

            B[sizeB] = C[sizeC] = Int32.MaxValue;
            int i = 0;
            int j = 0;
            for (int k = left; k <= right; k++)
            {
                if (B[i] <= C[j])
                {
                    A[k] = B[i];
                    i++;
                }
                else
                {
                    A[k] = C[j];
                    j++;
                }
            }
        }
    }
}
