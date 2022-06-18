using System;

namespace Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeSum = 0;
            int nonPrimeSum = 0;

            string comand = Console.ReadLine();
            while (comand != "stop")
            {
                int nunm = int.Parse(comand);
                bool isprime = true;
                for (int i = 2; i < nunm - 1; i++)
                {
                    if (nunm % i == 0)
                    {
                        isprime = false;
                        break;

                    }
                }
                if (nunm < 0)
                {
                    Console.WriteLine("Number is negative.");
                    comand = Console.ReadLine();
                    continue;
                }
                if (isprime)
                {
                    primeSum += nunm;
                }
                else
                {
                    nonPrimeSum += nunm;
                }
                comand = Console.ReadLine();

            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
    
}
