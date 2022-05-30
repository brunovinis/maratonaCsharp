using System;
using System.Globalization;

namespace cada_linha
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i, j, maior;

            Console.Write("Qual a ordem da matriz? ");
            N = int.Parse(Console.ReadLine());

            int[,] matriz = new int[N, N];


            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.WriteLine("Elemento [ " + i + ", " + j + "]");
                    matriz[i, j] = int.Parse(Console.ReadLine());

                }
            }

            Console.WriteLine("MAIOR ELEMENTO DE CADA LINHA: ");
            

            for (i = 0; i < N; i++)
            {
                maior = matriz[i,0];

                for (j = 1; j < N; j++)
                {
                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                    }

                }
                Console.WriteLine(maior);
            }

           
        }
    }
}
