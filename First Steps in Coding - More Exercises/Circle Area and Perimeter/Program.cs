using System;

namespace Circle_Area_and_Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double s = Math.PI * (r * r);
            double P = 2 * Math.PI * r;
            Console.WriteLine($"{s:f2}");
            Console.WriteLine($"{P:f2}");
        }
    }
}
