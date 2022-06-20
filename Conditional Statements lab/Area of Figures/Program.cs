using System;

namespace Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figura = Console.ReadLine();
            if (figura == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double Ssquare = side * side;
                Console.WriteLine("{0:f3}", Ssquare);
            }
            if (figura == "rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                double S = side1 * side2;
                Console.WriteLine("{0:f3}", S);
            }
            if (figura == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double Scirlce = Math.PI * (radius * radius);
                Console.WriteLine("{0:f3}", Scirlce);
            }
            if (figura == "triangle")
            {
                double side3 = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double S1 = (side3 * h) / 2;
                Console.WriteLine("{0:f3}", S1);
            }
        }
    }
}
