using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();
            numbers.Add(int.MaxValue);
            var count = 1;

            for (int i = 0; i < numbers.Count-1; i++)
            {
                if (numbers[i]==numbers[i+1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{numbers[i]} -> {count}");
                    count = 1;
                }
            }
            
        }
    }
}
