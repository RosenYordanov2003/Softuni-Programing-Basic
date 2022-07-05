using System;

namespace Basketball_Tournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            int countGames = 0;
            double wins = 0;
            double loses = 0;
            double totalGames = 0;
            while (name != "End of tournaments")
            {
                name = Console.ReadLine();
                if (name == "End of tournaments")
                {
                    break;
                }
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    int DesiTeamPoints = int.Parse(Console.ReadLine());
                    int OpponentsPoints = int.Parse(Console.ReadLine());
                    countGames++;
                    if (DesiTeamPoints > OpponentsPoints)
                    {
                        int diff = DesiTeamPoints - OpponentsPoints;
                        Console.WriteLine($"Game {countGames} of tournament {name}: win with {diff} points.");
                        wins++;
                    }
                    else
                    {
                        int diff = Math.Abs(DesiTeamPoints - OpponentsPoints);
                        Console.WriteLine($"Game {countGames} of tournament {name}: lost with {diff} points.");
                        loses++;
                    }
                }
                totalGames += countGames;
                countGames = 0;
            }
            double percentWins = wins / totalGames * 100;
            double percentLoses = loses / totalGames * 100;
            Console.WriteLine($"{percentWins:f2}% matches win");
            Console.WriteLine($"{percentLoses:f2}% matches lost");
        }
    }
}
