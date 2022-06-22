using System;

namespace Point_on_Rectangle_Border
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            var onLeftSide = (x == x1) && (y >= y1) && (y <= y2);
            var onRightSide = (x == x2) && (y >= y1) && (y <= y2);
            var onUpSide = (y == y1) && (x >= x1) && (x <= x2);
            var onDownSide = (y == y2) && (x >= x1) && (x <= x2);

            if (onLeftSide || onRightSide || onDownSide || onUpSide)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
