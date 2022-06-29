using System;

namespace Suitcases_Load
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            string comand = string.Empty;
            double obem = 0;
            int succsescount = 0;
            int count = 0;
            while ((comand=Console.ReadLine()) != "End")
            {
                obem = double.Parse(comand);
                count++;
                if (count % 3 == 0)
                {
                    capacity -= obem + (obem * 10) / 100;
                }
                else
                {
                    capacity -= obem;
                }
                if (capacity < 0)
                {
                    break;
                }
                if (capacity > 0)
                {
                    succsescount++;
                }
            }
            if (capacity >= 0)
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            else
            {
                Console.WriteLine("No more space!");
            }
            Console.WriteLine($"Statistic: {succsescount} suitcases loaded.");
        }
    }
}
