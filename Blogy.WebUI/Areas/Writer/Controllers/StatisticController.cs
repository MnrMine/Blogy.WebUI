using Blogy.DataAccessLayer.Context;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Writer.Controllers
{       
    [Area("Writer")]
        [Route("Writer/Statistic/")]
    public class StatisticController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly BlogyContext _context;

        public StatisticController(BlogyContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
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
