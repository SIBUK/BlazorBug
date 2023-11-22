namespace BlazorApp3.Client.Services
{
    public class AppService
    {
        HttpClient _httpClient;

        public AppService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
    }
}
