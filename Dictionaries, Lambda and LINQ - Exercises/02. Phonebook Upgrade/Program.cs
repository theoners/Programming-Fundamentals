using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().Split(' ');

            var phoneBook = new SortedDictionary<string, string>();

            while (str[0] != "END")
            {
                if (str[0] == "A")
                {
                    phoneBook[str[1]] = str[2];
                }
                else if(str[0] == "S")
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
                if (str[0] == "ListAll")
                {
                    foreach (var peopleAndNumber in phoneBook)
                    {
                        var people = peopleAndNumber.Key;
                        var number = peopleAndNumber.Value;

                        Console.WriteLine(people + " -> " + number);
                    }
                }
                str = Console.ReadLine().Split(' ');
            }
        }
    }
}
