using System;

namespace Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int countnights = int.Parse(Console.ReadLine());
            double priceforstudio = 0;
            double priceforapartament = 0;
            double totalpriceforstudio = 0;
            double totalpricefoapartament = 0;

            if (month == "May" || month == "October")
            {
                priceforstudio = 50;
                priceforapartament = 65;
                totalpriceforstudio = 50 * countnights;
                totalpricefoapartament = 65 * countnights;

                if (countnights > 7 && countnights <= 14)
                {

                    totalpriceforstudio = totalpriceforstudio - (totalpriceforstudio * 5) / 100;
                    totalpricefoapartament = priceforapartament * countnights;
                }
                else if (countnights > 14)
                {
                    priceforstudio += 50;
                    totalpriceforstudio = countnights * 50;
                    totalpriceforstudio = totalpriceforstudio - (totalpriceforstudio * 30) / 100;
                    priceforapartament += 65;
                    totalpricefoapartament = countnights * 65;
                    totalpricefoapartament = totalpricefoapartament - (totalpricefoapartament * 10) / 100;

                }
            }
            else if (month == "June" || month == "September")
            {
                priceforstudio = 75.20;
                totalpriceforstudio = countnights * 75.20;
                priceforapartament = 68.70;
                totalpricefoapartament = countnights * priceforapartament;
                if (countnights > 14)
                {
                    totalpriceforstudio = totalpriceforstudio - (totalpriceforstudio * 20) / 100;
                    totalpricefoapartament = totalpricefoapartament - (totalpricefoapartament * 10) / 100;

                }
            }
            else if (month == "July" || month == "August")
            {
                priceforapartament = 77;
                totalpricefoapartament = priceforapartament * countnights;
                priceforstudio = 76;
                totalpriceforstudio = priceforstudio * countnights;
                if (countnights > 14)
                {
                    totalpricefoapartament = totalpricefoapartament - (totalpricefoapartament * 10) / 100;
                    totalpriceforstudio = priceforstudio * countnights;
                }
            }
            Console.WriteLine($"Apartment: {totalpricefoapartament:F2} lv.");
            Console.WriteLine($"Studio: {totalpriceforstudio:F2} lv.");
        }
    }
}
