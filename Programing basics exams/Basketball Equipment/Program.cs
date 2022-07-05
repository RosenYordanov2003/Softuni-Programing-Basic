using System;

namespace Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tax = double.Parse(Console.ReadLine());
            double bootsprice = tax - (tax * 0.40);
            double kit = bootsprice - (bootsprice * 0.20);
            double ball = kit / 4;
            double other = ball / 5;
            double total = bootsprice + kit + ball + other + tax;
            Console.WriteLine($"{total:f2}");
        }
    }
}
