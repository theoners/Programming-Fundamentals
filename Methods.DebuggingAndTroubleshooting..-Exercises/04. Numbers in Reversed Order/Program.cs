using System;

namespace _04._Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string reverseNumber = ReverseNumber(number);
            Console.WriteLine(reverseNumber);
        }

        private static string ReverseNumber(string number)
        {
            string reverseNumber = "";
            int count = number.Length;
            for (int i = 0; i < count; i++)
            {
                char lastDigit = number[number.Length - 1];

                reverseNumber = reverseNumber + lastDigit;
                number = number.TrimEnd(lastDigit);
            }
            return reverseNumber;
        }
    }
}
