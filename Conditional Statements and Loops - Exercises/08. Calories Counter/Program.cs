using System;

namespace _08._Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int calories = 0;

            for (int i = 0; i < number; i++)
            {
                string ingredients = Console.ReadLine();
                ingredients = ingredients.ToLower();
                if (ingredients.Equals("cheese"))
                {
                    calories = calories + 500;
                }
                if (ingredients.Equals("tomato sauce"))
                {
                    calories = calories + 150;
                }
                if (ingredients.Equals("salami"))
                {
                    calories = calories + 600;
                }
                if (ingredients.Equals("pepper"))
                {
                    calories = calories + 50;
                }
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
