using System;

namespace Vet_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days1 = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double sum = 0;
            double total = 0;
            for (int days = 1; days <= days1; days++)
            {
                for (int i = 1; i <= hours; i++)
                {
                    if (days % 2 == 0 && i % 2 != 0)
                    {
                        sum += 2.50;
                    }
                    else if (days % 2 != 0 && i % 2 == 0)
                    {
                        sum += 1.25;
                    }
                    else
                    {
                        sum += 1;
                    }
                }
                total += sum;

                Console.WriteLine($"Day: {days} - {sum:f2} leva");
                sum = 0;
            }
            Console.WriteLine($"Total: {total:f2} leva");
        }
    }
}
