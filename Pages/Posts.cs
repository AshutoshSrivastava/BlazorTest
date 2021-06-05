using System.Threading.Tasks;
using BlazorAPIClient.DataServices;
using BlazorAPIClient.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorAPIClient.Pages
{
    public partial class Posts
    {
        [Inject]
        IPostDataService PostDataService {get;set;}

        private PostDto[] postsData;
        protected override async Task OnInitializedAsync()
        {
            // // fetch using traditional way
            // postsData = await Http.GetFromJsonAsync<PostDto[]>("https://jsonplaceholder.typicode.com/posts");

            // postsData = await Http.GetFromJsonAsync<PostDto[]>( System.Configuration["rest_api_base_url"]+"/posts");
            
            postsData = await PostDataService.GetAllPost();
        }
    }
}