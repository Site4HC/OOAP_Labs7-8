using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace MovieScraperApp
{
    public class ScraperService
    {
        private readonly HttpClient _httpClient;

        public ScraperService()
        {
            var cookieContainer = new CookieContainer();
            cookieContainer.Add(new Uri("https://toloka.to"), new Cookie("toloka_sid", "4664b63f0280b5a5aca80e891e6e2434"));
            cookieContainer.Add(new Uri("https://toloka.to"), new Cookie("toloka_data", "a%3A2%3A%7Bs%3A11%3A%22autologinid%22%3Bs%3A32%3A%22b43418a397ad09b048f2a3c95ca1b051%22%3Bs%3A6%3A%22userid%22%3Bi%3A1267373%3B%7D"));

            var handler = new HttpClientHandler
            {
                CookieContainer = cookieContainer,
                UseCookies = true,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };

            _httpClient = new HttpClient(handler);
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36");
            _httpClient.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
            _httpClient.DefaultRequestHeaders.Add("Accept-Language", "uk-UA,uk;q=0.9,en-US;q=0.8,en;q=0.7");
        }

        public async Task<List<MovieModel>> GetMoviesFromPageAsync(string url, int pageIndex)
        {
            var movies = new List<MovieModel>();
            try
            {
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
                            movies.Add(new MovieModel { Title = title, PageIndex = pageIndex });
                        }
                    }
                }
                else
                {
                    var titleNode = htmlDocument.DocumentNode.SelectSingleNode("//title");
                    string pageTitle = titleNode != null ? titleNode.InnerText.Trim() : "";
                    MessageBox.Show($"Фільмів не знайдено.\nЗаголовок отриманої сторінки: {pageTitle}", $"Сторінка {pageIndex}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"Помилка на сторінці {pageIndex}");
            }
            return movies;
        }
    }
}