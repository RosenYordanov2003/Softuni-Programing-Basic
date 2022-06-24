using System;

namespace Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int coountOfPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int totalTime = coountOfPages / pagesPerHour;
            int hoursperDay = totalTime / day;
            Console.WriteLine(hoursperDay);
        }
    }
}
