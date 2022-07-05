using System;

namespace Darts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int startPoints = 301;
            int goodShots = 0;
            int badShots = 0;
            while (startPoints != 0)
            {
                string shot = Console.ReadLine();

                if (shot == "Retire")
                {
                    Console.WriteLine($"{name} retired after {badShots} unsuccessful shots.");
                    break;
                }

                int points = int.Parse(Console.ReadLine());

                if (shot == "Single")
                {
                    if (points <= startPoints && startPoints > 0)
                    {
                        startPoints -= points;
                        goodShots++;
                    }
                    else
                    {
                        badShots++;
                    }
                }
                if (shot == "Double")
                {
                    points *= 2;
                    if (points <= startPoints && startPoints > 0)
                    {

                        startPoints -= points;
                        goodShots++;
                    }
                    else
                    {
                        badShots++;
                    }
                }
                if (shot == "Triple")
                {
                    points *= 3;
                    if (points <= startPoints && startPoints > 0)
                    {

                        startPoints -= points;
                        goodShots++;
                    }
                    else
                    {
                        badShots++;
                    }
                }
                if (startPoints == 0)
                {
                    Console.WriteLine($"{name} won the leg with {goodShots} shots.");
                    break;
                }
            }
        }
    }
}
