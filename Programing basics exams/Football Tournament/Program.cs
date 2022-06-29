using System;

namespace Football_Tournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            int countWins = 0;
            int countLoses = 0;
            int countDraws = 0;
            int pooints = 0;
            for (int i = 1; i <= n; i++)
            {
                char result = char.Parse(Console.ReadLine());
                if (result == 'W')
                {
                    countWins++;
                    pooints += 3;
                }
                else if (result == 'L')
                {
                    countLoses++;
                }
                else if (result == 'D')
                {
                    countDraws++;
                    pooints += 1;
                }
            }
            double winP = (double)countWins / n * 100;

            if (n > 0)
            {
                Console.WriteLine($"{team} has won {pooints} points during this season.");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {countWins}");
                Console.WriteLine($"## D: {countDraws}");
                Console.WriteLine($"## L: {countLoses}");
                Console.WriteLine($"Win rate: {winP:f2}%");
            }
            else
            {
                Console.WriteLine($"{team} hasn't played any games during this season.");
            }
        }
    }
}
