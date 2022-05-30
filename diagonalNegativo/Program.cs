using System;
using System.Globalization;

namespace diagonalNegativo
{
    class Programa
    {
        static void Main(string[] args)
        {

            int N, i, j, cont;
            int[,] matriz = new int[9, 9];

            Console.WriteLine("Qual a ordem da matriz? ");
            N = int.Parse(Console.ReadLine());

            for (i = 0; i < N; i++)
            {

                for (j = 0; j < N; j++)
                {
                    Console.WriteLine("Elemento [" + i + "," + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL:");
            for (i = 0; i < N; i++)
            {
                Console.WriteLine(matriz[i, i] + " ");
            }
            Console.WriteLine();

            cont = 0;
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        cont = cont + 1;
                    }
                }
            }

            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + cont);

        }
    }
}