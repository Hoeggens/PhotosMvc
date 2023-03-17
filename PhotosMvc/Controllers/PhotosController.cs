using Microsoft.AspNetCore.Mvc;
using PhotosMvc.Models;
using PhotosMvc.Views.Photos;

namespace PhotosMvc.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PhotosController : ControllerBase
    {
        DataService dataService;
        public PhotosController(DataService dataService)
        {
            this.dataService = dataService;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ComputerDetailsDto>> GetProductAsync(int id)
        {
            var model = await dataService.GetComputerDetailsAsync(id);
            if (model == null)
                return NotFound();

            return Ok(model);
        }

        //[HttpGet("")]
        //public IActionResult Index()
        //{
        //    IndexVM[] model = dataService.Pictures();
        //    return View(model);
        //}
    }
}
