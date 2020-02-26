using System;

namespace Exercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 4 valores inteiros");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int media = (a + b + c + d) / 4;

            Console.WriteLine($"Média = {media}");

            Console.WriteLine("Números menores que a média:");
            if (a < media) Console.WriteLine(a);
            if (b < media) Console.WriteLine(b);
            if (c < media) Console.WriteLine(c);
            if (d < media) Console.WriteLine(d);

            Console.WriteLine("Números maiores que a média:");
            if (a > media) Console.WriteLine(a);
            if (b > media) Console.WriteLine(b);
            if (c > media) Console.WriteLine(c);
            if (d > media) Console.WriteLine(d);
            Console.ReadKey();


        }
    }
}
