namespace LinqExamples.Classes
{
	internal class MovieOperation : IMovieOperation
	{
		public IEnumerable<Movie> GetCheaperMovies(IEnumerable<Movie> movies, double price)
		{
			var cheaperMovies = new List<Movie>();

			foreach (var movie in movies)
			{
				if (movie.Price < price)
				{
					cheaperMovies.Add(movie);
				}
			}

			return cheaperMovies;
		}

		public IEnumerable<Movie> GetMoviesWhereTitleContains(IEnumerable<Movie> movies, string partialTitle)
		{
			var moviesTitleContains = new List<Movie>();

			foreach (var movie in movies)
			{
				if (movie.Title.Contains(partialTitle))
				{
					moviesTitleContains.Add(movie);
				}
			}

			return moviesTitleContains;
		}

		public Movie GetMovieStarring(IEnumerable<Movie> movies, string starring)
		{
			foreach (var movie in movies)
			{
				if (movie.LeadActor == starring)
				{
					return movie;
				}
			}

			return new Movie();
		}

		public void PrintMovies(IEnumerable<Movie> movies)
		{
			foreach (var movie in movies)
			{
				PrintMovie(movie);
			}

			Console.WriteLine();
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
	}
}
