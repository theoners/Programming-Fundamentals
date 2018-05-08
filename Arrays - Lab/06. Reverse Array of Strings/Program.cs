using System;

namespace _06._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] items = input.Split(' ');

            for (int i = items.Length - 1; i >= 0; i--)
            {
                Console.Write(items[i]);
                Console.Write(" ");
            }

        }
    }
}
