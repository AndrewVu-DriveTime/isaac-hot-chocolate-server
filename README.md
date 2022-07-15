# query {
#   movies {
#    title
#    actors {
#      firstName
#    }
#  }
# }

# mutation CreateReviewForEpisode($ep: Episode!, $review: ReviewInput!) {
#   createReview(episode: $ep, review: $review) {
#     stars
#     commentary
#   }
# }

# {
#   "ep": "JEDI",
#   "review": {
#     "stars": 5,
#     "commentary": "This is a great movie!"
#   }
# }

# type Mutation {
#   createMovie(movie: MovieInput!): Movie!
# }

# mutation createMovie {
#   createMovie(movie: {id: 3, title: "Zucchin Tales", actors:[]}){
#     id
#   }
# }