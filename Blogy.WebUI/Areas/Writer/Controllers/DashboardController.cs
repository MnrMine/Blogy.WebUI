using Blogy.DataAccessLayer.Context;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/Dashboard/")]


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
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.blogsayisi = _context.Articles.Where(x => x.AppUserId == user.Id).ToList().Count();
            ViewBag.bildirimsayisi = _context.Notifications.ToList().Count();
            ViewBag.mesajsayisi = _context.Messages.ToList().Count();

            return View();
        }
    }
}
