using Microsoft.AspNetCore.Mvc;

namespace BookMapperExcepitonMiddleWare.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
