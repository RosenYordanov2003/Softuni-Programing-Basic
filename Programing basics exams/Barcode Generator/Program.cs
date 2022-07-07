using System;

namespace Barcode_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int firstDigit = start / 1000;
            int secondDigit = (start / 100) % 10;
            int thirdDigit = (start / 10) % 10;
            int lats = start % 10;
            int FirstEnd = end / 1000;
            int secondEnd = (end / 100) % 10;
            int thirdEnd = (end / 10) % 10;
            int last = end % 10;
            for (int first = firstDigit; first <= FirstEnd; first++)
            {
                for (int second = secondDigit; second <= secondEnd; second++)
                {
                    for (int third = thirdDigit; third <= thirdEnd; third++)
                    {
                        for (int h = lats; h <= last; h++)
                        {
                            if (first % 2 != 0 && second % 2 != 0 && third % 2 != 0 && h % 2 != 0)
                            {
                                Console.Write($"{first}{second}{third}{h} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
