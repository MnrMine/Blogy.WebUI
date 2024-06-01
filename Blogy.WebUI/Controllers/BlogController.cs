using Blogy.BusinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public BlogController(UserManager<AppUser> userManager, IArticleService articleService)
        {
            _userManager = userManager;
            _articleService = articleService;
        }

        private readonly IArticleService _articleService;
        public IActionResult BlogyList(string search)
        {
            if (!string.IsNullOrEmpty(search))
            {
                var articles = _articleService.TGetArticleFilterList(search);
                ViewBag.Search = search;
                return View(articles);
            }
            else
            {
                var values = _articleService.TGetArticleWithWriter();
                return View(values);

            }
        }
		public IActionResult BlogyDetail(int id)
		{
            ViewBag.i = id;
			return View();
		}
	}
}
