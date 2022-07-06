using System;

namespace Easter_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string txtDatas = Console.ReadLine();
            int countNights = int.Parse(Console.ReadLine());
            double sum = 0;
            if (txtDatas == "21-23")
            {
                if (input == "France")
                {
                    sum = 30 * countNights;
                }
                else if (input == "Italy")
                {
                    sum = 28 * countNights;
                }
                else if (input == "Germany")
                {
                    sum = 32 * countNights;
                }
            }
            else if (txtDatas == "24-27")
            {
                if (input == "France")
                {
                    sum = 35 * countNights;
                }
                else if (input == "Italy")
                {
                    sum = 32 * countNights;
                }
                else if (input == "Germany")
                {
                    sum = 37 * countNights;
                }
            }
            else if (txtDatas == "28-31")
            {
                if (input == "France")
                {
                    sum = 40 * countNights;
                }
                else if (input == "Italy")
                {
                    sum = 39 * countNights;
                }
                else if (input == "Germany")
                {
                    sum = 43 * countNights;
                }
            }
            Console.WriteLine($"Easter trip to {input} : {sum:f2} leva.");
        }
    }
}
