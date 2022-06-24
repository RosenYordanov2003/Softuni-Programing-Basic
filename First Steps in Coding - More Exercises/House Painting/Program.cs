using System;

namespace House_Painting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double lenghtWall = double.Parse(Console.ReadLine());
            double hRoof = double.Parse(Console.ReadLine());
            double Frontwall = (h * lenghtWall);
            double window = 1.5 * 1.5;
            double totalFrontWall = Frontwall * 2 - 2 * window; ;
            double backWall = h * h;
            double backEntry = 2 * 1.2;
            double totalBackWalls = 2 * backWall - backEntry;
            double totalWalss = totalBackWalls + totalFrontWall;
            double green = totalWalss / 3.4;
            double roof = 2 * (h * lenghtWall);
            double triangle = 2 * (h * hRoof / 2);
            double totalRoof = roof + triangle;
            double red = totalRoof / 4.3;
            Console.WriteLine($"{green:f2}");
            Console.WriteLine($"{red:f2}");
        }
    }
}
