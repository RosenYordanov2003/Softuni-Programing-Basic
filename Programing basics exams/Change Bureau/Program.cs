using System;

namespace Change_Bureau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double countBitcoins = int.Parse(Console.ReadLine());
            double uans = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());
            double bitcoinInlev = 1168;
            double bitcoinAtEuro = bitcoinInlev / 1.95;
            double uansInlev = 0.15 * 1.76;
            double uansinEuro = uansInlev / 1.95;
            double total = uansinEuro * uans + bitcoinAtEuro * countBitcoins;
            total = total - (total * comission) / 100;

            Console.WriteLine($"{total:f2}");
        }
    }
}
