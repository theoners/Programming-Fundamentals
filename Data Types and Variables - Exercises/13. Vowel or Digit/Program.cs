using System;

namespace _13._Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbol = Console.ReadLine();
            bool isDigits = double.TryParse(symbol,out double result);

            if (isDigits)
            {
                Console.WriteLine("digit");
            }
             else if (symbol=="a"|| symbol == "e" || symbol == "i" || symbol == "u" || symbol == "u" || symbol == "o")
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
