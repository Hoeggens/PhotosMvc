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
            var url = "https://localhost:7282/api/photoapi";

            // Kräver att en instans av IHttpClientFactory injicerats i servicens konstruktor
            // och att följande anropas i program: builder.Services.AddHttpClient();
            HttpClient httpClient = HttpClientFactory.CreateClient();

            // Anropar Web-API:t och deserialiserar innehållet till en array av foton
            PhotoDetailsDto[] photos = await httpClient.GetFromJsonAsync<PhotoDetailsDto[]>(url);

            return photos
         .Select(o => new IndexVM
         {
             Title = o.Title,
             Url = o.Url
         })
         .ToArray();


        }




    }
}
