using System;

namespace Prime_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int diffFirstPair = int.Parse(Console.ReadLine());
            int diffSecondPair = int.Parse(Console.ReadLine());
            int totalFirs = first + diffFirstPair;
            int totalSecond = second + diffSecondPair;
            int count1 = 0;
            int count2 = 0;
            for (int firstPair = first; firstPair <= totalFirs; firstPair++)
            {
                for (int secondPair = second; secondPair <= totalSecond; secondPair++)
                {
                    for (int i = 2; i <= Math.Sqrt(firstPair); i++)
                    {
                        if (firstPair % i == 0)
                        {
                            count1++;
                            break;
                        }
                    }
                    for (int z = 2; z < Math.Sqrt(secondPair); z++)
                    {
                        if (secondPair % z == 0)
                        {
                            count2++;
                            break;
                        }
                    }
                    if (count1 == 0 && count2 == 0 && secondPair != 25)
                    {
                        Console.WriteLine($"{firstPair}{secondPair}");
                    }
                    count1 = 0;
                    count2 = 0;

                }
            }
        }
    }
}
