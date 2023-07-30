using Microsoft.AspNetCore.Mvc;

namespace RunShoppingClient.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View("This is product controller");
        }
    }
}
