using System;

namespace Programming_Basics_Online_Exam___28_and_29_March_2020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double loan = double.Parse(Console.ReadLine());
            double cake = (loan * 20) / 100;
            double juices = cake - (cake * 45) / 100;
            double animator = (loan / 3);
            double total = loan + cake + juices + animator;
            Console.WriteLine(total);
        }
    }
}
