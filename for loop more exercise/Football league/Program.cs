using System;

namespace Football_league
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Acount = 0;
            double Bcount = 0;
            double Vcount = 0;
            double Gcount = 0;
            double capacity = int.Parse(Console.ReadLine());
            double fans = int.Parse(Console.ReadLine());
            for (int i = 1; i <= fans; i++)
            {
                string sektor = Console.ReadLine();
                if (sektor == "A")
                {
                    Acount++;
                }
                else if (sektor == "B")
                {
                    Bcount++;
                }
                else if (sektor == "G")
                {
                    Gcount++;
                }
                else if (sektor == "V")
                {
                    Vcount++;
                }
            }
            double Apercent = (Acount / fans) * 100;
            double Bpercent = (Bcount / fans) * 100;
            double Gpercemt = (Gcount / fans) * 100;
            double Vpercent = (Vcount / fans) * 100;
            double total = (fans / capacity) * 100;
            Console.WriteLine($"{Apercent:f2}%");
            Console.WriteLine($"{Bpercent:f2}%");
            Console.WriteLine($"{Vpercent:f2}%");
            Console.WriteLine($"{Gpercemt:f2}%");
            Console.WriteLine($"{total:f2}%");
        }
    }
}
