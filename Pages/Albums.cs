using System.Threading.Tasks;
using BlazorAPIClient.Dtos;
using System.Net.Http.Json;
using System.Net.Http;
using Microsoft.AspNetCore.Components;
using BlazorAPIClient.DataServices;

namespace BlazorAPIClient.Pages
{
    public partial class Albums
    {
        [Inject]
        IMyDataService MyDataService {get;set;}
        private AlbumDto[] albums;
        protected override async Task OnInitializedAsync()
        {
            // albumDto = await Http.GetFromJsonAsync<AlbumDto[]>("https://jsonplaceholder.typicode.com/albums");

            albums = await MyDataService.GetAllAlbum();
        }


    }
}