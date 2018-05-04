using System;

namespace _12._Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int palindrome = 0;
            int divisibleBySeven = 0;
            int oneEvenNumber = 0;

            for (int i = 1; i <= number; i++)
            {
                palindrome = IsPalindrome(i);
                if (palindrome != 0)
                {
                    divisibleBySeven = DivisibleBySeven(palindrome);
                    if (palindrome == divisibleBySeven)
                    {
                        oneEvenNumber = OneEvenNumber(divisibleBySeven);
                        if (oneEvenNumber != 0)
                        {
                            Console.WriteLine(oneEvenNumber);
                        }
                    }

                }

            }

        }

        static int OneEvenNumber(int divisibleBySeven)
        {
            int oldDivisibleBySeven = divisibleBySeven;
            int oneEvenNumber = 0;
            while (divisibleBySeven != 0)
            {
                int lastdigits = divisibleBySeven % 10;
                int newDivisibleBySeven = divisibleBySeven / 10;
                divisibleBySeven = newDivisibleBySeven;

                if (lastdigits % 2 == 0)
                {
                    oneEvenNumber = oldDivisibleBySeven;
                }
            }
            return oneEvenNumber;
        }

        static int DivisibleBySeven(int palindrome)
        {
            int oldPalidrome = palindrome;
            int divisibleBySeven = 0;
            int sumOfDigits = 0;
            while (palindrome != 0)
            {
                int lastdigits = palindrome % 10;
                int newpalindrome = palindrome / 10;
                palindrome = newpalindrome;
                sumOfDigits = sumOfDigits + lastdigits;
            }

            if (sumOfDigits % 7 == 0)
            {
                divisibleBySeven = oldPalidrome;
            }
            return divisibleBySeven;
        }

        static int IsPalindrome(int i)
        {
            int oldI = i;
            int numberDigits = 0;
            while (i != 0)
            {
                i = i / 10;
                numberDigits++;

            }
            int leftAndRightSideDigits = numberDigits / 2;
            int divisor = 1;
            for (int j = 0; j < leftAndRightSideDigits; j++)
            {
                divisor = divisor * 10;
            }
            int leftSide = 0;
            if (numberDigits % 2 == 0)
            {
                leftSide = oldI / divisor;
            }
            else
            {
                leftSide = oldI / (divisor * 10);
            }

            int rightSide = oldI % (divisor);

            int reverseLeftSide = 0;
            while (leftSide != 0)
            {
                reverseLeftSide = reverseLeftSide * 10 + leftSide % 10;
                leftSide = leftSide / 10;
            }
            int palindrome = 0;
            if (rightSide == reverseLeftSide)
            {
                palindrome = oldI;

            }
            return palindrome;
        }
    }
}
