using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores inteiros separados por um operador +, -, * ou /");
            char[] c = { '+', '-', '*', '/' };
            string op = Console.ReadLine();
            string[] soma = op.Split('c');
            int x1 = int.Parse(soma[0]);
            int x2 = int.Parse(soma[1]);
            int total = 0;

            if (op.Contains('+')) total = x1 + x2;
            if (op.Contains('-')) total = x1 - x2;
            if (op.Contains('*')) total = x1 * x2;
            if (op.Contains('/')) total = x1 / x2;

            Console.WriteLine("O resultado da operãção é", total);
            Console.ReadKey();





        }
    }
}
