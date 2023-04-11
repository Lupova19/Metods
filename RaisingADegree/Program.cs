using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaisingADegree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numbers = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            RaiseToPower(numbers , power);
            Console.WriteLine(RaiseToPower(numbers , power));
            
        }

        private static double RaiseToPower(double numbers, int power)
        {
            double result = 0d;
            Math.Pow(numbers, power);
            return result;
        }
    }
}
