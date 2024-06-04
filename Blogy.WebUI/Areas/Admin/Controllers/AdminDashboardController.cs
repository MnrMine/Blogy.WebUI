using Blogy.BusinessLayer.Abstract;
using Blogy.DataAccessLayer.Context;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminDashboard/")]
    public class AdminDashboardController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly BlogyContext _context;
        private readonly IArticleService _articleService;

        public AdminDashboardController(UserManager<AppUser> userManager, BlogyContext context, IArticleService articleService)
        {
            _userManager = userManager;
            _context = context;
            _articleService = articleService;
        }


        [Route("")]
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            ViewBag.yazarsayisi = _context.Writers.ToList().Count();
            ViewBag.categorisayisi = _context.Categories.ToList().Count();
            ViewBag.sagliksayisi = _articleService.TGetListAll().Where(x => x.CategoryId == 4).Count();
            return View();
        }
    }
}
