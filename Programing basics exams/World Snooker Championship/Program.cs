using System;

namespace World_Snooker_Championship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string etap = Console.ReadLine();
            string typeTicket = Console.ReadLine();
            int countTickets = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            double ticketprice = 0;
            double pictureWithTrophy = 0;
            if (etap == "Final")
            {
                if (typeTicket == "VIP")
                {
                    ticketprice = 400;
                }
                else if (typeTicket == "Premium")
                {
                    ticketprice = 160.66;
                }
                else if (typeTicket == "Standard")
                {
                    ticketprice = 110.10;
                }
            }
            else if (etap == "Semi final")
            {
                if (typeTicket == "VIP")
                {
                    ticketprice = 300.40;
                }
                else if (typeTicket == "Premium")
                {
                    ticketprice = 125.22;
                }
                else if (typeTicket == "Standard")
                {
                    ticketprice = 75.88;
                }
            }
            else if (etap == "Quarter final")
            {
                if (typeTicket == "VIP")
                {
                    ticketprice = 118.90;
                }
                else if (typeTicket == "Premium")
                {
                    ticketprice = 105.20;
                }
                else if (typeTicket == "Standard")
                {
                    ticketprice = 55.50;
                }
            }
            double totalprice = ticketprice * countTickets;
            if (totalprice > 4000)
            {
                totalprice = totalprice - (totalprice * 0.25);
                pictureWithTrophy = 0;
            }
            else if (totalprice > 2500)
            {
                totalprice = totalprice - (totalprice * 0.10);
            }
            if (symbol == "Y" && totalprice < 3000)
            {
                pictureWithTrophy = 40 * countTickets;
            }
            else
            {
                pictureWithTrophy = 0;
            }
            double total = totalprice + pictureWithTrophy;
            Console.WriteLine($"{total:f2}");


        }
    }
}
