using System;
using System.Linq;

namespace _10._Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0+i; j < input.Length; j++)
                {
                    if ((Math.Abs(input[i]-input[j])==difference))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
