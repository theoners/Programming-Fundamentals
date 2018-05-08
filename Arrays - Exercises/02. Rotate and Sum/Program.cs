using System;
using System.Linq;

namespace _02._Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input =Console.ReadLine()
                         .Split(' ')
                         .Select(int.Parse)
                         .ToArray();
            int k =int.Parse(Console.ReadLine());
            int step = 1;
            int[] inputRotated = new int[input.Length];
            int[] sum = new int[input.Length];
            
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                     inputRotated[(j+step)% inputRotated.Length] = input[j % input.Length];
                }
                step++;
                for (int l = 0; l < input.Length; l++)
                {
                    sum[l] = sum[l] + inputRotated[l];
                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }
            
    }
}
