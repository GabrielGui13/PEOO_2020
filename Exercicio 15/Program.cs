using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três valores:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            List<int> lista = new List<int>();
            lista.Add(a);
            lista.Add(b);
            lista.Add(c);

            lista.Sort();

            Console.WriteLine($"{lista[0]}, {lista[1]}, {lista[2]}");
            Console.ReadKey();


        }
    }
}
