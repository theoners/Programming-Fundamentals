using System;
using System.Linq;


    class Program
    {
        static void Main(string[] args)
        {
            int[] array4k = Console.ReadLine()
                           .Split(' ')
                           .Select(int.Parse)
                           .ToArray();

            int[] firstPart = new int[array4k.Length/2];
            int[] secondPart = new int[array4k.Length/2];
            int[] middlePart = new int[array4k.Length/2];
            int[] sum = new int[array4k.Length/2];


            int index = (secondPart.Length / 2);
            int index1 = 0;
            int index2 = 0;

            for (int i = array4k.Length / 4-1; i >= 0; i--)
            {
                firstPart[index1] = array4k[i];
                index1++;
            }
            for (int i = array4k.Length -1; i > (array4k.Length/4)*3-1; i--)
            {
                secondPart[index] = array4k[i];
                index++;
            }
            for (int i = array4k.Length / 4; i <=(array4k.Length/4) * 3 - 1; i++)
            {
                middlePart[index2] = array4k[i];
                index2++;
            }

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] =firstPart[i]+secondPart[i]+middlePart[i];
            }
            Console.Write(string.Join(" ", sum));
            Console.WriteLine("");
        }

    }

