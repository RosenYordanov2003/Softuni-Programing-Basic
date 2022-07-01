using System;

namespace Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameActor = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int judges = int.Parse(Console.ReadLine());
            double total = 0;
            double total2 = 0;

            for (int i = 1; i <= judges; i++)
            {
                string judgesName = Console.ReadLine();
                double judgesPoints = double.Parse(Console.ReadLine());
                int judgeLenght = judgesName.Length;
                total += ((judgeLenght * judgesPoints) / 2);
                total2 = total + academyPoints;


                if (total2 >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {nameActor} got a nominee for leading role with {total2:f1}!");
                    break;
                }

            }
            if (total2 < 1250.5)
            {
                double pointsNeed = 1250.5 - total2;
                Console.WriteLine($"Sorry, {nameActor} you need {pointsNeed:f1} more!");
            }
        }
    }
}
