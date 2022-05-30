using System;
using System.Globalization;

namespace acima_diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i, j, soma;

            Console.Write("Qual a ordem da matriz? ");
            N = int.Parse(Console.ReadLine());

            int[,] matriz = new int[N, N];

            
            for(i = 0; i < N; i++)
            {
                for(j = 0; j < N; j++)
                {
                    Console.WriteLine("Elemento [ " + i + ", " + j + "]");
                    matriz[i, j] = int.Parse(Console.ReadLine());

                }
            }

            soma = 0;

            for(i = 0; i < N; i++)
            {
                for(j = i +1; j < N; j++)
                {
                    soma += matriz[i, j];
                }
            }

            Console.WriteLine("SOMA DOS ELEMENTOS ACIMA DA DIAGONAL PRINCIPAL = " + soma);
        }
    }
}


