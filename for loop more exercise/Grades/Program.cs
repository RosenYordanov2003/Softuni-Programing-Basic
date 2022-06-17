using System;

namespace Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double countStudents = int.Parse(Console.ReadLine());
            int topStudentsCount = 0;
            int beetweenFourandFiveGrade = 0;
            double total = 0;
            int beetweenThreeandFourGrade = 0;
            int failTimes = 0;
            for (int i = 1; i <= countStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                total += grade;
                if (grade >= 5.00)
                {
                    topStudentsCount++;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    beetweenFourandFiveGrade++;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    beetweenThreeandFourGrade++;
                }
                else
                {
                    failTimes++;
                }
            }
            double percenttopstudent = (topStudentsCount / countStudents) * 100;
            double percentBeetweenFourandFive = (beetweenFourandFiveGrade / countStudents) * 100;
            double percentBeetweenThreeandFour = (beetweenThreeandFourGrade / countStudents) * 100;
            double percentFail = (failTimes / countStudents) * 100;
            double average = total / countStudents;
            Console.WriteLine($"Top students: {percenttopstudent:f2}% ");
            Console.WriteLine($"Between 4.00 and 4.99: { percentBeetweenFourandFive:f2}% ");
            Console.WriteLine($"Between 3.00 and 3.99: { percentBeetweenThreeandFour:f2}% ");
            Console.WriteLine($"Fail: { percentFail:f2}% ");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}
