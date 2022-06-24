using System;

namespace Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int feeforyear = int.Parse(Console.ReadLine());
            double pricekecove = feeforyear - feeforyear * 40 / 100.0;
            double pricekit = pricekecove - pricekecove * 20 / 100.0;
            double priceball = pricekit / 4;
            double priceaccessories = priceball / 5;
            double costs = feeforyear + pricekecove + pricekit + priceball + priceaccessories;
            Console.WriteLine(costs);

        }
    }
}
