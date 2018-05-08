using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var sum = 0;
            int number = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                var firstNumber = numbers[i].ToString().ToList();
                firstNumber.Reverse();

                sum += int.Parse(string.Join("", firstNumber));
                
            }

            Console.WriteLine(sum);
        }
    }
}
