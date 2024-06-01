using Blogy.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailViewComponents
{
	public class _BlogyDetailByCoverInfoComponentPartial:ViewComponent
	{
		private readonly IArticleService _articleService;

		public _BlogyDetailByCoverInfoComponentPartial(IArticleService articleService)
		{
			_articleService = articleService;
		}

		public IViewComponentResult Invoke(int id)
		{
			var values = _articleService.TGetArticleByIdWithWriterIdAndCategory(id);
            return View(values);

		}
	}
}
