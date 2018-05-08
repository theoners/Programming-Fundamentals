using System;
using System.Linq;

namespace _11._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            bool sumEquals = false;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }

                for (int k = i+1; k < array.Length; k++)
                {
                    rightSum += array[k];
                }
                if (leftSum==rightSum)
                {
                    sumEquals = true;
                    Console.WriteLine(i);
                    break;
                }
                leftSum = 0;
                rightSum = 0;
            }
            if (!sumEquals)
            {
                Console.WriteLine("no");
            }
        }
    }
}
