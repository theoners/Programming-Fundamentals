using System;
using System.Numerics;

namespace _05._Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            BigInteger withoutPoint = (BigInteger)number;

            if (number == (decimal)withoutPoint)
            {
                if (number<=sbyte.MaxValue&&number>=sbyte.MinValue)
                {
                    Console.WriteLine("Sunny");
                }
                else if (number <= int.MaxValue && number >= int.MinValue)
                {
                    Console.WriteLine("Cloudy");
                }
                else if (number <= long.MaxValue && number >= long.MinValue)
                {
                    Console.WriteLine("Windy");
                }
            }
            else
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}
