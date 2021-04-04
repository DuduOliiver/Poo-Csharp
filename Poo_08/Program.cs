using System;
using System.Globalization;

namespace poo_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Alunos a1 = new Alunos();
            Console.WriteLine("Digite as três notas do aluno");
            
            a1.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");
            Console.WriteLine($"NOTA FINAL = {a1.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
            
            if(a1.Aprovado() == true){
                Console.WriteLine("APROVADO");
            }else{
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM = {a1.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }
        }
    }
}
