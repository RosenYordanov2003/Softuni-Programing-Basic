using System;

namespace Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countofchickenmenu = int.Parse(Console.ReadLine());
            int countoffishmenu = int.Parse(Console.ReadLine());
            int countofvegmenu = int.Parse(Console.ReadLine());
            double pricechickenmenu = 10.35;
            double pricefishmenu = 12.40;
            double pricevegmenu = 8.15;
            double deliverly = 2.50;
            double chickenmenusum = countofchickenmenu * pricechickenmenu;
            double fishmenusum = countoffishmenu * pricefishmenu;
            double vegsmenusum = countofvegmenu * pricevegmenu;
            double sum = vegsmenusum + fishmenusum + chickenmenusum;
            double desert = sum - sum * 20 / 100.0;
            double desertsum = sum - desert;
            double totalsum = sum + desertsum + deliverly;
            Console.WriteLine(totalsum);
        }
    }
}
