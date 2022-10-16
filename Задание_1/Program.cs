using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    internal class Program
    {
        static int Fac(int n)
        {
            return n == 0 ? 1 : n * (Fac(n - 1));
        }
        static void Main(string[] args)
        {
            int i = 1;
            double s = 0;
            Console.WriteLine("Input n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input x");
            int x = int.Parse(Console.ReadLine());
            while (i <= n)
            {
                s += Math.Pow(-1, i) * Math.Pow(x, i) / Fac(i);
                i++;
            }
            Console.WriteLine(1 + s);
        }
    }
}
