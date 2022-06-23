using System;

namespace Concatenate_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FirstName = Console.ReadLine();
            string lastname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine($"You are { FirstName} {lastname}, a {age}-years old person from {town}.");
        }
    }
}
