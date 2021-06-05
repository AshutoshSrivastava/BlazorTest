using System.Text.Json.Serialization;

namespace BlazorAPIClient.Dtos
{
    public partial class GQLData
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonPropertyName("posts")]
        public Posts Posts { get; set; }
    }

    public partial class Posts
    {
        [JsonPropertyName("data")]
        public PostDto[] Data { get; set; } // changes Data to our dto
    }

}