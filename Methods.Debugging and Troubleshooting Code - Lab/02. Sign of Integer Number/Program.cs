using System;

namespace _02._Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintSignOfNumber(number);
        }

        static void PrintSignOfNumber(int number)
        {
            string sign = "zero";
            if (number < 0)
            {
                sign = "negative";
            }
            else if (number > 0)
            {
                sign = "positive";
            }
            Console.WriteLine($"The number {number} is {sign}.");
        }
    }
}
