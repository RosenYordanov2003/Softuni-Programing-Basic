using System;

namespace Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string partofdays = Console.ReadLine();
            string outfit = "";
            string shoes = "";
            if (degrees > 10 && degrees <= 18)
            {
                if (partofdays == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (partofdays == "Afternoon")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (partofdays == "Evening")
                {
                    outfit = "Shirt";
                    shoes = " Moccasins";
                }
            }
            if (degrees > 18 && degrees <= 24)
            {
                if (partofdays == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (partofdays == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (partofdays == "Evening")
                {
                    outfit = "Shirt";
                    shoes = " Moccasins";
                }
            }
            if (degrees >= 25)
            {
                if (partofdays == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (partofdays == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (partofdays == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
