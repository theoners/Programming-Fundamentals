using System;
using System.Linq;

namespace _05._Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] array2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int minLeght = Math.Min(array1.Length, array2.Length);
            for (int i = 0; i < minLeght; i++)
            {
                if (!(array1[i]==array2[i]))
                {
                    if (array1[i]<array2[i])
                    {
                        Console.WriteLine(string.Join("",array1));
                        Console.WriteLine(string.Join("",array2));
                        break;
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", array2));
                        Console.WriteLine(string.Join("", array1));
                        break;

                    }
                }
                if (array1.Length<array2.Length)
                {
                    Console.WriteLine(string.Join("", array1));
                    Console.WriteLine(string.Join("", array2));
                    break;
                }
                else
                {
                    Console.WriteLine(string.Join("", array2));
                    Console.WriteLine(string.Join("", array1));
                    break;
                }
            }
        }
    }
}
