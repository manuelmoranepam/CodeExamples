namespace LinqExamples.Interfaces
{
	internal interface IMovieOperation
	{
		IEnumerable<Movie> GetCheaperMovies(IEnumerable<Movie> movies, double price);
		Movie GetMovieStarring(IEnumerable<Movie> movies, string starring);
		IEnumerable<Movie> GetMoviesWhereTitleContains(IEnumerable<Movie> movies, string partialTitle);
		void PrintMovie(Movie movie);
		void PrintMovies(IEnumerable<Movie> movies);
	}
}