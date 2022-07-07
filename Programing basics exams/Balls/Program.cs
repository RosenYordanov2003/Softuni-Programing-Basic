using System;

namespace Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countRed = 0;
            int countBlack = 0;
            int countYellow = 0;
            int countWhite = 0;
            int countOrange = 0;
            int countOtherColor = 0;
            int points = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string color = Console.ReadLine();
                if (color == "red")
                {
                    points += 5;
                    countRed++;
                }
                else if (color == "orange")
                {
                    points += 10;
                    countOrange++;
                }
                else if (color == "yellow")
                {
                    points += 15;
                    countYellow++;
                }
                else if (color == "white")
                {
                    points += 20;
                    countWhite++;
                }
                else if (color == "black")
                {
                    countBlack++;
                    points = points / 2;
                }
                else
                {
                    countOtherColor++;
                }
            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {countRed}");
            Console.WriteLine($"Orange balls: {countOrange}");
            Console.WriteLine($"Yellow balls: {countYellow}");
            Console.WriteLine($"White balls: {countWhite}");
            Console.WriteLine($"Other colors picked: {countOtherColor}");
            Console.WriteLine($"Divides from black balls: {countBlack}");
        }
    }
}
