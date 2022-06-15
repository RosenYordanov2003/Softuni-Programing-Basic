using System;

namespace Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = string.Empty; ;
            double balance = 0.0;
            while ((text=Console.ReadLine())!= "NoMoreMoney")
            {
                double sum = double.Parse(text);
                if (sum >= 0)
                {
                    balance += sum;
                    Console.WriteLine($"Increase: {sum:f2}");
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
            }
            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
