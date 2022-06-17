using System;

namespace Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int countBooks = 0;
            string otherBooks=String.Empty;
            while ((otherBooks = Console.ReadLine())!= "No More Books")
            {
                if (otherBooks != book)
                {
                    countBooks++;
                }
                else
                {
                    Console.WriteLine($"You checked {countBooks} books and found it.");
                   return;
                }
            }
            Console.WriteLine($"The book you search is not here!");
            Console.WriteLine($"You checked {countBooks} books.");
        }
    }
}
