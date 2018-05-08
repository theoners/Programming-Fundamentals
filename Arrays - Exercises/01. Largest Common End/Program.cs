using System;
using System.Linq;

namespace _01._Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(' ');
            string[] input2 = Console.ReadLine().Split(' ');

            int countEnd = 0;
            int countEnd2 = 0;
            int minLength = Math.Min(input1.Length, input2.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (input1[i]==input2[i])
                {
                    countEnd++;
                }
                else
                {
                    break;
                }
            }
            string[] reversedInput2 = input2.Reverse().ToArray();
            string[] reversedInput1 = input1.Reverse().ToArray();
            for (int i = 0; i < minLength; i++)
            {
                if (reversedInput1[i] == reversedInput2[i])
                {
                    countEnd2++;
                }
                else
                {
                    break;
                }
            }
            if (countEnd>=countEnd2)
            {
                Console.WriteLine(countEnd);
            }
            else
            {
                Console.WriteLine(countEnd2);
            }


           
        }

    }
}
