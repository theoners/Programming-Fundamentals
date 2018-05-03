using System;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = a; i < b; i++)
            {
                count++;
            }
            if (count < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int j = a; j <= b - 4; j++)
                {
                    for (int k = a + 1; k <= b - 3; k++)
                    {
                        for (int l = a + 2; l <= b - 2; l++)
                        {
                            for (int m = a + 3; m <= b - 1; m++)
                            {
                                for (int n = a + 4; n <= b; n++)
                                {

                                    if (j != k && k != l && l != m && m != n && j < k && k < l && l < m && m < n)
                                    {
                                        Console.Write(j + " ");
                                        Console.Write(k + " ");
                                        Console.Write(l + " ");
                                        Console.Write(m + " ");
                                        Console.Write(n);
                                        Console.WriteLine("");
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
