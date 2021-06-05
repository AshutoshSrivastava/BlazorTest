using System.Text.Json.Serialization;

namespace BlazorAPIClient.Dtos
{
    public class PostDto
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("body")]
        public string Body { get; set; }
    }
}