using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]<0)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }
            numbers.Reverse();
            if (numbers.Count==0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }

            
        }
    }
}
