using System;

namespace Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double countOfPens = double.Parse(Console.ReadLine());
            double countOfMarkers = double.Parse(Console.ReadLine());
            double countliterpreparat = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double pricePnes = 5.80;
            double priceMarkers = 7.20;
            double pricePerPart = 1.20;
            double penSum = countOfPens * pricePnes;
            double markerSum = countOfMarkers * priceMarkers;
            double preparatsum = countliterpreparat * pricePerPart;
            double sum = penSum + markerSum + preparatsum;
            double discount = sum - (sum * percent / 100);
            Console.WriteLine(discount);
        }
    }
}
