namespace Day19
{
    //Interfaces
    public interface IFilm
    {
        public string? Title { get; set; }
        public string? Director { get; set; }
        public int Year { get; set; }
    }

    public interface IFilmLibrary
    {
        public void AddFilm(IFilm film);
        public void RemoveFilm(string title);
        public List<IFilm> GetFilms();
        public List<IFilm> SearchFilms(string query);
        public int GetTotalFilmCount();
    }

    //classes
    public class Film : IFilm
    {
        public string? Title { get; set; }
        public string? Director { get; set; }
        public int Year { get; set; }
    }

    public class FilmLibrary : IFilmLibrary
    {
        private List<IFilm> _films = new();
        public void AddFilm(IFilm film)
        {
            _films.Add(film);
            Console.WriteLine($"{film} film added successfully");
        }
        public void RemoveFilm(IFilm film)
        {
            if (_films.Remove(film))
            {
                System.Console.WriteLine($"{film} removed");
            }
            else
            {
                System.Console.WriteLine($"{film} film does not exist in the records");
            }
        }

        public List<IFilm> GetFilms()
        {
            return _films;
        }

        public List<IFilm> SearchFilms(string query)
        {
            // public List<IFilm> films=new();
            List<IFilm> films = _films.Where(film => film.Title == query || film.Director == query).ToList();
            return films;
        }
    }
}

