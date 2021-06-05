using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorAPIClient.Dtos;

namespace BlazorAPIClient.DataServices
{
    public class RestAlbumDataService : IMyDataService
    {
        private readonly HttpClient _httpClient;

        public RestAlbumDataService(HttpClient httpClient)
        {
            _httpClient=httpClient;
        }
        public async Task<AlbumDto[]> GetAllAlbum()
        {
            return await _httpClient.GetFromJsonAsync<AlbumDto[]>("/albums");
        }
    }
}