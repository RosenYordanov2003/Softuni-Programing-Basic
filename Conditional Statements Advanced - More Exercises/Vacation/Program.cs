using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string location = "";
            string place = "";
            if (budget < 1000)
            {
                location = "Camp";
                if (season == "Summer")
                {
                    place = "Alaska";
                    budget = (budget * 65) / 100;
                }
                else if (season == "Winter")
                {
                    place = "Morocco";
                    budget = (budget * 45) / 100;
                }
            }
            else if (budget > 100 && budget <= 3000)
            {
                location = "Hut";
                if (season == "Winter")
                {
                    place = "Morocco";
                    budget = (budget * 60) / 100;
                }
                else if (season == "Summer")
                {
                    place = "Alaska";
                    budget = (budget * 80) / 100;
                }
            }
            else if (budget > 3000)
            {

                location = "Hotel";
                if (season == "Winter")
                {

                    place = "Morocco";
                    budget = (budget * 90) / 100;
                }
                else if (season == "Summer")
                {
                    place = "Alaska";
                    budget = (budget * 90) / 100;
                }
            }
            Console.WriteLine($"{place} - {location} - {budget:f2}");
        }
    }
}
