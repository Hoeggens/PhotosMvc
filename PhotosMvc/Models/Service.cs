using PhotosMvc.Views.Photos;
using PhotosMvc.Models;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace PhotosMvc.Models
{
    public class Service
    {
        IHttpClientFactory _httpClientFactory;
        public Service(IHttpClientFactory _httpClientFactory)
        {
            this._httpClientFactory = _httpClientFactory;
        }
        public async Task<IndexVM[]> GetPhotos(int id)
        {
            const string Url = "https://jsonplaceholder.typicode.com/photos";

            HttpClient httpClient = _httpClientFactory.CreateClient();

            PhotoDetailsDto[] photos = await httpClient.GetFromJsonAsync<PhotoDetailsDto[]>(Url);

            return photos
                .Select(x => new IndexVM
                {
                    Title = x.Title,
                    ImgUrl = x.Url,
                })
                .ToArray();
        }




    }
}
