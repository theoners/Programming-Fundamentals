using System;
using System.Linq;

namespace _04._Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var count = 1;
            var index = 0;
            var bestCount = 0;
            var indexTemp = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                indexTemp = i;
                for (int j = indexTemp; j < numbers.Count-1; j++)
                {
                
                    if (numbers[i]<numbers[j+1])
                    {
                        count++;
                        for (int k = 0; k < numbers.Count; k++)
                        {

                        }
                        
                        
                    }
                }
                if (count>bestCount)
                {
                    bestCount = count;
                    index = indexTemp;
                }
                count = 1;
               
            }
            
                Console.Write(numbers[index]);
              
                for (int j = index; j < numbers.Count - 1; j++)
                {   
                    if (numbers[index]+1 == numbers[1 + j])
                    {
                        Console.Write(" "+numbers[1+j]);
                        
                    }
                }
        }
    }
}
