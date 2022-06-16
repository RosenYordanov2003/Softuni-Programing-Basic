using System;

namespace for_loop_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;
            int totalsum = 0;
            int sumwithoutmax = 0;
            for (int i = 0; i <=n-1 ; i++)
            {
               int num = int.Parse(Console.ReadLine());
                sum = sum + num;
                if (num>max)
                {
                    max = num;
                }
                 sumwithoutmax = sum - max;
            }
            if (max == sumwithoutmax) 
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum ="+" "+max);
            }
            else 
            {
                int diff = Math.Abs(max-sumwithoutmax);
                Console.WriteLine("No");
                Console.WriteLine("Diff ="+" "+diff);
            }

        }
    }
}
