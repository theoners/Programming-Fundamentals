using System;
using System.Linq;

namespace _05._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            foreach (var x in array)
            {
                double roundNumber = Math.Round(x, MidpointRounding.AwayFromZero);

                Console.WriteLine(x + " ==> " + roundNumber);
            }
        }
    }
}
