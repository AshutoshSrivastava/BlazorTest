using System.Threading.Tasks;
using BlazorAPIClient.Dtos;

namespace BlazorAPIClient.DataServices
{
    public interface IPostDataService
    {
        Task<PostDto[]> GetAllPost();
    }
}