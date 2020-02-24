using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os coeficientes a, b e c de uma equação do II grau");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double bp = (-b + Math.Sqrt(Math.Pow(b, 2) - 4*a*c)) / (2*a);
            double bn = (-b - Math.Sqrt(Math.Pow(b, 2) - 4*a*c)) / (2*a);

            if ((bp % 1 == 0) && (bn % 1 == 0)) Console.WriteLine($"As raizes são {bp} e {bn}");
            else Console.WriteLine("Impossível Calcular");
            Console.ReadKey();
        }
    }
}
