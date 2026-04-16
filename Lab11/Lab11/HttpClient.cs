using System.Net;

public static class HttpClientFactory
{
    public static HttpClient Create()
    {
        var cookieContainer = new CookieContainer();

        cookieContainer.Add(new Uri("https://toloka.to"),
            new Cookie("toloka_sid", "your_cookie_here"));

        var handler = new HttpClientHandler
        {
            CookieContainer = cookieContainer,
            UseCookies = true,
            AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
        };

        var client = new HttpClient(handler);

        client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
        client.DefaultRequestHeaders.Add("Accept", "text/html");

        return client;
    }
}