using MovieScraperApp;

public interface IScraperService
{
    Task<List<MovieModel>> GetMoviesFromPageAsync(string url, int pageIndex);
}