using System;

namespace ConsoleApp243
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loan = int.Parse(Console.ReadLine());
            decimal statuetki =(decimal) loan - (loan * 30) / 100;
           decimal keturing = statuetki - (statuetki * 15) / 100;
            decimal ozvuchavane = keturing / 2;
            decimal total = loan + statuetki + keturing + ozvuchavane;
            Console.WriteLine($"{total:f2}");
        }
    }
}
