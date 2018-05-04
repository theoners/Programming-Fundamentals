using System;

namespace _03._English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            string nameOfLastDigit = PrintNameOfLastDigits(number);
            Console.WriteLine(nameOfLastDigit);
        }

        static string PrintNameOfLastDigits(long number)
        {
            number = Math.Abs(number);
            string nameOfLastDigit = "";
            long lastDigit = number % 10;
            switch (lastDigit)
            {
                case 0:
                    nameOfLastDigit = "zero";
                    break;
                case 1:
                    nameOfLastDigit = "one";
                    break;
                case 2:
                    nameOfLastDigit = "two";
                    break;
                case 3:
                    nameOfLastDigit = "three";
                    break;
                case 4:
                    nameOfLastDigit = "four";
                    break;
                case 5:
                    nameOfLastDigit = "five";
                    break;
                case 6:
                    nameOfLastDigit = "six";
                    break;
                case 7:
                    nameOfLastDigit = "seven";
                    break;
                case 8:
                    nameOfLastDigit = "eight";
                    break;
                default:
                    nameOfLastDigit = "nine";
                    break;
            }
            return nameOfLastDigit;
        }
    }
}
