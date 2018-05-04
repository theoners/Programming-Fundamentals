using System;

namespace _01._Blank_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReceip();
        }
        static void PrintReceip()
        {
            PrintReceipHeader();
            PrintReceipBody();
            PrintReceipFooter();
        }

        static void PrintReceipHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        static void PrintReceipBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PrintReceipFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }
    }
}
