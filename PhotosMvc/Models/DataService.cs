using PhotosMvc.Views.Photos;

namespace PhotosMvc.Models
{
    public class DataService
    {
        IHttpClientFactory HttpClientFactory;

        public DataService(IHttpClientFactory httpClientFactory)
        {

            HttpClientFactory = httpClientFactory;

        }


        List<IndexVM> Index = new List<IndexVM>()
        {
            new IndexVM{ Id = 1, Path = "https://v.imgi.no/8amsdy2vnu-CONTENT/610"},
            new IndexVM{ Id = 2, Path = "https://eu-central-1.linodeobjects.com/fpg-media/app/uploads/spraktidningen/2021/03/160417b.jpg"}
        };


        public async Task<IndexVM[]> GetPhotos()
        {
            var url = "https://localhost:7104/";

            HttpClient httpClient = HttpClientFactory.CreateClient();

            PhotoDetailsDto[]? photos = await httpClient.GetFromJsonAsync<PhotoDetailsDto[]>(url);

            return photos
         .Select(x => new IndexVM
         {
             Id = x.Id,
             Path = x.Path,
             Title = x.Title,
             Url = x.Url,
         })
         .ToArray();
        }
    }
}
