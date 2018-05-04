using System;

namespace _09._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            int oddSum = SumOddDigits(number);
            int evenSum = SumEvenDigits(number);
            Console.WriteLine(oddSum * evenSum);
        }

        private static int SumEvenDigits(int number)
        {
            int evenSum = 0;
            while (number > 0)
            {
                int lastDigts = number % 10;
                number = number / 10;
                if (lastDigts % 2 == 0)
                {
                    evenSum += lastDigts;
                }
            }
            return evenSum;
        }

        static int SumOddDigits(int number)
        {
            int oddSum = 0;
            while (number > 0)
            {
                int lastDigts = number % 10;
                number = number / 10;
                if (lastDigts % 2 == 1)
                {
                    oddSum += lastDigts;
                }
            }
            return oddSum;
        }
    }
}

