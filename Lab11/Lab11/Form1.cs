using System;
using System.Windows.Forms;

namespace MovieScraperApp
{
    public partial class Form1 : Form
    {
        private readonly MovieController _controller;

        public Form1()
        {
            InitializeComponent();

            var httpClient = HttpClientFactory.Create();
            var scraper = new ScraperService(httpClient);

            _controller = new MovieController(scraper);
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            listBoxMovies.Items.Clear();

            try
            {
                var movies = await _controller.LoadMoviesAsync(4);

                foreach (var movie in movies)
                {
                    listBoxMovies.Items.Add($"[Сторінка {movie.PageIndex}] {movie.Title}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            btnStart.Enabled = true;
        }
    }
}