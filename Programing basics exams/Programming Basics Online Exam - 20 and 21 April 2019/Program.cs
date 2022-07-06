using System;
namespace Programming_Basics_Online_Exam___20_and_21_April_2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countKozunak = int.Parse(Console.ReadLine());
            int countEggs = int.Parse(Console.ReadLine());
            int countCookies = int.Parse(Console.ReadLine());
            double totalPrice = countKozunak * 3.20 + countEggs * 4.35 + countCookies * 5.40 + countEggs * 12 * 0.15;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
