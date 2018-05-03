using System;

namespace _04._Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            double volume = int.Parse(Console.ReadLine());
            int kcal = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {productName}:");
            Console.WriteLine($"{kcal*volume/100}kcal, {sugar*volume/100}g sugars");
        }
    }
}
