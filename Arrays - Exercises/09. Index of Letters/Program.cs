using System;
using System.Linq;

namespace _09._Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            char[] arr = input.ToCharArray();

            char[] alphabet = new char[26];
            int index = 0;

            for (char i = 'a'; i <= 'z'; i++)
            {
               alphabet[index]= i;
                index++;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (arr[i]==alphabet[j])
                    {
                        Console.WriteLine(arr[i]+ " -> " + j);
                    }
                }
            }
            
        }
    }
}
