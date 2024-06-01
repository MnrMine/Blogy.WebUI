using Blogy.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailViewComponents
{
    public class _BlogDetailGetOtherBlogPostByWriterComponentPartial:ViewComponent
    {
        private readonly IArticleService _articleService;

        public _BlogDetailGetOtherBlogPostByWriterComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = _articleService.TGetOtherBlogPostByWriter(id);
            return View(values);
        }
    }
}
