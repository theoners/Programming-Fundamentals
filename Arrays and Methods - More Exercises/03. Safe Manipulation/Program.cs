using System;
using System.Linq;

namespace _03._Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            while (true)
            {
                var command = Console.ReadLine();
                if (command=="END")
                {
                    break;
                }

                if (command=="Reverse")
                {
                    input = input.Reverse().ToArray();
                }
                else if (command=="Distinct")
                {
                    input = input.Distinct().ToArray();
                }
                else if (command.Split()[0]=="Replace")
                {
                    var index = int.Parse(command.Split()[1]);
                    var word = command.Split()[2];

                    if (index>=0&&index<input.Length)
                    {
                        input[index] = word;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }

            Console.WriteLine(string.Join(", ", input));
        }
    }
}
