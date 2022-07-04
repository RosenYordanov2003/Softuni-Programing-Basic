using System;

namespace Fruit_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double strawberyPrice = double.Parse(Console.ReadLine());
            double bananaCount = double.Parse(Console.ReadLine());
            double orangeCount = double.Parse(Console.ReadLine());
            double raspberry = double.Parse(Console.ReadLine());
            double strawberyCount = double.Parse(Console.ReadLine());
            double raspberyPirce = strawberyPrice - (strawberyPrice * 50) / 100;
            double orangePrice = raspberyPirce - (raspberyPirce * 40) / 100;
            double bananaPrice = raspberyPirce - (raspberyPirce * 80) / 100;
            double total = raspberyPirce * raspberry + strawberyPrice * strawberyCount + orangePrice * orangeCount + bananaCount * bananaPrice;
            Console.WriteLine($"{total:f2}");
        }
    }
}
