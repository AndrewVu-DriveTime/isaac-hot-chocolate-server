//SeedData.cs

using Models;

namespace Data
{
    public class Seed
    {
        static List<Actor> actors = new List<Actor>
        {
            new Actor
            {
                FirstName = "Bob",
                LastName = "Kante"
            },
            new Actor
            {
                FirstName = "Mary",
                LastName = "Poppins"
            }
        };

        static List<Movie> movies = new List<Movie>
        {
            new Movie
            {
                Id = 1,
                Title = "The Rise of the GraphQL Warrior",
                Actors = actors
            },
            new Movie
            {
                Id = 2,
                Title = "The Rise of the GraphQL Warrior Part 2",
                Actors = actors
            }
        };
        public static List<Movie> SeedData()
        {
            return movies;
        }

        public static void modifySeedData(Movie movie)
        {
            movies.Add(movie);
        }
    }
}