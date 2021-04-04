using System;
using System.Globalization;

namespace poo_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Digite o nome do produto");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a quantidade em estoque");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Dados do produto: {p}");
            Console.WriteLine("");

            Console.WriteLine("Digite a quantidade a ser adicionada ao estoque");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine($"Dados atualizados {p}");
            Console.WriteLine("");

            Console.WriteLine("Digite a quantidade a ser removida do estoque");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine($"Dados Atualizados {p}");
            Console.WriteLine("");

        }
    }
}
