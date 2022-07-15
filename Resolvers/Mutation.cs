using Data;
using Models;

namespace Resolvers
{
    public class Mutation
    {
        public async Task<Movie> createMovie(Movie movie)
        {
            // new Movie { Id = 3, Title = "Zucchini Tales",
            //  Actors = new List<Actor> { new Actor { FirstName = "Mary", LastName = "Poppins" } } }
            Seed.modifySeedData(movie);
            return movie;
        }
    }
}