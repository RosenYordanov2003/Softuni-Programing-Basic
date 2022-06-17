using System;

namespace Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                sum1 = sum1 + int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                sum2 = sum2 + int.Parse(Console.ReadLine());
            }
            if (sum1 == sum2)
            {
                Console.WriteLine(" Yes, sum =" + " " + sum1);
            }
            else
            {
                int diff = Math.Abs(sum1 - sum2);
               Console.WriteLine("No, diff = " + "" + diff);
            }
        }
    }
}
