using System;

namespace Oscars_week_in_cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string typeRoom = Console.ReadLine();
            int countBoughtTickets = int.Parse(Console.ReadLine());
            double sum = 0;
            if (typeRoom == "normal")
            {
                if (movie == "A Star Is Born")
                {
                    sum = countBoughtTickets * 7.50;
                }
                else if (movie == "Bohemian Rhapsody")
                {
                    sum = countBoughtTickets * 7.35;
                }
                else if (movie == "Green Book")
                {
                    sum = countBoughtTickets * 8.15;
                }
                else if (movie == "The Favourite")
                {
                    sum = countBoughtTickets * 8.75;
                }
            }
            else if (typeRoom == "luxury")
            {
                if (movie == "A Star Is Born")
                {
                    sum = countBoughtTickets * 10.50;
                }
                else if (movie == "Bohemian Rhapsody")
                {
                    sum = countBoughtTickets * 9.45;
                }
                else if (movie == "Green Book")
                {
                    sum = countBoughtTickets * 10.25;
                }
                else if (movie == "The Favourite")
                {
                    sum = countBoughtTickets * 11.55;
                }
            }
            else if (typeRoom == "ultra luxury")
            {
                if (movie == "A Star Is Born")
                {
                    sum = countBoughtTickets * 13.50;
                }
                else if (movie == "Bohemian Rhapsody")
                {
                    sum = countBoughtTickets * 12.75;
                }
                else if (movie == "Green Book")
                {
                    sum = countBoughtTickets * 13.25;
                }
                else if (movie == "The Favourite")
                {
                    sum = countBoughtTickets * 13.95;
                }
            }
            Console.WriteLine($"{movie} -> {sum:f2} lv.");
        }
    }
}
