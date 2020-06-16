using Algoritmos.Search;
using System;
using System.Diagnostics;
using Algoritmos.Fatorial;
using System.Linq;

namespace Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio dos testes de algoritmos");
            var array = GerarArray(2000000000);

            ComputeLinearSearch.Computar(array);
            
            Stopwatch sw = new Stopwatch();


            //gera estouro de pilha
            //sw.Start();
            //var resultRecursiveLinearSearch = RecursiveLinearSearch.Search(array, array.Length, array[array.Length / 1000], 0);
            //sw.Stop();
            //Console.WriteLine("Tempo usado para recursive linear search: {0}", sw.Elapsed);
            //Console.WriteLine("Resultado: {0}", resultRecursiveLinearSearch);
            //sw.Reset();

            //sw.Start();
            //var fatorial10 = Fatorial.Fatorial.Gerar(10);
            //sw.Stop();
            //Console.WriteLine("Tempo usado para gerar fatorial: {0}", sw.Elapsed);
            //Console.WriteLine("Resultado: {0}", fatorial10);
            //sw.Reset();


            Console.ReadLine();
        }

        static int[] GerarArray(int tamanho)
        {
            var retorno = new int[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                retorno[i] = i;
            }

            return retorno;
        }
    } 
}
