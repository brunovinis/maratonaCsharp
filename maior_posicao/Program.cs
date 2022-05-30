using System;
using System.Globalization;
namespace maior_posicao
{
    class Programa
    {
        static void Main(string[] args)
        {

            int N, i, posMaior;
            double maior;

            Console.WriteLine("Quanto numeros voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            for (i = 0; i < N; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine());
            }

            posMaior = 0;
            maior = vet[0];

            for (i = 1; i < N; i++)
            {
                if (vet[i] > maior)
                {
                    maior = vet[i];
                    posMaior = i + 1;
                }
            }

            Console.WriteLine();
            Console.WriteLine("MAIOR VALOR = " + maior.ToString("F"));
            Console.WriteLine("POSICAO DO MAIOR VALOR = " + posMaior.ToString("F"));

        }
    }
}




