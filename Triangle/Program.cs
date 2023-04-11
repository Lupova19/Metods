using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double widht = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(TriangleArea(widht , height));
        }

        private static double TriangleArea(double widht, double height)
        {
            return widht * height  / 2; 
        }
    }
}
