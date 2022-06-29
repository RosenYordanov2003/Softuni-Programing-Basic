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
            double points
                = 0;
            double totalPoints = 0;
            for (int i = 1; i <= judges; i++)
            {
                string judgesName = Console.ReadLine();
                double judgesPoints = double.Parse(Console.ReadLine());
                int judgeLenght = judgesName.Length;
                points += ((judgeLenght * judgesPoints) / 2);
                totalPoints = points + academyPoints;


                if (totalPoints >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {nameActor} got a nominee for leading role with {totalPoints:f1}!");
                    break;
                }

            }
            if (totalPoints < 1250.5)
            {
                double pointsNeed = 1250.5 - totalPoints;
                Console.WriteLine($"Sorry, {nameActor} you need {pointsNeed:f1} more!");
            }
        }
    }
}
