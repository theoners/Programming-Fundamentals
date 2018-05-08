using System;
using System.Linq;

namespace _06._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int count = 1;
             int bestcount = 1;
            int position = 0;
            



            for (int i = 1; i < input.Length; i++)
            {
                if (input[i-1]==input[i])
                {
                    count++;
                }
                else
                {
                    if (bestcount<count)
                    {
                        bestcount = count;
                        position = i - count;

                        
                    }
                    count = 1;
                }
                if (count == input.Length || (i == input.Length-1 && count>bestcount ))
                {
                    bestcount = count;
                    position = i - count+1;
                }
            }
            int[] bestSeq = new int[bestcount];
            for (int j = position; j < position + bestcount; j++)
            {
                
                bestSeq[j - position] = input[j];
                
            }
            Console.Write(string.Join(" ", bestSeq));
            Console.WriteLine(" ");
        }
    }
}
