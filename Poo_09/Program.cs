using System;
using System.Globalization;

namespace poo_09
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolar, quantidade;

            Console.WriteLine("Qual a cotação do dolar?");
            dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos doláres você vai comprar ?");
            quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Calculo = ConversorDeMoedas.TotalReais(dolar, quantidade);

            Console.WriteLine($"{Calculo.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
