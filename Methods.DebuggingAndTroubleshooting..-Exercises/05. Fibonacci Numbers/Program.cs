using System;

namespace _5._Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int fibonachiNumber = CalcNthFIbonachiNumber(number);
            Console.WriteLine(fibonachiNumber);
        }

        static int CalcNthFIbonachiNumber(int number)
        {

            int currentNumber = 1;
            int previousNumber = 0;
            int lastNumber = 1;
            for (int i = 1; i <= number; i++)
            {
                lastNumber = currentNumber + previousNumber;
                previousNumber = currentNumber;
                currentNumber = lastNumber;
            }
            return lastNumber;
        }
    }
}
