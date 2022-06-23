using System;

namespace Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double countoffoodfordogs = double.Parse(Console.ReadLine());
            double countoffoodforcats = double.Parse(Console.ReadLine());
            double priceoffoddfordogs = 2.50;
            double priceoffoodforcats = 4;
            double totalsum = countoffoodfordogs * priceoffoddfordogs + countoffoodforcats * priceoffoodforcats;
            Console.WriteLine(totalsum + " " + "lv.");
        }
    }
}
