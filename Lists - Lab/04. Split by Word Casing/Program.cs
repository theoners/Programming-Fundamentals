using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ',', ';', ':', '.', '!','(', ')', '"', '/', '[', ']', '\'', '\\',' ' } )
                .ToList();
            bool isLowerCase = false;
            bool isUpperCase = false;
            bool isMixedcase = false;
            var lowerCase =new List<string>();
            var upperCase =new List<string>();
            var mixedCase = new List<string>();

            foreach (var word in numbers)
            {
                var letter = word.ToCharArray();

                for (int i = 0; i < letter.Length; i++)
                {
                    if (letter[i]>=97 && letter[i]<=122)
                    {
                        isLowerCase = true;
                    }
                    else if (letter[i] >= 65 && letter[i] <= 90)
                    {
                        isUpperCase = true;
                    }
                    else
                    {
                        isMixedcase = true;
                    }
                }

                if (!isLowerCase && isUpperCase && !isMixedcase)
                {
                    upperCase.Add(word);
                }
                else if (isLowerCase && !isUpperCase && !isMixedcase)
                {
                    lowerCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
                 isLowerCase = false;
                 isUpperCase = false;
                 isMixedcase = false;
            }
                upperCase.RemoveAll(s => s=="");
                lowerCase.RemoveAll(s => s=="");
                mixedCase.RemoveAll(s => s=="");
            Console.WriteLine("Lower-case: "+string.Join(", ",lowerCase));
            Console.WriteLine("Mixed-case: "+string.Join(", ",mixedCase));
            Console.WriteLine("Upper-case: " + string.Join(", ",upperCase));
        }
    }
}
