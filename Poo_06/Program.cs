using System;
using System.Globalization;

namespace poo_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo();

            r1.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"AREA = {r1.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERÍMETRO = {r1.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {r1.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
