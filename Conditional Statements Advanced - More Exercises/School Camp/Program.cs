using System;

namespace School_Camp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string typeofGroup = Console.ReadLine();
            int countofStudents = int.Parse(Console.ReadLine());
            int countofnights = int.Parse(Console.ReadLine());
            string sport = "";
            double price = 0;
            if (season == "Winter")
            {
                if (typeofGroup == "mixed")
                {
                    sport = "Ski";
                    price = 10 * countofnights * countofStudents;
                }
                else if (typeofGroup == "boys")
                {
                    price = 9.60 * countofnights * countofStudents;
                    sport = "Judo";
                }
                else if (typeofGroup == "girls")
                {
                    price = 9.60 * countofnights * countofStudents;
                    sport = "Gymnastics";
                }
            }
            else if (season == "Summer")
            {
                if (typeofGroup == "mixed")
                {
                    sport = "Swimming";
                    price = 20 * countofStudents * countofnights;
                }
                else if (typeofGroup == "boys")
                {
                    sport = "Football";
                    price = 15 * countofStudents * countofnights;
                }
                else if (typeofGroup == "girls")
                {
                    sport = "Volleyball";
                    price = 15 * countofStudents * countofnights;

                }
            }
            else if (season == "Spring")
            {
                if (typeofGroup == "mixed")
                {
                    sport = "Cycling";
                    price = 9.50 * countofnights * countofStudents;
                }
                else if (typeofGroup == "girls")
                {
                    sport = "Athletics";
                    price = 7.20 * countofnights * countofStudents;
                }
                else if (typeofGroup == "boys")
                {
                    sport = "Tennis";
                    price = 7.20 * countofnights * countofStudents;
                }
            }
            if (countofStudents >= 50)
            {
                price = price - (price * 50) / 100;
            }
            else if (countofStudents >= 20 && countofStudents < 50)
            {
                price = price - (price * 15) / 100;
            }
            else if (countofStudents >= 10 && countofStudents < 20)
            {
                price = price - (price * 5) / 100;
            }
            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}
