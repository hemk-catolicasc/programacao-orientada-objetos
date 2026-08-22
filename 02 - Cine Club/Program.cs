using System.ComponentModel;

namespace CineClub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            List<Movie> movies = new List<Movie>();

            do
            {   
                Console.Clear();
                Console.WriteLine("--- Movie Menu ---");
                Console.WriteLine("1. Register a movie");
                Console.WriteLine("2. See movies list");
                Console.WriteLine("3. Exit");
                choice = int.Parse(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                        Movie movie = new Movie();
                        Console.WriteLine("Movie title: ");
                        movie.Title = Console.ReadLine();
                        Console.WriteLine("Movie year: ");
                        movie.Year = int.Parse(Console.ReadLine());
                        Console.WriteLine("Movie Genre: ");
                        movie.Genre = Console.ReadLine();
                        Console.WriteLine("Movie Director: ");
                        movie.Director = Console.ReadLine();
                        movies.Add(movie);
                        break;
                    case 2:
                        foreach (Movie movieItem in movies)
                        {
                            Console.WriteLine(movieItem.Title + "," +  movieItem.Year + "," + movieItem.Genre + "," + movieItem.Director);
                        }
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            } while (choice != 3);
        }
    }
}