using System;
using System.Linq;

namespace _04._Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            bool isMatch = false;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i]==number)
                {
                    input[i] = 0;
                    isMatch = true;
                    break;
                }
                else
                {
                    input[i] = 0;
                }
            }

            long sum = input.Sum();
            if (sum!=0)
            {
                Console.WriteLine(input.Sum());
            }
            else if (isMatch)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
            
        }
    }
}
