using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfInt = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); ;
            int count = 1;
            int bestCount = 0;
            int bestPosition = 0;

            for (int i = 0; i < listOfInt.Count-1; i++)
            {
                if (listOfInt[i]==listOfInt[i+1])
                {
                    count++;
                    if (count>bestCount)
                    {
                        bestCount = count;
                        bestPosition = i+1;

                    }
                }
                else
                {
                    count = 1;
                    
                    
                    
                }
            }
            if (count==1)
            {
                Console.WriteLine(listOfInt[0]);
            }
            for (int i = bestPosition; i > bestPosition - bestCount; i--)
            {
                Console.Write(listOfInt[i]);
                Console.Write(" ");

            }
            Console.WriteLine("");

        }
    }
}
