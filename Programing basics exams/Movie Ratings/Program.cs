using System;

namespace Movie_Ratings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int countMovies = int.Parse(Console.ReadLine());
            double max = double.MinValue;
            double min = double.MaxValue;
            double total = 0;
            double average = 0;
            string movieMax = string.Empty;
            string movieMin = string.Empty;
            for (int i = 1; i <= countMovies; i++)
            {
                string movieName = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                if (rating > max)
                {
                    max = rating;
                    movieMax = movieName;
                }
                if (rating < min)
                {
                    min = rating;
                    movieMin = movieName;
                }
                total += rating;
                average = total / countMovies;
            }
            Console.WriteLine($"{movieMax} is with highest rating: {max:f1}");
            Console.WriteLine($"{movieMin} is with lowest rating: {min:f1}");
            Console.WriteLine($"Average rating: {average:f1}");
        }
    }
}
