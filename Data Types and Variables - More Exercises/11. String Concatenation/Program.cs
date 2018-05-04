using System;

namespace _11._String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimeter = char.Parse(Console.ReadLine());
            string oddorEven = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = "";

            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();
                if (oddorEven=="odd" && i%2==1)
                {
                    result += word;
                    if (i != n && i != n-1)
                    {
                        result += delimeter;
                    }

                }
                else if (oddorEven == "even"&& i %2==0)
                
                {
                    result += word;
                    if (i != n && i != n-1)
                    {
                        result += delimeter;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
