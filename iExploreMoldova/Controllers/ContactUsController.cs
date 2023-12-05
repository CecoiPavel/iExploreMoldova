using Microsoft.AspNetCore.Mvc;

namespace iExploreMoldova.Controllers;

public class ContactUsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}