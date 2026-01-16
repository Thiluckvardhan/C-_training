using System.Linq;
namespace Day18
{
    /// <summary>Represents a movie entry with title, artist, genre, and rating details.</summary>
    public class Movie
    {
        public string? Title { get; set; }
        public string? Artist { get; set; }
        public string? Genre { get; set; }
        public int Ratings { get; set; }
    }

    /// <summary>Stores movie records and supports adding and querying by genre or rating order.</summary>
    public class Question2
    {
        #region Question2
        public static List<Movie> movielist = new();
        public void AddMovie(string MovieDetails)
        {
            var details = MovieDetails.Split(',');
            // Split comma-delimited input into a strongly typed movie object
            Movie movie = new Movie
            {
                Title = details[0].Trim(),
                Artist = details[1].Trim(),
                Genre = details[2].Trim(),
                Ratings=int.Parse(details[3].Trim())
            };

            // int.TryParse(details[3], out int temp);
            // movie.Ratings = temp;
            movielist.Add(movie);
        }

        public List<Movie> viewMoviesByGenre(string genre)
        {
            List<Movie> movie = new();
            // Filter movies that match the requested genre
            foreach (var item in movielist)
            {
                if (item.Genre == genre)
                {
                    movie.Add(item);
                }
            }
            return movie;
        }

        public List<Movie> ViewMoviesByRatings()
        {
            // Return movies ordered from lowest to highest rating
            return movielist.OrderBy(m => m.Ratings).ToList();
        }
        #endregion
    }
}