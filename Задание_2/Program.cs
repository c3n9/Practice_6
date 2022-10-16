using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11*5 => 1+2+3+4+5+6+7+8+9+10 = 55
            Console.WriteLine("Input number:\t");
            int n = int.Parse(Console.ReadLine());
            int i = 1; int s = 0;
            while(i < n)
            {
                s += i;
                i++;
                if (s == n * 5)
                {
                    Console.WriteLine("натуральное число, которое в пять раз меньше суммы предшествующих ему натуральных чисел: "+n);
                    break;
                }
            }
        }
    }
}
