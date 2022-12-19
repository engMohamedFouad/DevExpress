namespace DevExpressDemo.Helper
{
    public class FiniexApiHelper
    {
        public HttpClient Initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api-dev.finiexsoft.net/");
            return client;
        }
    }
}
