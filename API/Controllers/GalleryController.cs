using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalleryController : Controller
    {
        // GET: api/Galleri
        [HttpGet]
        public IActionResult GetImages()
        {
            var imageFiles = Directory.GetFiles("C:\\Users\\reuse\\Pictures\\dyr");
            return Ok(imageFiles);
        }
    }
}
