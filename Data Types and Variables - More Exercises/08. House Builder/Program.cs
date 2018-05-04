using System;
using System.Numerics;

namespace _08._House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger price1 = BigInteger.Parse(Console.ReadLine());
            BigInteger price2 = BigInteger.Parse(Console.ReadLine());

            if (price1>price2)
            {
                Console.WriteLine(price1*10+price2*4);
            }
            else
            {
                Console.WriteLine(price1 * 4 + price2 * 10);
            }
        }
    }
}
