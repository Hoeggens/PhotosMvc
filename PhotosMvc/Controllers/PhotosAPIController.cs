using Microsoft.AspNetCore.Mvc;
using PhotosMvc.Models;
using PhotosMvc.Views.Photos;

namespace PhotosMvc.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PhotosAPIController : ControllerBase
    {
        Service dataService;
        public PhotosAPIController(Service dataService)
        {
            this.dataService = dataService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IndexVM[]>> GetProductAsync(int id)
        {
            var model = await dataService.GetPhotos(id);
            if (model == null)
                return NotFound();

            return Ok(model);
        }
    }
}
