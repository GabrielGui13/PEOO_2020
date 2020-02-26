using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três valores inteiros");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int maior = n1;
            int menor = n1;

            if (n2 > maior) maior = n2;
            if (n3 > maior) maior = n3;

            if (n2 < menor) menor = n2;
            if (n3 < menor) menor = n3;

            int soma = maior + menor;

            Console.WriteLine($"A soma do maior com o menor número é {soma}");
            Console.ReadKey();

        }
    }
}
