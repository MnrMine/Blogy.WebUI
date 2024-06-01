using Blogy.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents
{
	public class _BlogListComponentPartial:ViewComponent
	{
		private readonly IArticleService _articlesService;

		public _BlogListComponentPartial(IArticleService articlesService)
		{
			_articlesService = articlesService;
		}
		public IViewComponentResult Invoke()
		{
			var values = _articlesService.TGetArticleWithWriter();
			return View(values);
		}

	}
}
