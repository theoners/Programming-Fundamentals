using System;

namespace _04._Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintFirstAndLastRow(number);
            PrintMiddleRows(number);
            PrintFirstAndLastRow(number);
        }

        static void PrintFirstAndLastRow(int number)
        {
            for (int i = 0; i < 2 * number; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("");
        }

        static void PrintMiddleRows(int number)
        {

            for (int i = 0; i < number - 2; i++)
            {
                Console.Write("-");
                for (int j = 1; j < number; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }
    }
}
