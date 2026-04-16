using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieScraperApp
{
    public class MovieController
    {
        private readonly IScraperService _scraperService;
        private readonly string _baseUrl = "https://toloka.to/viewforum.php?f=16&start=";

        public MovieController(IScraperService scraperService)
        {
            _scraperService = scraperService;
        }

        public async Task<List<MovieModel>> LoadMoviesAsync(int pages)
        {
            int itemsPerPage = 30;
            var tasks = new List<Task<List<MovieModel>>>();

            for (int i = 0; i < pages; i++)
            {
                int pageIndex = i;

                tasks.Add(Task.Run(async () =>
                {
                    await Task.Delay(pageIndex * 2000);

                    string url = $"{_baseUrl}{pageIndex * itemsPerPage}";
                    return await _scraperService.GetMoviesFromPageAsync(url, pageIndex + 1);
                }));
            }

            var results = await Task.WhenAll(tasks);

            return results.SelectMany(x => x).ToList();
        }
    }
}