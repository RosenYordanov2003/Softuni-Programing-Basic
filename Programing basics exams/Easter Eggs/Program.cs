using System;

namespace Easter_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int redCount = 0;
            int orangeCount = 0;
            int blueCount = 0;
            int greenCount = 0;
            int max = 0;
            string color = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                color = Console.ReadLine();
                if (color == "red")
                {
                    redCount++;
                }
                else if (color == "blue")
                {
                    blueCount++;
                }
                else if (color == "orange")
                {
                    orangeCount++;
                }
                else if (color == "green")
                {
                    greenCount++;
                }
            }
            if (redCount > greenCount && redCount > blueCount && redCount > orangeCount)
            {
                max = redCount;
                color = "red";
            }
            else if (greenCount > redCount && greenCount > blueCount && greenCount > orangeCount)
            {
                max = greenCount;
                color = "green";
            }
            else if (blueCount > redCount && blueCount > orangeCount && blueCount > greenCount)
            {
                max = blueCount;
                color = "blue";
            }
            else if (orangeCount > blueCount && orangeCount > greenCount && orangeCount > redCount)
            {
                max = orangeCount;
                color = "orange";
            }
            Console.WriteLine($"Red eggs: {redCount}");
            Console.WriteLine($"Orange eggs: {orangeCount}");
            Console.WriteLine($"Blue eggs: {blueCount}");
            Console.WriteLine($"Green eggs: {greenCount}");
            Console.WriteLine($"Max eggs: {max} -> {color}");
        }
    }
}
