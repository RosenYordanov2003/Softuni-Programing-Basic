using System;

namespace ilm_Premiere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string packet = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());
            double sum = 0;
            if (movie == "John Wick")
            {
                if (packet == "Drink")
                {
                    sum = 12 * tickets;
                }
                else if (packet == "Popcorn")
                {
                    sum = 15 * tickets;
                }
                else if (packet == "Menu")
                {
                    sum = 19 * tickets;
                }
            }
            else if (movie == "Star Wars")
            {
                if (packet == "Drink")
                {
                    sum = 18 * tickets;
                }
                else if (packet == "Popcorn")
                {
                    sum = 25 * tickets;
                }
                else if (packet == "Menu")
                {
                    sum = 30 * tickets;
                }
                if (tickets >= 4)
                {
                    sum = sum - (sum * 30) / 100;
                }
            }
            else if (movie == "Jumanji")
            {
                if (packet == "Drink")
                {
                    sum = 9 * tickets;
                }
                else if (packet == "Popcorn")
                {
                    sum = 11 * tickets;
                }
                else if (packet == "Menu")
                {
                    sum = 14 * tickets;
                }
                if (tickets == 2)
                {
                    sum = sum - (sum * 15) / 100;
                }
            }
            Console.WriteLine($"Your bill is {sum:f2} leva.");
        }
    }
}
