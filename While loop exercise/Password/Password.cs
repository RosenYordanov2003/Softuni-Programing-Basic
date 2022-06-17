using System;

namespace Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine(); ;
            string pass = Console.ReadLine(); ;
            string input = string.Empty;
            while ((input=Console.ReadLine()) != pass)
            {
               
            }
            Console.WriteLine($"Welcome {username}!");

        }
    }
}
