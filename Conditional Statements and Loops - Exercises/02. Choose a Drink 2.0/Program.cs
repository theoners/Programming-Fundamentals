using System;

namespace _02._Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0.0;
            double totalPrice = 0.0;

            if (profession.Equals("Athlete"))
            {
                price = 0.70;
            }
            else if (profession.Equals("SoftUni Student"))
            {
                price = 1.70;
            }
            else if (profession.Equals("Businessman") || profession.Equals("Businesswoman"))
            {
                price = 1.00;
            }
            else
            {
                price = 1.20;
            }
            totalPrice = price * quantity;

            Console.WriteLine($"The {profession} has to pay {totalPrice:f2}. ");
        }
    }
}
