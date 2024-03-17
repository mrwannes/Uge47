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
            // Der er ingen BaseURI sat. Normalt er det http eller https med i request men da dette er en lokal fil på et drev er der ikke
            // Find løsning
            var imageFiles = Directory.GetFiles("C:\\Users\\reuse\\OneDrive\\Pictures\\2020-05").Select(Path.GetFileName);
            return Ok(imageFiles);
        }
    }
}
