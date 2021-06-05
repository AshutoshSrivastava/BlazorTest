using System.Threading.Tasks;
using  BlazorAPIClient.Dtos;
namespace BlazorAPIClient.DataServices
{
    public interface IMyDataService
    {
        Task<AlbumDto[]> GetAllAlbum();
    }
}