using System;

namespace Painting_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string color = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double sum = 0;
            if (size == "Large")
            {
                if (color == "Red")
                {
                    sum = count * 16;
                }
                else if (color == "Green")
                {
                    sum = count * 12;
                }
                else if (color == "Yellow")
                {
                    sum = count * 9;
                }
            }
            else if (size == "Medium")
            {
                if (color == "Red")
                {
                    sum = count * 13;
                }
                else if (color == "Green")
                {
                    sum = count * 9;
                }
                else if (color == "Yellow")
                {
                    sum = count * 7;
                }
            }
            else if (size == "Small")
            {
                if (color == "Red")
                {
                    sum = count * 9;
                }
                else if (color == "Green")
                {
                    sum = count * 8;
                }
                else if (color == "Yellow")
                {
                    sum = count * 5;
                }
            }
            sum = sum - (sum * 35) / 100;
            Console.WriteLine($"{sum:f2} leva.");
        }
    }
}
