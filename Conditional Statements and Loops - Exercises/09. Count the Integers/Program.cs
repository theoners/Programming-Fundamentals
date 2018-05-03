using System;

namespace _09._Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = -1;
            for (int i = 0; i < 100; i++)
            {
                var n = Console.ReadLine();

                count++;
                try
                {
                    int.Parse(n);
                }
                catch (Exception a)
                {
                    Console.WriteLine(count);
                    return;
                }
            }
        }
    }
}
