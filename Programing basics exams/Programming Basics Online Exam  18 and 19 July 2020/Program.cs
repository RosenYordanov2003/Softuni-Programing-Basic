using System;

namespace Programming_Basics_Online_Exam__18_and_19_July_2020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameCompany = Console.ReadLine();
            int countTicketsforOldPeople = int.Parse(Console.ReadLine());
            int countTicketsforKids = int.Parse(Console.ReadLine());
            double oldTicket = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());
            double kidTicketPrice = oldTicket - (oldTicket * 70) / 100 + tax;
            double totalOld = oldTicket + tax;
            double total = kidTicketPrice * countTicketsforKids + totalOld * countTicketsforOldPeople;
            double agencyProfit = (total * 20) / 100;
            Console.WriteLine($"The profit of your agency from {nameCompany} tickets is {agencyProfit:f2} lv.");
        }
    }
}
