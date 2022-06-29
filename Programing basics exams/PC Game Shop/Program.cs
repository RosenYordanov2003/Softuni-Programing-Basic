using System;

namespace PC_Game_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double percentFortnite = 0;
            double percentOverwatch = 0;
            double percentothers = 0;
            double percentHearthstone = 0;
            double countFortnite = 0;
            double countOverwatch = 0;
            double countothers = 0;
            double countHearthstone = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string name = Console.ReadLine();
                if (name == "Fornite")
                {
                    countFortnite++;
                }
                else if (name == "Overwatch")
                {
                    countOverwatch++;
                }

                else if (name == "Hearthstone")
                {
                    countHearthstone++;
                }
                else
                {
                    countothers++;
                }
            }
            percentFortnite = countFortnite / n * 100;
            percentothers = countothers / n * 100;
            percentOverwatch = countOverwatch / n * 100;
            percentHearthstone = countHearthstone / n * 100;
            Console.WriteLine($"Hearthstone - {percentHearthstone:f2}%");
            Console.WriteLine($"Fornite - {percentFortnite:f2}%");
            Console.WriteLine($"Overwatch - {percentOverwatch:f2}%");
            Console.WriteLine($"Others - {percentothers:f2}%");
        }
    }
}
