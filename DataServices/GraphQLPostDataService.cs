using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BlazorAPIClient.Dtos;

namespace BlazorAPIClient.DataServices
{
    public class GraphQLPostDataService : IPostDataService
    {
        private readonly HttpClient _httpClient;

        public GraphQLPostDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            
        }
        public async Task<PostDto[]> GetAllPost()
        {
            var queryObject = new {
                query =@"{posts {data {id title body}}}"
                , variables = new {}
            };

            var postQuery = new StringContent(
                JsonSerializer.Serialize(queryObject)
                ,Encoding.UTF8
                ,"application/json"
            );

            var response = await _httpClient.PostAsync("https://graphqlzero.almansi.me/api",postQuery);

            if(response.IsSuccessStatusCode)
            {
               var gqlData = await JsonSerializer.DeserializeAsync<GQLData>
               (await response.Content.ReadAsStreamAsync());

                return gqlData.Data.Posts.Data;
            }
            return null;
        }
    }
}