using System;

namespace Game_Of_Intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rounds = int.Parse(Console.ReadLine());
            double points = 0;
            double totalrounds = 0;
            double invalid = 0;
            double countbeetween0and9 = 0;
            double countBeetween10and19 = 0;
            double countBeetween20and29 = 0;
            double countBeetween30and39 = 0;
            double countBeetween40and50 = 0;
            for (int i = 1; i <= rounds; i++)
            {
                totalrounds += rounds;
                double number = double.Parse(Console.ReadLine());
                if (number >= 0 && number <= 9)
                {
                    countbeetween0and9++;
                    points += (number * 20) / 100;
                }
                else if (number >= 10 && number <= 19)
                {

                    countBeetween10and19++;
                    points += (number * 30) / 100;
                }
                else if (number >= 20 && number <= 29)
                {

                    countBeetween20and29++;
                    points += (number * 40) / 100;
                }
                else if (number >= 30 && number <= 39)
                {

                    countBeetween30and39++;
                    points += 50;
                }
                else if (number >= 40 && number <= 50)
                {

                    countBeetween40and50++;
                    points += 100;
                }
                else
                {
                    invalid++;
                    points = points / 2;
                }


            }
            double p1 = (countbeetween0and9 / rounds) * 100;
            double p2 = (countBeetween10and19 / rounds) * 100;
            double p3 = (countBeetween20and29 / rounds) * 100;
            double p4 = (countBeetween30and39 / rounds) * 100;
            double p5 = (countBeetween40and50 / rounds) * 100;
            double p6 = (invalid / rounds) * 100;
            Console.WriteLine($"{points:f2}");
            Console.WriteLine($"From 0 to 9: {p1:f2}%");
            Console.WriteLine($"From 10 to 19: {p2:f2}%");
            Console.WriteLine($"From 20 to 29: {p3:f2}%");
            Console.WriteLine($"From 30 to 39: {p4:f2}%");
            Console.WriteLine($"From 40 to 50: {p5:f2}%");
            Console.WriteLine($"Invalid numbers: {p6:f2}% ");

        }
    }
}
