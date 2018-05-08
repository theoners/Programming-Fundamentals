using System;
using System.Linq;

namespace _07._Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arrayTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxLenght = Math.Max(arrayOne.Length, arrayTwo.Length);

            for (int i = 0; i < maxLenght; i++)
            {
               
                int sum = arrayOne[i%arrayOne.Length] + arrayTwo[i%arrayTwo.Length];
                Console.Write(sum);
                Console.Write(" ");
            }
        }
    }
}
