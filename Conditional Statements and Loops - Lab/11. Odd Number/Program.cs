using System;

namespace _11._Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);

            while (number % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                number = int.Parse(Console.ReadLine());
                number = Math.Abs(number);
            }
            Console.WriteLine($"The number is: {Math.Abs(number)}");
        }
    }
}
