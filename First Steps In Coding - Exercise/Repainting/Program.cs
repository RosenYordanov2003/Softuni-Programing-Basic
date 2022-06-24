using System;

namespace Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylonkvmeters = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int razreditel = int.Parse(Console.ReadLine());
            int buildershours = int.Parse(Console.ReadLine());
            double pricefornylononmeter = 1.50;
            double pricepaintforleter = 14.50;
            double razdeliterforpaintformeter = 5.00;
            double bags = 0.40;

            double nylonsum = nylonkvmeters * pricefornylononmeter + 2 * 1.50;
            double bonuspaint = (paint * 10 / 100.0) * pricepaintforleter;
            double paintsum = paint * pricepaintforleter + bonuspaint;
            double totalsumformaterials = razreditel * razdeliterforpaintformeter + nylonsum + paintsum + bags;
            double priceforbuilders = (totalsumformaterials * 30 / 100.0) * buildershours;

            double totalsum = totalsumformaterials + priceforbuilders;
            Console.WriteLine(totalsum);
        }
    }
}
