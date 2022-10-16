using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input n:\t");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input k:\t");
            int k = int.Parse(Console.ReadLine());
            int i = 0; while (++i * k <= n) ; --i;
            Console.WriteLine($"Целое = {i}\t Остаток = {n - i * k}");
        }
    }
}
