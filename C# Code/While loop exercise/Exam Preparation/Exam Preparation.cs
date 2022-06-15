using System;

namespace Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countBadGrades = int.Parse(Console.ReadLine());
            double totalGrades = 0;
            int badGradescount = 0;
            int problemSolved = 0;
            string lastProblem = string.Empty;
            string problem = string.Empty;
            while ((problem=Console.ReadLine())!="Enough")
            {
                int grades = int.Parse(Console.ReadLine());
                if (grades <= 4)
                {
                    badGradescount++;
                }
                if (badGradescount == countBadGrades)
                {
                    Console.WriteLine($"You need a break, {badGradescount} poor grades.");
                    return;
                }
                problemSolved++;
                lastProblem = problem;
                totalGrades += grades;
            }
            double av = totalGrades / problemSolved;
            Console.WriteLine($"Average score: {av:f2}");
            Console.WriteLine($"Number of problems: {problemSolved}");
            Console.WriteLine($"Last problem: {lastProblem}");
        }
    }
    
}
