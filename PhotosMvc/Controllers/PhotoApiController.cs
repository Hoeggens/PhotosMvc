using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhotosMvc.Models;
using PhotosMvc.Views.Photos;

namespace PhotosMvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoApiController : ControllerBase
    {
        Service dataService;
        public PhotoApiController(Service dataService)
        {
            this.dataService = dataService;
        }

        [HttpGet("")]
        public async Task<ActionResult<PhotoDetailsDto[]>> IndexAsync()
        {
            var model = await dataService.GetPhotos();
            if (model == null)
                return NotFound();

            return model;
        }
    }
}


