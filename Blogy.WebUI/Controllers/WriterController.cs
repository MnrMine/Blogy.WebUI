using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Controllers
{
	public class WriterController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
