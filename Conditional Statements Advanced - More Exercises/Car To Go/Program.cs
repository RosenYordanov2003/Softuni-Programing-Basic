using System;

namespace Car_To_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string classcar = "";
            string typeCar = "";
            if (budget <= 100)
            {
                classcar = "Economy class";
                if (season == "Winter")
                {
                    typeCar = "Jeep";
                    budget = (budget * 65) / 100;
                }
                else if (season == "Summer")
                {
                    typeCar = "Cabrio";
                    budget = (budget * 35) / 100;
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                classcar = "Compact class";
                if (season == "Winter")
                {
                    typeCar = "Jeep";
                    budget = (budget * 80) / 100;
                }
                else if (season == "Summer")
                {
                    typeCar = "Cabrio";
                    budget = (budget * 45) / 100;
                }
            }
            else if (budget > 500)
            {
                classcar = "Luxury class";
                typeCar = "Jeep";
                budget = (budget * 90) / 100;
            }
            Console.WriteLine($"{classcar}");
            Console.WriteLine($"{typeCar} - {budget:f2}");
        }
    }
}
