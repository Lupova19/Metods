using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheitn = double.Parse(Console.ReadLine());
            double celsius = FahrenheitnToCelsius(fahrenheitn);

            Console.WriteLine("{0:F2}" , celsius);
        }

        private static double FahrenheitnToCelsius(double fahrenheitn)
        {
            return (fahrenheitn - 32) * 5 / 9;
        }
    }
}
