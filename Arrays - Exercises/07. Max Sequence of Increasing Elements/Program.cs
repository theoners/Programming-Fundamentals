using System;
using System.Linq;

namespace _07._Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long count = 1;
            long bestcount = 1;
            long position = 0;




            for (long i = 1; i < input.Length; i++)
            {
                if (input[i - 1]+1 <= input[i])
                {
                    count++;
                }
                else
                {
                    if (bestcount < count)
                    {
                        bestcount = count;
                        position = i - count;


                    }
                    count = 1;
                }
                if (count == input.Length || (i == input.Length - 1 && count > bestcount))
                {
                    bestcount = count;
                    position = i - count + 1;
                }
            }
            long[] bestSeq = new long[bestcount];
            for (long j = position; j < position + bestcount; j++)
            {

                bestSeq[j - position] = input[j];

            }
            Console.Write(string.Join(" ", bestSeq));
            Console.WriteLine(" ");
        }
    
    }
}
