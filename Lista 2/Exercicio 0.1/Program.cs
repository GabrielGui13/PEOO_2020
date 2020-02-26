using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva dois valores inteiros");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > b) Console.WriteLine($"Maior = {a}");
            else Console.WriteLine($"Maior = {b}");
            Console.ReadKey();
        }
    }
}
