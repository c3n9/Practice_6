using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    internal class Program
    {
        static int Fac(int n)
        {
            return n == 0 ? 1 : n * (Fac(n - 1));
        }
        static void Main(string[] args)
        {
            int n = 0;  
            Console.WriteLine("Input a>0:\t");
            int a = int.Parse(Console.ReadLine());
            while (Fac(n) < a && !(Fac(n + 1) > a)) n++;
            Console.WriteLine("Ответ "+n);

        }
    }
}
