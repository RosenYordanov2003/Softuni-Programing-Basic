using System;

namespace Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1++;
                }
                else if (num >= 200 && num <= 399)
                {
                    p2++;
                }
                else if (num >= 300 && num <= 599)
                {
                    p3++;
                }
                else if (num >= 600 && num <= 799)
                {
                    p4++;
                }
                else if (num >= 800)
                {
                    p5++;
                }
            }
            double Percentp1 = p1 * 100 / n;
            double Percentp2 = p2 * 100 / n;
            double Percentp3 = p3 * 100 / n;
            double Percentp4 = p4 * 100 / n;
            double Percentp5 = p5 * 100 / n;
            Console.WriteLine("{0:f2}%", Percentp1);
            Console.WriteLine("{0:f2}%", Percentp2);
            Console.WriteLine("{0:f2}%", Percentp3);
            Console.WriteLine("{0:f2}%", Percentp4);
            Console.WriteLine("{0:f2}%", Percentp5);

        }
    }
}
