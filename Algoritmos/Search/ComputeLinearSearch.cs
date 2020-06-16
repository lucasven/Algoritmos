using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Algoritmos.Search
{
    public static class ComputeLinearSearch
    {
        public static void Computar(int[] array)
        {
            Stopwatch sw = new Stopwatch();
            //sw.Start();
            //var resultLinearSearch = LinearSearch.Search(array, array.Length, array[array.Length / 2]);
            //sw.Stop();
            //Console.WriteLine("Tempo usado para linear search: {0}", sw.Elapsed);
            //Console.WriteLine("Resultado: {0}", resultLinearSearch);
            //sw.Reset();

            //sw.Start();
            //var resultBetterLinearSearch = BetterLinearSearch.Search(array, array.Length, array[array.Length / 2]);
            //sw.Stop();
            //Console.WriteLine("Tempo usado para better linear search: {0}", sw.Elapsed);
            //Console.WriteLine("Resultado: {0}", resultBetterLinearSearch);
            //sw.Reset();

            //sw.Start();
            //var resultSentinelLinearSearch = SentinelLinearSearch.Search(array, array.Length, array[array.Length / 2]);
            //sw.Stop();
            //Console.WriteLine("Tempo usado para sentinel linear search: {0}", sw.Elapsed);
            //Console.WriteLine("Resultado: {0}", resultSentinelLinearSearch);
            //sw.Reset();

            //sw.Start();
            //var resultLinqFirstSearch = array.First(c => c == array[array.Length / 2]);
            //sw.Stop();
            //Console.WriteLine("Tempo usado para linq first search: {0}", sw.Elapsed);
            //Console.WriteLine("Resultado: {0}", resultLinqFirstSearch);
            //sw.Reset();

            sw.Start();
            var resultLinqWhereFirstSearch = array.Where(c => c == array[array.Length / 2]).First();
            sw.Stop();
            Console.WriteLine("Tempo usado para linq where first search: {0}", sw.Elapsed);
            Console.WriteLine("Resultado: {0}", resultLinqWhereFirstSearch);
            sw.Reset();

            sw.Start();
            var resultBinarySearch = BinarySearch.Search(array, array.Length, array[array.Length / 2]);
            sw.Stop();
            Console.WriteLine("Tempo usado para binary search: {0}", sw.Elapsed);
            Console.WriteLine("Resultado: {0}", resultBinarySearch);
            sw.Reset();
        }
    }
}
