using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            

            var nameEmail = new Dictionary<string, string>();

            while (name!="stop")
            {
                var email = Console.ReadLine();

                var testEmail = email.Split('.');
                var lastSymbol = testEmail[testEmail.Length - 1];

                if (lastSymbol!="us" && lastSymbol != "uk")
                {
                    nameEmail[name] = email;
                }

                name = Console.ReadLine();
            }

            foreach (var personEmail in nameEmail)
            {
                name = personEmail.Key;
                var email = personEmail.Value;

                Console.WriteLine(name+" -> "+email);
            }
        }
    }
}
