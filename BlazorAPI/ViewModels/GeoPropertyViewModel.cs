using System.Text.Json.Serialization;

namespace BlazorAPI.ViewModels
{
    public class GeoPropertyViewModel
    {
        [JsonPropertyName("lat")]
        public string Lat { get; set; }
        [JsonPropertyName("lng")]
        public string Lng { get; set; }
    }
}
