using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().Split(' ');

            var phoneBook = new Dictionary<string, string>();

            while (str[0] != "END")
            {
                if (str[0]=="A")
                {
                    phoneBook[str[1]] = str[2];
                }
                else
                {
                    var isHave = phoneBook.ContainsKey(str[1]);
                    if (isHave)
                    {
                        Console.WriteLine($"{str[1]} -> {phoneBook[str[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {str[1]} does not exist.");
                    }
                }
                 str = Console.ReadLine().Split(' ');
            }
        }
    }
}
