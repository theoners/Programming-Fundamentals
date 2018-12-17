using System;
using System.Linq;

namespace _08._Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameOfProducts = Console.ReadLine().Split();
            var quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var priceOfProducts = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "done")
                {
                    break;
                }

                var product = input.Split()[0];
                var quantity = long.Parse(input.Split()[1]);
                var index = Array.IndexOf(nameOfProducts, product);
                if (index>=0 && index<quantities.Length)
                {
                    if (quantities[index] >= quantity)
                    {
                        Console.WriteLine($"{product} x {quantity} costs {quantity * priceOfProducts[index]:F2}");
                        quantities[index] -= quantity;
                    }
                    else
                    {
                        Console.WriteLine($"We do not have enough {product}");
                    }
                }
                else
                {
                    Console.WriteLine($"We do not have enough {product}");
                }
            }
        }
    }
}
