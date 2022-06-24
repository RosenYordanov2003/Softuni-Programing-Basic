using System;

namespace Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double natrupanalihva = depositSum * percent / 100.0;
            double lihvaPermonth = natrupanalihva / 12;
            double totalSum = depositSum + time * lihvaPermonth;
            Console.WriteLine(totalSum);
        }
    }
}
