using System;

namespace For_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count_tournamet = int.Parse(Console.ReadLine());
            int starting_points = int.Parse(Console.ReadLine());
            double winpercent = 0;
            double averagepoints = 0;
            double points = 0;
            double counter = 0;
            double finalpoints = 0;
            for (int i = 0; i < count_tournamet; i++)
            {
                string phaseoftournamet = Console.ReadLine();
                if (phaseoftournamet == "W")
                {
                    points += 2000;
                    counter++;
                }
                if (phaseoftournamet == "F")
                {
                    points += 1200;
                }
                if (phaseoftournamet == "SF")
                {
                    points += 720;
                }
                finalpoints = starting_points + points;
                averagepoints = Math.Floor(points / count_tournamet);
                winpercent = counter / count_tournamet * 100;

            }
            Console.WriteLine($"Final points: {finalpoints}");
            Console.WriteLine($"Average points: {averagepoints}");
            Console.WriteLine($"{winpercent:f2}%");
        }
    }
    
}
