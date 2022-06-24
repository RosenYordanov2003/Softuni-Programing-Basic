using System;

namespace Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double skumriqKgPrice = double.Parse(Console.ReadLine());
            double cacaKgPrice = double.Parse(Console.ReadLine());
            double PalamudKg = double.Parse(Console.ReadLine());
            double SarafidKg = double.Parse(Console.ReadLine());
            int midiKg = int.Parse(Console.ReadLine());
            double midiPrice = 7.50;
            double totalmidi = midiPrice * midiKg;
            double palamudPrice = skumriqKgPrice + (skumriqKgPrice * 0.60);
            double palamudTotal = palamudPrice * PalamudKg;
            double sarafidPrice = cacaKgPrice + (cacaKgPrice * 0.80);
            double totalSerafid = sarafidPrice * SarafidKg;
            double total = totalmidi + totalSerafid + palamudTotal;
            Console.WriteLine($"{total:f2}");
        }
    }
}
