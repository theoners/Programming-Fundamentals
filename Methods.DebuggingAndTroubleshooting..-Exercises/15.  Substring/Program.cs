using System;

namespace _15.__Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int numberLetter = int.Parse(Console.ReadLine());

            char search = 'p';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {

                if (text[i] == search)
                {
                    hasMatch = true;

                    int countLetter = numberLetter + 1;

                    if (countLetter > text.Length - i)
                    {
                        countLetter = text.Length - i;
                    }

                    string matchedString = text.Substring(i, countLetter);
                    Console.WriteLine(matchedString);
                    i += numberLetter;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
