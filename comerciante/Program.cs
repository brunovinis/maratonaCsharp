using System;
using System.Globalization;
namespace comerciante
{
    class Programa
    {
        static void Main(string[] args)
        {

            int N, i, abaixo, entre, acima;
            double totalCompra, totalVenda, totalLucro, lucro, percentualLucro;
            string[] nomes = new string[9];
            double[] precosCompra = new double[9];
            double[] precosVenda = new double[9];

            Console.WriteLine("Serao digitados dados de quantos produtos? ");
            N = int.Parse(Console.ReadLine());

            for (i = 0; i < N; i++)
            {
                Console.WriteLine("Produto " + (i +1));
                Console.WriteLine("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.WriteLine("Preco de compra: ");
                precosCompra[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Preco de venda: ");
                precosVenda[i] = double.Parse(Console.ReadLine());
            }

            abaixo = 0;
            entre = 0;
            acima = 0;
            for (i = 0; i < N; i++)
            {

                lucro = precosVenda[i] - precosCompra[i];
                percentualLucro = lucro * 100.0 / precosCompra[i];

                if (percentualLucro < 10)
                {
                    abaixo = abaixo + 1;

                }
                else if (percentualLucro <= 20)
                {
                    entre = entre + 1;
                }
                else
                {
                    acima = acima + 1;
                }

            }
            totalCompra = 0;
            totalVenda = 0;
            for (i = 0; i < N; i++)
            {
                totalCompra = totalCompra + precosCompra[i];
                totalVenda = totalVenda + precosVenda[i];
            }

            totalLucro = totalVenda - totalCompra;

            Console.WriteLine();
            Console.WriteLine("RELATORIO:");
            Console.WriteLine("Lucro abaixo de 10%: " + abaixo);
            Console.WriteLine("Lucro entre 10% e 20%: " + entre);
            Console.WriteLine("Lucro acima de 20%: " + acima);
            Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F"));
            Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F"));
            Console.WriteLine("Lucro total: " + totalLucro.ToString("F"));
        }
    }
}

