using System;

namespace Training_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double lenghtinCm = lenght * 100;
            double width = double.Parse(Console.ReadLine());
            double widthinCm = width * 100;
            double widthWithKoridor = widthinCm - 100;
            double desk = Math.Floor(widthWithKoridor / 70);
            double rows = Math.Floor(lenghtinCm / 120);
            double Places = desk * rows;
            double total = Places - 3;
            Console.WriteLine(Math.Floor(total));
        }
    }
}
