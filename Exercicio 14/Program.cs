using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três valores:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if ((a + b > c) && (a + c > b) && (b + c > a)) Console.WriteLine("Esses valores formam um triângulo");
            else Console.WriteLine("Esses valores não formam um triângulo");
            Console.ReadKey();
        }
    }
}
