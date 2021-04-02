using System;

namespace poo_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;

            p1 = new Pessoa();

            p2 = new Pessoa();

            p1.Nome = Console.ReadLine();
            p1.Idade = int.Parse(Console.ReadLine());

            p2.Nome = Console.ReadLine();
            p2.Idade = int.Parse(Console.ReadLine());

            if(p1.Idade == p2.Idade)
            {
                Console.WriteLine("Idades são iguais");
            }else if(p1.Idade > p2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
            }else{
                Console.WriteLine($"Pessoa mais velha: {p2.Nome}");
            }
        }
    }
}
