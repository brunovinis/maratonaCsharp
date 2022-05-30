using System;
using System.Globalization;

namespace mediaPares
{
    class Programa
    {
        static void Main(string[] args)
        {

            int N, i, soma, contPares;
            double media;
            int[] vetor = new int[9];

            Console.WriteLine("Quantos elementos vai ter o vetor? ");
            N = int.Parse(Console.ReadLine());

            for (i = 0; i < N; i++)
            {
                Console.WriteLine("Digite um numero: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            soma = 0;
            contPares = 0;
            for (i = 0; i < N; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    soma = soma + vetor[i];
                    contPares = contPares + 1;
                }
            }

            if (contPares == 0)
            {
                Console.WriteLine("NENHUM NUMERO PAR");
            }
            else
            {
                media = soma / contPares;
                Console.WriteLine("MEDIA DOS PARES = " + media.ToString("F"));
            }

        }
    }
}
