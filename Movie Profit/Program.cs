using System;

namespace Movie_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double ticketsPrice = double.Parse(Console.ReadLine());
            double percent = int.Parse(Console.ReadLine());
            double total = days * (tickets * ticketsPrice);
            double percent1 = (total * percent) / 100;
            double total1 = total - percent1;
            Console.WriteLine($"The profit from the movie {movie} is {total1:f2} lv.");
        }
    }
}
