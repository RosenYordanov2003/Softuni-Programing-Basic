using System;

namespace Celsius_to_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gardus = double.Parse(Console.ReadLine());
            double f = gardus * 9 / 5 + 32;
            Console.WriteLine($"{f:f2}");
        }
    }
}
