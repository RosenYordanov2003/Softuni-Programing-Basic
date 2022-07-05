using System;

namespace Football_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countwins = 0;
            int countlosts = 0;
            int countdraws = 0;
            for (int i = 1; i <= 3; i++)
            {
                string result = Console.ReadLine();
                int result1 = result[0];
                int result2 = result[2];
                if (result1 > result2)
                {
                    countwins++;
                }
                else if (result1 == result2)
                {
                    countdraws++;
                }
                else if (result1 < result2)
                {
                    countlosts++;
                }
            }
            Console.WriteLine($"Team won {countwins} games.");
            Console.WriteLine($"Team lost {countlosts} games.");
            Console.WriteLine($"Drawn games: {countdraws}");
        }
    }
}
