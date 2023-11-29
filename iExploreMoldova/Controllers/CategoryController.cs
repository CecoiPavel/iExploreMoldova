using Microsoft.AspNetCore.Mvc;

namespace iExploreMoldova.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
