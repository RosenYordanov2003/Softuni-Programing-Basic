using System;

namespace While_loop_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int clas = 1;
            int repeatClass = 0;
            double avargae = 0;
            int countgraduatioG = 0;
            double sum = 0;
            while (clas <= 12)
            {
                 double grades = double.Parse(Console.ReadLine());
                if (grades >= 4)
                {
                    sum = sum + grades;
                    clas++;

                    countgraduatioG++;
                    avargae = sum / countgraduatioG;
                }
                if (grades < 4)
                {
                    repeatClass++;
                    if (repeatClass > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {clas} grade");
                        break;
                    }
                }
            }
        }
    }
}
