using System;

namespace _07._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double result = MathPower(first, second);
            Console.WriteLine(result);
        }

        static double MathPower(double first, double second)
        {
            return Math.Pow(first, second); ;
        }
    }
}

