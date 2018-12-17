using System;
using System.Collections.Generic;

namespace _05._Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var number = int.Parse(Console.ReadLine());
            List<string> ingredients = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length == number)
                {
                    
                    if (ingredients.Count < 10)
                    {
                        ingredients.Add(input[i]);
                        Console.WriteLine($"Adding {input[i]}.");
                    }
                }
                if (ingredients.Count == 10)
                {
                    break;
                }
            }

            Console.WriteLine($"Made pizza with total of {ingredients.Count} ingredients.");
            Console.Write($"The ingredients are: ");
            Console.Write(string.Join(", ", ingredients));
            Console.WriteLine(".");
        }
    }
}
