using System;

namespace First_Steps_In_Coding___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dolars = double.Parse(Console.ReadLine());
            double lev = dolars * 1.79549;
            Console.WriteLine(lev);
        }
    }
}
