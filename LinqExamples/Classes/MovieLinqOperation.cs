namespace LinqExamples.Classes
{
	internal class MovieLinqOperation : IMovieOperation
	{
		public IEnumerable<Movie> GetCheaperMovies(IEnumerable<Movie> movies, double price)
		{
			var cheaperMovies = movies
				.Where(movie => movie.Price < price);

			return cheaperMovies;
		}

		public Movie GetMovieStarring(IEnumerable<Movie> movies, string starring)
		{
			var movie = movies
				.FirstOrDefault(movie => movie.LeadActor == starring);

			return movie is null ? new Movie() : movie;
		}

		public IEnumerable<Movie> GetMoviesWhereTitleContains(IEnumerable<Movie> movies, string partialTitle)
		{
			var moviesTitleContains = movies
				.Where(movie => movie.Title.Contains(partialTitle));

			return moviesTitleContains;
		}

		public void PrintMovie(Movie movie)
		{
			if (movie is null)
				throw new ArgumentNullException(nameof(movie));

			if (!string.IsNullOrWhiteSpace(movie.Title))
			{
				Console.WriteLine($"=> Title: {movie.Title}, Starring: {movie.LeadActor}, Price: {movie.Price}");
			}
			else
			{
				Console.WriteLine("Movie not found.");
			}
		}

		public void PrintMovies(IEnumerable<Movie> movies)
		{
			movies
				.ToList()
				.ForEach(movie => PrintMovie(movie));

			Console.WriteLine();
		}
	}
}
