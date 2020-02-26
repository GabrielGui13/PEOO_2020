using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 4 valores inteiros");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());

            int soma = n1 + n2 + n3 + n4;
            int maior = n1;
            int menor = n1;

            if (n2 > maior) maior = n2;
            if (n3 > maior) maior = n3;
            if (n4 > maior) maior = n4;

            if (n2 < menor) menor = n2;
            if (n3 < menor) menor = n3;
            if (n4 < menor) menor = n4;

            int final = soma - (maior + menor);

            Console.WriteLine($"Maior valor = {maior}");
            Console.WriteLine($"Menor valor = {menor}");
            Console.WriteLine($"A soma do segundo maior valor com o segundo menor = {final}");
            Console.ReadKey();


        }
    }
}
