using System;
using System.Globalization;

namespace mais_velho
{

    class Program
    {
        static void Main(string[] args)
        {

            int N, i, posMaior, maior;

            Console.WriteLine("Quantas pessoas voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];

            for (i = 0; i < N; i++)
            {
                Console.WriteLine("Dados da " + (i + 1) + "a pessoa:");
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Idade: ");
                idades[i] = int.Parse(Console.ReadLine());
            }

            maior = idades[0];
            posMaior = 0;

            for (i = 0; i < N; i++)
            {
                if (idades[i] > maior)
                {
                    maior = idades[i];
                    posMaior = i;
                    Console.WriteLine("PESSOA MAIS VELHA: " + nomes[posMaior]);
                }
               
            }



        }
    }
}