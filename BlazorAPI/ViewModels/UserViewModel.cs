using System.Text.Json.Serialization;

namespace BlazorAPI.ViewModels
{
    public class UserViewModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("address")]
        public AddressPropertyViewModel Address { get; set; }
    }
}
