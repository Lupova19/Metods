using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }

        private static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive!");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative!");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The numbers {number} is zero!");
            }
        }
    }
}
