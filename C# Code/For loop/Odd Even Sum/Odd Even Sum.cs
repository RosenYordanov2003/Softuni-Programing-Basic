using System;

namespace Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int evennum = 0;
            int oddnum = 0;
            int evensum = 0;
            int oddsum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evennum = num;
                    evensum = evensum + evennum;
                }
                else if (i % 2 != 0)
                {
                    oddnum = num;
                    oddsum = oddsum + oddnum;
                }
            }
            if (evensum == oddsum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum =" + " " + evensum);
            }
            else
            {
                int diff = Math.Abs(evensum - oddsum);
                Console.WriteLine("No");
                Console.WriteLine("Diff =" + " " + diff);
            }
        }
    }
}
