using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StuentController : Controller
    {
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok("Success");
        }
    }
}
