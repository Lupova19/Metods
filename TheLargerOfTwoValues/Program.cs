using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLargerOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi jelan tip: ");
            string type = Console.ReadLine();
            if (type == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                int max = GetMax(firstNumber, secondNumber);
                Console.WriteLine($"Po-glqmoto chislo e {max}");
            }
            else if (type == "char")
            {
                char firstSumbol = char.Parse(Console.ReadLine());
                char secondSumbol = char.Parse(Console.ReadLine());
                int max = GetMax1(firstSumbol, secondSumbol);
                Console.WriteLine($"Po-golemiqr simvol e {max}");
            }
            else if (type == "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                string max = GetMax2(firstString, secondString);
                Console.WriteLine($"Po-golemiqt niz e {max}");
            }
        }

        private static string GetMax2(string firstString, string secondString)
        {
            string result = "";
            if (firstString.CompareTo(secondString) >= 0)
            {
                result = firstString;
                return result;
            }
            else
            {
                result = secondString;
                return result;
            }
        }

        private static int GetMax1(char firstSumbol, char secondSumbol)
        {
            int result = 0;
            if ((int) firstSumbol > (int) secondSumbol)
            {
                result = firstSumbol;
                return result;
            }
            else
            {
                result = secondSumbol;
                return result;
            }
        }

        private static int GetMax(int firstNumber, int secondNumber)
        {
            int result = 0;
            if (firstNumber > secondNumber)
            {
                result = firstNumber;
                return result;
            }
            else
            {
                result = secondNumber;
                return result;
            }
        }
    }
}
