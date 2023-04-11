using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receipt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFooter();
        }

        

        private static void PrintReceiptFooter()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("\u00A9");
        }

        private static void PrintReceiptBody()
        {
            Console.WriteLine("Charged to_________________");
            Console.WriteLine("Received by________________");
        }

        private static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
    }
}
