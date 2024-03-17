using System.Text.Json.Serialization;

namespace BlazorAPI.ViewModels
{
    public class AddressPropertyViewModel
    {
        [JsonPropertyName("street")]
        public string Street { get; set; }
        [JsonPropertyName("suite")]
        public string Suite { get; set; }
        [JsonPropertyName("city")]
        public string City { get; set; }
        [JsonPropertyName("geo")]
        public GeoPropertyViewModel Geo { get; set; }
    }
}
