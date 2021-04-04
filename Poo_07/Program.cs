using System;
using System.Globalization;

namespace poo_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();

            Console.WriteLine("Digite o nome do funcionário");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Salário bruto");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Imposto");
            f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");
            Console.WriteLine($"Funcionário: {f1}");

            Console.WriteLine("");
            Console.WriteLine("Aumento do salário em porcentagem");
            double qte = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f1.AumentarSalario(qte);

            Console.WriteLine($"Dados Atualizados: {f1}");

        }
    }
}
