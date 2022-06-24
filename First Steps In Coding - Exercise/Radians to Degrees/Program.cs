using System;

namespace Radians_to_Degrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radiani = double.Parse(Console.ReadLine());
            double gradus = radiani * 180 / Math.PI;
            Console.WriteLine(gradus);
        }
    }
}
