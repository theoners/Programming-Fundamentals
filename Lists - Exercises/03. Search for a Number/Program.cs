using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers =Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] array =Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

             numbers = numbers.Take(array[0]).ToList();
            for (int i = array[1]; i >0 ; i--)
            {
                numbers.RemoveAt(0);
            }

            bool isHave = numbers.Contains(array[2]);
            if (isHave)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }

    }
}
