using System;

namespace Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string location = Console.ReadLine();
                if (location == "End")
                {
                    break;
                }
                double moneyneed = double.Parse(Console.ReadLine()), totalsavedmoney = 0;
                while (totalsavedmoney < moneyneed)
                {
                    double money = double.Parse(Console.ReadLine());

                    totalsavedmoney += money;

                }
                Console.WriteLine($"Going to {location}!");
            }
        }
    }
}
