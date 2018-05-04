using System;

namespace _14._Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int pointFirstBoat = 0;
            int pointSecondBoat = 0;

            for (int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();
                if (command!="UPGRADE")
                {
                    if (i%2==0)
                    {
                        pointSecondBoat += command.Length;
                    }
                    else
                    {
                        pointFirstBoat += command.Length;
                    }
                    if (pointSecondBoat>=50|| pointFirstBoat>=50)
                    {
                        if (pointFirstBoat>pointSecondBoat)
                        {
                            Console.WriteLine((char)firstBoat);
                            return;
                        }
                        else
                        {
                            Console.WriteLine((char)secondBoat);
                            return;
                        }
                    }
                }
                else
                {
                    firstBoat = (char)(firstBoat+3);
                    secondBoat = (char)(secondBoat+3);

                }

            }

            if (pointFirstBoat > pointSecondBoat)
            {
                Console.WriteLine((char)firstBoat);
            }
            else
            {
                Console.WriteLine((char)secondBoat);
            }
        }
    }
}
