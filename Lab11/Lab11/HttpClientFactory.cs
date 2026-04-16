using System;
using System.Net;
using System.Net.Http;

namespace MovieScraperApp
{
    public static class HttpClientFactory
    {
        public static HttpClient Create()
        {
            var cookieContainer = new CookieContainer();

            cookieContainer.Add(new Uri("https://toloka.to"),
                new Cookie("toloka_sid", "68a5ff706cf7e1f704b51f677b6e056c"));

            cookieContainer.Add(new Uri("https://toloka.to"),
                new Cookie("toloka_data", "a%3A2%3A%7Bs%3A11%3A%22autologinid%22%3Bs%3A32%3A%226cee8b5fc816b901e00a62ef1b9f90dd%22%3Bs%3A6%3A%22userid%22%3Bi%3A1267373%3B%7D"));

            var handler = new HttpClientHandler
            {
                CookieContainer = cookieContainer,
                UseCookies = true,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };

            var client = new HttpClient(handler);

            client.DefaultRequestHeaders.Add("User-Agent",
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64)");

            client.DefaultRequestHeaders.Add("Accept",
                "text/html,application/xhtml+xml");

            client.DefaultRequestHeaders.Add("Accept-Language",
                "uk-UA,uk;q=0.9,en-US;q=0.8");

            return client;
        }
    }
}