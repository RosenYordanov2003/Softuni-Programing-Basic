using System;

namespace Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hrizentemi = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int laleta = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string isholiday = Console.ReadLine();
            double sum = 0;
            double total = roses + laleta + hrizentemi;
            if (season == "Summer" || season == "Spring")
            {
                sum += 2 * hrizentemi;
                sum += 4.10 * roses;
                sum += 2.50 * laleta;
            }
            else if (season == "Winter" || season == "Autumn")
            {
                sum += 3.75 * hrizentemi;
                sum += 4.50 * roses;
                sum += 4.15 * laleta;
            }
            if (isholiday == "Y")
            {
                sum = sum + (sum * 15) / 100;
            }
            if (laleta > 7 && season == "Spring")
            {
                sum = sum - (sum * 5) / 100;
            }
            else if (roses >= 10 && season == "Winter")
            {
                sum = sum - (sum * 10) / 100;
            }
            if (total > 20)
            {
                sum = sum - (sum * 20) / 100;
            }
            sum = sum + 2;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
