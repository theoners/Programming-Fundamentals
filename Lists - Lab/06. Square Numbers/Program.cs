using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var squareNumber = new List<int>();

            numbers.Sort();
            numbers.Reverse();

            for (int i = 0; i < numbers.Count; i++)
            {
                var square = Math.Sqrt(numbers[i]);

                if (square == (int)square)
                {
                    squareNumber.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", squareNumber));
        }
    }
}
