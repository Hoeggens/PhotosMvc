using PhotosMvc.Views.Photos;

namespace PhotosMvc.Models
{
    public class DataService
    {

        List<IndexVM> Index = new List<IndexVM>()
        {
            new IndexVM{ Id = 1, Path = "https://v.imgi.no/8amsdy2vnu-CONTENT/610"},
            new IndexVM{ Id = 2, Path = "https://eu-central-1.linodeobjects.com/fpg-media/app/uploads/spraktidningen/2021/03/160417b.jpg"}
        };

        public IndexVM[] Pictures()
        {
            return Index.ToArray();
        }




    }
}
