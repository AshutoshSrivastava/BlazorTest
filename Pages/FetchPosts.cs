using System.Threading.Tasks;
using BlazorAPIClient.Dtos;
using System.Net.Http.Json;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace BlazorAPIClient.Pages
{
    public partial class FetchPosts
    {
        [Inject]
        private HttpClient Http{get;set;}
        private PostDto[] postsData;
        protected override async Task OnInitializedAsync()
        {
            postsData = await Http.GetFromJsonAsync<PostDto[]>("https://jsonplaceholder.typicode.com/posts");

            // postsData = await Http.GetFromJsonAsync<PostDto[]>( System.Configuration["rest_api_base_url"]+"/posts");
            
        }
    }
}