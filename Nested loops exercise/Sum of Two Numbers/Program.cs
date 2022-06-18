using System;

namespace Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());
            int magical = int.Parse(Console.ReadLine());
            int counter = 0;
            bool isMagucal = true;

            for (int first = num1; first <= finish; first++)
            {
                for (int second = num1; second <= finish; second++)
                {
                    counter++;
                    if (first + second == magical)
                    {
                        Console.WriteLine($"Combination N:{counter} ({first} + {second} = {magical})");
                        isMagucal = false;
                        first = finish;
                    }

                }
            }
            if (isMagucal)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magical}");
            }

        }
    }
}
