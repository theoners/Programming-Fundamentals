using System;

namespace _10._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            if (numberTwo > 10)
            {
                Console.WriteLine($"{numberOne} X {numberTwo} = {numberOne * numberTwo}");
            }
            else
            {
                for (int i = numberTwo; i <= 10; i++)
                {
                    Console.WriteLine($"{numberOne} X {i} = {numberOne * i}");
                }
            }
        }
    }
}
