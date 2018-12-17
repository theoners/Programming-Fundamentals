using System;
using System.Linq;

namespace _07._Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameOfProducts = Console.ReadLine().Split();
            var quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var priceOfProducts = Console.ReadLine().Split();

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="done")
                {
                    break;
                }

                var index = Array.IndexOf(nameOfProducts, input);

                Console.WriteLine($"{input} costs: {priceOfProducts[index]}; Available quantity: {quantities[index]}");
            }
        }
    }
}
