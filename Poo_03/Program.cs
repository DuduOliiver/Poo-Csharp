using System;

namespace poo_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            f1.Nome = Console.ReadLine();
            f1.Salario = double.Parse(Console.ReadLine());

            f2.Nome = Console.ReadLine();
            f2.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"Salário médio = {((f1.Salario + f2.Salario) / 2).ToString("F2")}");
        }
    }
}
