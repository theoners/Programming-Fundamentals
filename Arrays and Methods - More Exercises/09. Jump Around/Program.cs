using System;
using System.Linq;

namespace _09._Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var totalSum = 0;
            int currentIndex = 0;

            while (true)
            {
                totalSum += input[currentIndex];
                if (input[currentIndex]+currentIndex<input.Length)
                {
                    currentIndex = input[currentIndex] + currentIndex;
                }
                else if (currentIndex-input[currentIndex]>=0)
                {
                    currentIndex = currentIndex - input[currentIndex];
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(totalSum);
        }
    }
}
