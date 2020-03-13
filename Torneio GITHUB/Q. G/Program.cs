using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q.G
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tudo = Console.ReadLine().Split(' ');
            int S = int.Parse(tudo[0]);
            int V = int.Parse(tudo[1]);
            int F = int.Parse(tudo[2]);

            if (S + V + F >= 0)
            {
                if (S + V + F < 24) Console.WriteLine(S + V + F);
                else Console.WriteLine(S + V + F - 24);
            }
            else Console.WriteLine(S + V + F + 24);
            Console.ReadKey();

        }
    }
}
