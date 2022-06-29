using System;

namespace ConsoleApp242
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());
            double lounge = double.Parse(Console.ReadLine());
            double umbrelaPirce = double.Parse(Console.ReadLine());
            double peopleLounge = Math.Ceiling(people - (people * 25) / 100.0);
            double pricelounge = peopleLounge * lounge;
            double peopleUmrella = Math.Ceiling(people / 2.0);
            double umbrellaPrice = peopleUmrella * umbrelaPirce;
            double taxtotal = people * tax;
            double total = taxtotal + pricelounge + umbrellaPrice;
            Console.WriteLine($"{total:f2} lv.");
        }
    }
}
