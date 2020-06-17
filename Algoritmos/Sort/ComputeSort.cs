using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Algoritmos.Sort
{
    public static class ComputeSort
    {
        public static void Executar(int[] array)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            SelectionSort.Sort(array, array.Length);
            sw.Stop();
            Console.WriteLine("Tempo usado para selection sort: {0}", sw.Elapsed);
            array = Program.GerarArraySort(100000);
            sw.Reset();

            sw.Start();
            InsertionSort.Sort(array, array.Length);
            sw.Stop();
            Console.WriteLine("Tempo usado para insertion sort: {0}", sw.Elapsed);
            array = Program.GerarArraySort(100000);
            sw.Reset();

            sw.Start();
            MergeSort.Sort(array, 0, array.Length-1);
            sw.Stop();
            Console.WriteLine("Tempo usado para merge sort: {0}", sw.Elapsed);
            array = Program.GerarArraySort(100000);
            sw.Reset();

            sw.Start();
            array.OrderBy(c => c);
            sw.Stop();
            Console.WriteLine("Tempo usado para linq sort: {0}", sw.Elapsed);
            array = Program.GerarArraySort(100000);
            sw.Reset();
        }
    }
}
