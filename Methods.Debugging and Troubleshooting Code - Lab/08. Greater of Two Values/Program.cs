using System;

namespace _08._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int firstInt = int.Parse(Console.ReadLine());
                int secondInt = int.Parse(Console.ReadLine());
                int max = GetMax(firstInt, secondInt);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                char max = GetMax(firstChar, secondChar);
                Console.WriteLine(max);
            }
            else
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                string max = GetMax(firstString, secondString);
                Console.WriteLine(max);

            }
        }

        static string GetMax(string firstString, string secondString)
        {
            if (firstString.CompareTo(secondString) >= 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }

        static int GetMax(int firstInt, int secondInt)
        {
            int c = Math.Max(firstInt, secondInt);
            return c;

        }

        static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }

        }
    }
}

