using System;
using System.Linq;

namespace _04._Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                        .Split(' ')
                        .Select(int.Parse)
                        .ToArray();
            bool isThereASum = false;
            
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    for (int k = 0; k < array.Length; k++)
                    {
                        int sum = array[i] + array[j];
                        if (sum == array[k])
                        {
                            isThereASum = true;
                            Console.WriteLine($"{array[i]} + {array[j]} == {array[k]}");
                            break;
                        }
                    }
                }
            }
            if (!isThereASum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
