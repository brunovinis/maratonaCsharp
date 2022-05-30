using System;
using System.Globalization;

namespace alturas
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i, cont;
            double soma, media, porcentagem;

            string[] nomes = new string[9];
            int[] idades = new int[9];
            double[] alturas = new double[9];

            Console.WriteLine("Quantas pessoas serao digitadas? ");
            N = int.Parse(Console.ReadLine());

            for (i = 0; i < N; i++)
            {
                Console.WriteLine("Dados da " + (i + 1) + "ª pessoa:");
                nomes[i] = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Idades: ");
                idades[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Alturas: ");
                alturas[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();

            }
            soma = 0;
            for (i = 0; i < N; i++)
            {
                soma += alturas[i];

            }
            media = soma / N;

            Console.WriteLine();
            Console.WriteLine("Altura media: " + media.ToString("F"));

            cont = 0;
            for (i = 0; i < N; i++)
            {
                if (idades[i] < 16)
                {
                    cont += 1;
                }
            }

            porcentagem = cont * 100 / N;
            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem.ToString("F") + "%");

            for (i = 0; i < N; i++)
            {
                if (idades[i] < 16)
                {
                    Console.WriteLine(nomes[i]);
                }
            }
        }
    }
}










