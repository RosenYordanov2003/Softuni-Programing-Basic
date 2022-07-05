using System;

namespace Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tournaments = int.Parse(Console.ReadLine());
            double startpoints = double.Parse(Console.ReadLine());
            double points = 0;
            double avg = 0;
            double winpercent = 0;
            double total = 0;
            double winpercent2 = 0;
            for (int i = 1; i <= tournaments; i++)
            {
                string result = Console.ReadLine();
                if (result == "W")
                {
                    points += 2000;
                    winpercent++;
                }
                else if (result == "F")
                {
                    points += 1200;
                }
                else if (result == "SF")
                {
                    points += 720;
                }
                total = points + startpoints;
                avg = points / tournaments;
                winpercent2 = (winpercent / tournaments) * 100;
            }
            Console.WriteLine($"Final points: {total}");
            Console.WriteLine($"Average points: {Math.Floor(avg)}");
            Console.WriteLine($"{winpercent2:F2}%");
        }
    }
}
