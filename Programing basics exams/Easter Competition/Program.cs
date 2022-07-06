using System;

namespace Easter_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double clients = double.Parse(Console.ReadLine());
            double sum = 0;
            double av = 0;
            int count = 0;
            for (int i = 1; i <= clients; i++)
            {
                string item = Console.ReadLine();
                while (item != "Finish")
                {
                    if (item == "basket")
                    {
                        sum += 1.50;
                        count++;
                    }
                    if (item == "wreath")
                    {
                        sum += 3.80;
                        count++;
                    }
                    if (item == "chocolate bunny")
                    {
                        sum += 7;
                        count++;
                    }
                    item = Console.ReadLine();
                }
                if (count % 2 == 0)
                {
                    sum = sum - (sum * 20) / 100;
                }
                av += sum;
                Console.WriteLine($"You purchased {count} items for {sum:f2} leva.");
                sum = 0;
                count = 0;
            }
            if (clients > 1)
            {
                av = av / clients;
                Console.WriteLine($"Average bill per client is: {av:f2} leva.");
            }
        }
    }
}
