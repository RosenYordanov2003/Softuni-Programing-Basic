using System;

namespace Favorite_Movie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int letter = 0;
            int sum = 0;
            int max = 0;
            int count = 0;
            string movieName = string.Empty;
            while (true)
            {
                string movie = Console.ReadLine();
                if (movie == "STOP")
                {
                    break;
                }
                for (int i = 0; i < movie.Length; i++)
                {
                    letter = (int)movie[i];
                    sum += letter;
                    if (letter >= 'A' && letter <= 'Z')
                    {
                        sum -= movie.Length;
                    }
                    if (letter >= 'a' && letter <= 'z')
                    {
                        sum -= movie.Length * 2;
                    }
                }
                count++;
                if (sum > max)
                {
                    max = sum;
                    movieName = movie;

                }
                sum = 0;

                if (count >= 7)
                {
                    Console.WriteLine("The limit is reached.");
                    break;
                }

            }
            Console.WriteLine($"The best movie for you is {movieName} with {max} ASCII sum.");
        }
    }
}
