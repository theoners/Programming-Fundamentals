using System;
using System.Numerics;

namespace _02._Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            BigInteger withoutPoint = (BigInteger)number;

            if (number == (decimal)withoutPoint)
            {
                Console.WriteLine("integer");
            }
            else
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
