using System;

namespace Cinema_Voucher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            string movie = string.Empty;
            double price = 0;
            int ticketsCount = 0;
            int productsCount = 0;

            while (true)
            {
                movie = Console.ReadLine();
                int letter1 = (char)movie[0];
                int letter2 = (char)movie[1];
                if (movie == "End")
                {
                    break;
                }
                if (movie.Length > 8)
                {
                    price = letter1 + letter2;
                    if (sum >= price)
                    {
                        ticketsCount++;
                    }
                }
                if (movie.Length <= 8)
                {
                    price = letter1;
                    if (sum > price)
                    {
                        productsCount++;
                    }
                }
                if (sum - price > 0)
                {
                    sum -= price;
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine($"{ticketsCount}");
            Console.WriteLine($"{productsCount}");
        }
    }
}
