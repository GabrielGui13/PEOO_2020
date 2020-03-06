using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q.F
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int x = 1; x <= N; x++)
            {
                if (N % x == 0) Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
