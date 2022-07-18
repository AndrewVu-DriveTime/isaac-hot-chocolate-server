//Movie.cs

using HotChocolate.Extensions.ApolloSubgraph;

namespace Models
{
    //[GraphQLExtends]
    public class Movie 
    {
        [GraphQLKey]
        //[GraphQLExternal]
        //[GraphQLType(typeof(IdType))]
        public int Id { get; set; }

        //[GraphQLExternal]
        public string? Title { get; set; }

        //[GraphQLExternal]
        public List<Actor>? Actors { get; set; }
    }
}