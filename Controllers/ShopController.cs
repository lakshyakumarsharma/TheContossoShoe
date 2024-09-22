using Microsoft.AspNetCore.Mvc;

namespace TheContossoProject.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
