using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieScraperApp
{
    public partial class Form1 : Form
    {
        private readonly ScraperService _scraperService;
        private readonly string _baseUrl = "https://toloka.to/viewforum.php?f=16&start=";

        public Form1()
        {
            InitializeComponent();
            _scraperService = new ScraperService();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            listBoxMovies.Items.Clear();

            int pagesToLoad = 4;
            int itemsPerPage = 30;
            var tasks = new List<Task>();

            for (int i = 0; i < pagesToLoad; i++)
            {
                int pageIndex = i;
                tasks.Add(Task.Run(async () =>
                {
                    await Task.Delay(pageIndex * 2000);

                    string targetUrl = $"{_baseUrl}{pageIndex * itemsPerPage}";
                    List<MovieModel> movies = await _scraperService.GetMoviesFromPageAsync(targetUrl, pageIndex + 1);

                    this.Invoke((MethodInvoker)delegate
                    {
                        foreach (var movie in movies)
                        {
                            listBoxMovies.Items.Add($"[Сторінка {movie.PageIndex}] {movie.Title}");
                        }
                    });
                }));
            }

            await Task.WhenAll(tasks);
            btnStart.Enabled = true;
        }
    }
}