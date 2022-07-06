using System;

namespace Easter_Bakery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceBrashnoKg = double.Parse(Console.ReadLine());
            double brashnoKg = double.Parse(Console.ReadLine());
            double sugarKg = double.Parse(Console.ReadLine());
            int countEggs = int.Parse(Console.ReadLine());
            int packetsMaq = int.Parse(Console.ReadLine());
            double priceShugar = priceBrashnoKg - (priceBrashnoKg * 25) / 100;
            double priceForOneEgg = priceBrashnoKg + (priceBrashnoKg * 10) / 100;
            double maq = priceShugar - (priceShugar * 80) / 100;
            double totlal = priceBrashnoKg * brashnoKg + sugarKg * priceShugar + countEggs * priceForOneEgg + maq * packetsMaq;
            Console.WriteLine($"{totlal:f2}");
        }
    }
}
