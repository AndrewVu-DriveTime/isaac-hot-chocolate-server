using Data;
using HotChocolate.Subscriptions;
using Models;

namespace Resolvers
{
    public class Query
    {
        public async Task<List<Movie>> GetMovies([Service]ITopicEventSender eventSender)
        {
            await eventSender.SendAsync(nameof(Subscription.SubscribeEvent), new Event(){Id = 0, Message = "Get all movies"});
            return Seed.SeedData();
        }

        public Movie GetMovieById(int id) =>
            Seed.SeedData().FirstOrDefault(x => x.Id == id);
    }
}