namespace LinqExamples.Classes
{
	internal class MovieRepository
	{
		public IEnumerable<Movie> GetMovies()
		{
			var repository = new List<Movie>()
			{
				new Movie() { Id = 1, Title = "Star Wars: A New Hope", LeadActor = "Mark Hamill", Price = 20 },
				new Movie() { Id = 2, Title = "Terminator", LeadActor = "Arnold SWEqfwkbaksfer", Price = 15 },
				new Movie() { Id = 3, Title = "Doctor Strange", LeadActor = "Bandicoot Thundersnatch", Price = 19 },
				new Movie() { Id = 4, Title = "The Batman", LeadActor = "The Twilight Guy", Price = 23 },
				new Movie() { Id = 5, Title = "Star Wars: The Empire Strikes Back", LeadActor = "Mark Hamill", Price = 25 },
				new Movie() { Id = 6, Title = "Doctor Strange in the Multiverse of Madness", LeadActor = "Bandicoot Thundersnatch", Price = 30 },
				new Movie() { Id = 7, Title = "Twilight", LeadActor = "The Twilight Guy", Price = 10 },
				new Movie() { Id = 8, Title = "Star Wars: Return of the Jedi ", LeadActor = "Mark Hamill", Price = 20 }
			};

			return repository;
		}
	}
}