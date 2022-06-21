using System;

namespace Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string assessment = Console.ReadLine();
            days = days - 1;
            double price = 0;
            double priceforroom = 0;
            if (days <= 10)
            {
                if (room == "room for one person")
                {
                    priceforroom += 18;
                    price = priceforroom * days;
                }

                else if (room == "apartment")
                {
                    priceforroom += 25;
                    price = priceforroom * days;
                    price = price - (price * 30) / 100;
                }
                else if (room == "president apartment")
                {
                    priceforroom += 35;
                    price = priceforroom * days;
                    price = price - (price * 10) / 100;

                }

            }
            else if (days > 10 && days <= 15)
            {
                if (room == "room for one person")
                {
                    priceforroom += 18;
                    price = priceforroom * days;
                }
                else if (room == "apartment")
                {
                    priceforroom += 25;
                    price = priceforroom * days;
                    price = price - (price * 35) / 100;
                }
                else if (room == "president apartment")
                {
                    priceforroom += 35;
                    price = priceforroom * days;
                    price = price - (price * 15) / 100;
                }
            }
            else if (days > 15)
            {
                if (room == "room for one person")
                {
                    priceforroom += 18;
                    price = priceforroom * days;


                }
                else if (room == "apartment")
                {
                    priceforroom += 25;
                    price = priceforroom * days;
                    price = price - (price * 50) / 100;
                }
                else if (room == "president apartment")
                {
                    priceforroom += 35;
                    price = priceforroom * days;
                    price = price - (price * 20) / 100;
                }
            }
            if (assessment == "positive")
            {
                price = price + (price * 0.25);
            }
            else
            {
                price = price - (price * 10) / 100;
            }
            Console.WriteLine($"{price:F2}");
        }
    }
}
