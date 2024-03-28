using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents
{
	public class _BlogyListHeadComponentPartial :ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}

	}
}
