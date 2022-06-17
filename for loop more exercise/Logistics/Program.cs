using System;

namespace Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bus = 0;
            double train = 0;
            double truck = 0;
            double total = 0;
            double traincount = 0;
            double buscount = 0;
            double truckcount = 0;
            double countCargo = int.Parse(Console.ReadLine());
            for (int i = 1; i <= countCargo; i++)
            {
                double tovar = double.Parse(Console.ReadLine());
                total += tovar;
                if (tovar <= 3)
                {
                    bus += 200 * tovar;
                    buscount += tovar;
                }
                else if (tovar >= 12)
                {
                    train += 120 * tovar;
                    traincount += tovar;
                }
                else if (tovar >= 4 && tovar <= 11)
                {
                    truck += 175 * tovar;
                    truckcount += tovar;
                }
            }
            double av = (truck + train + bus) / total;
            double p1 = (buscount / total) * 100.0;
            double p2 = (truckcount / total) * 100.0;
            double p3 = (traincount / total) * 100.0;
            Console.WriteLine($"{av:f2}");
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}
