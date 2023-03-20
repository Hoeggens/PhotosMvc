using Microsoft.AspNetCore.Mvc;
using PhotosMvc.Models;
using PhotosMvc.Views.Photos;

namespace PhotosMvc.Controllers
{
    public class PhotosController : Controller
    {
        DataService dataService;
        public PhotosController(DataService dataService)
        {
            this.dataService = dataService;
        }

        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            IndexVM[] model = await dataService.GetPhotos();
            return View(model);
        }
    }
}
