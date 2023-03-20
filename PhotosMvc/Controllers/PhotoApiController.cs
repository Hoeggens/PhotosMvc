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

        [HttpGet("/{id}")]
        public async Task<ActionResult<IndexVM[]>> IndexAsync()
        {
            var model = await dataService.GetPhotos(2);
            if (model == null)
                return NotFound();

            return Ok(model);
        }
    }
}


