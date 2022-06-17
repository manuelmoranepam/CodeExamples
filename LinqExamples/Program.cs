var movies = new MovieRepository().GetMovies();
var price = 20.00;
var partialTitle = "Star Wars";
var starring = "The Twilight Guy";

IMovieOperation _movieOperation = new MovieLinqOperation();

Console.WriteLine($"Movies cheaper than ${price}:");
var cheaperMovies = _movieOperation.GetCheaperMovies(movies, price);
_movieOperation.PrintMovies(cheaperMovies);

Console.WriteLine($"Movies where title contains {partialTitle}:");
var moviesTitleContains = _movieOperation.GetMoviesWhereTitleContains(movies, partialTitle);
_movieOperation.PrintMovies(moviesTitleContains);

Console.WriteLine($"First movie starring {starring}:");
var movieStarring = _movieOperation.GetMovieStarring(movies, starring);
_movieOperation.PrintMovie(movieStarring);

// LINQ Query Operators Syntax
var titleQueryList =
	from movie in movies
	where movie.Price < 20
	orderby movie.Title
	select movie.Title;

//LINQ Extension Methods Syntax
var titleExtensionList = movies
	.Where(movie => movie.Price < 20)
	.OrderBy(movie => movie.Title)
	.Select(movie => movie.Title);