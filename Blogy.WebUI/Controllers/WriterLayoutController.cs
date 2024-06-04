using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Controllers
{
    public class WriterLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
