using System;

namespace _07._Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = -1;

            for (int i = 0; i <= 20; i++)
            {
                string ingredients = Console.ReadLine();
                count++;
                if (ingredients.Equals("Bake!"))
                {
                    Console.WriteLine($"Preparing cake with {count} ingredients.");
                    return;
                }
                Console.WriteLine($"Adding ingredient {ingredients}.");
            }
        }
    }
}
