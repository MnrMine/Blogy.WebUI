using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Controllers
{
	public class ErrorPageController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
