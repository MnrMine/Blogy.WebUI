using Blogy.DataAccessLayer.Context;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Writer")]
    [Route("Admin/Dashboard/")]
    public class DashboardController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly BlogyContext _context;

        public DashboardController(UserManager<AppUser> userManager, BlogyContext context)
        {
            _userManager = userManager;
            _context = context;
        }


        [Route("")]
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            ViewBag.yazarsayisi = _context.Writers.ToList().Count();
            ViewBag.categorisayisi = _context.Categories.ToList().Count();
            return View();
        }
    }
}
