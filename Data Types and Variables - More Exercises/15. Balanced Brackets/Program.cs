using System;

namespace _15._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int openBrackets = 0;
            int closedBrackets = 0;

            for (int i = 0; i < n; i++)
            {
                string random = Console.ReadLine();

                if (random=="(")
                {
                    openBrackets += 1;
                }
                else if (random==")")
                {
                    closedBrackets += 1;

                    if (closedBrackets!=openBrackets)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
            }
            if (closedBrackets==openBrackets)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
