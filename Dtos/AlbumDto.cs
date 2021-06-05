using System.Text.Json.Serialization;

namespace BlazorAPIClient.Dtos
{
    public class AlbumDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}