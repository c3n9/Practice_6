using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input n>1");
            int n = int.Parse(Console.ReadLine());
            int k = 0; int s = 0;
            while (s <= n)
            {
                k++;
                s += k;
            }
            Console.WriteLine($"K = {k}, Sum = {s}");
        }
    }
}
