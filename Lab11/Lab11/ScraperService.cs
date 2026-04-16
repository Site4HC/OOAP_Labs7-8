using MovieScraperApp;
using System.Net;
using System.Net.Http;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

public class ScraperService : IScraperService
{
    private readonly HttpClient _httpClient;

    public ScraperService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<MovieModel>> GetMoviesFromPageAsync(string url, int pageIndex)
    {
        var movies = new List<MovieModel>();

        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var html = await response.Content.ReadAsStringAsync();

        var htmlDocument = new HtmlDocument();
        htmlDocument.LoadHtml(html);

        var nodes = htmlDocument.DocumentNode.SelectNodes("//a[@class='topictitle']");

        if (nodes != null)
        {
            foreach (var node in nodes)
            {
                var title = node.InnerText.Trim();

                if (!string.IsNullOrEmpty(title))
                {
                    movies.Add(new MovieModel
                    {
                        Title = title,
                        PageIndex = pageIndex
                    });
                }
            }
        }

        return movies;
    }
}