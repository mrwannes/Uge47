namespace BlazorAPI.Services
{
    public class ImageService
    {
        private readonly HttpClient _httpClient;

        public ImageService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string[]> GetImagesAsync()
        {
            return await _httpClient.GetFromJsonAsync<string[]>("http://localhost:5041/api/Gallery");
        }
    }
}
