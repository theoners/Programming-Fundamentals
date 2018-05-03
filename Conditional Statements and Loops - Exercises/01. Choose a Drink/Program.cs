using System;

namespace _01._Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();

            if (profession.Equals("Athlete"))
            {
                Console.WriteLine("Water");
            }
            else if (profession.Equals("Businessman") || profession.Equals("Businesswoman"))
            {
                Console.WriteLine("Coffee");
            }
            else if (profession.Equals("SoftUni Student"))
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
