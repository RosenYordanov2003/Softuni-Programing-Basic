using System;

namespace Programming_Basics_Online_Exam___9_and_10_March_2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceTennisRocket = double.Parse(Console.ReadLine());
            int countRockets = int.Parse(Console.ReadLine());
            int countBoots = int.Parse(Console.ReadLine());
            double boots = priceTennisRocket / 6;
            double priceBoots = boots * countBoots;
            double priceRockets = countRockets * priceTennisRocket;
            double total = priceRockets + priceBoots;
            double others = (total * 0.20);
            double total1 = total + others;
            double priceDjokovic = total1 / 8;
            double priceSponsors = total1 * 7 / 8;
            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(priceDjokovic)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(priceSponsors)}");
        }
    }
}
