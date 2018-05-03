using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 100)
            {
                for (int i = 1; i <= number; i++)
                {
                    int firstDigit = i / 10;
                    int lastdigit = i % 10;
                    int sum = firstDigit + lastdigit;
                    if (sum == 5 || sum == 7 || sum == 11)
                    {
                        Console.WriteLine($"{i} -> True");
                    }
                    else
                    {
                        Console.WriteLine($"{i} -> False");
                    }
                }
            }
        }
    }
}
