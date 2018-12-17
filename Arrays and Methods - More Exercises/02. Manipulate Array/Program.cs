using System;
using System.Linq;

namespace _02._Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var command = Console.ReadLine();

                 

                if (command=="Reverse")
                {
                    input = input.Reverse().ToArray();
                }
                else if (command=="Distinct")
                {
                    input = input.Distinct().ToArray();
                }
                else
                {
                    var index = int.Parse(command.Split()[1]);
                    var word = command.Split()[2];
                    input[index] = word;
                }
            }

            Console.WriteLine(string.Join(", ", input));
        }
    }
}
