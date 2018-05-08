using System;
using System.Linq;

namespace _08._Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array =Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long count = 0;
            long maxCount = 1;
            long index = 0;

            for (long i = 0; i < array.Length; i++)
            {
                for (long j = 0; j < array.Length; j++)
                {
                    if (array[i]==array[j])
                    {
                        count++;
                        
                    }
                    if (count > maxCount && j == array.Length - 1)
                    {
                        maxCount = count;
                        index = i;
                    }

                }
                count = 0;
            }
            Console.WriteLine(array[index]);
        }
    }
}
