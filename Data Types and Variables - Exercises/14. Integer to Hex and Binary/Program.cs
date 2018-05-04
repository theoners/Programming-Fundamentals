using System;

namespace _14._Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string myHex = Convert.ToString(number, 16).ToUpper();
            string binary = Convert.ToString(number, 2);

            Console.WriteLine(myHex);
            Console.WriteLine(binary);
        }
    }
}
