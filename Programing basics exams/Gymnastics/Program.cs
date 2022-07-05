using System;

namespace Gymnastics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            double pointsHard = 0;
            double pointsShow = 0;
            string equipment = Console.ReadLine();
            if (country == "Bulgaria")
            {
                if (equipment == "ribbon")
                {
                    pointsHard = 9.600;
                    pointsShow = 9.400;
                }
                else if (equipment == "hoop")
                {
                    pointsHard = 9.550;
                    pointsShow = 9.750;
                }
                else if (equipment == "rope")
                {
                    pointsHard = 9.500;
                    pointsShow = 9.400;
                }
            }
            else if (country == "Italy")
            {
                if (equipment == "ribbon")
                {
                    pointsHard = 9.200;
                    pointsShow = 9.500;
                }
                else if (equipment == "hoop")
                {
                    pointsHard = 9.450;
                    pointsShow = 9.350;
                }
                else if (equipment == "rope")
                {
                    pointsHard = 9.700;
                    pointsShow = 9.150;
                }
            }
            else if (country == "Russia")
            {
                if (equipment == "ribbon")
                {
                    pointsHard = 9.100;
                    pointsShow = 9.400;
                }
                else if (equipment == "hoop")
                {
                    pointsHard = 9.300;
                    pointsShow = 9.800;
                }
                else if (equipment == "rope")
                {
                    pointsHard = 9.600;
                    pointsShow = 9.000;
                }
            }
            double total = pointsHard + pointsShow;
            double pointsneed = 20;
            double diff = pointsneed - total;
            double percent = (diff / pointsneed) * 100;
            Console.WriteLine($"The team of {country} get {total:f3} on {equipment}.");
            Console.WriteLine($"{percent:f2}%");
        }
    }
}
