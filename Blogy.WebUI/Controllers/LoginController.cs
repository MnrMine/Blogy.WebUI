using Blogy.DataAccessLayer.Context;
using Blogy.EntityLayer.Concrete;
using Blogy.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blogy.WebUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        BlogyContext _context = new BlogyContext();

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSignInViewModel model)
        {
            if (model.Username != null && model.Password != null)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, true);
               
                if (result.Succeeded)
                {
                    return RedirectToAction("MyBlogList", "Blog", new { area = "Writer" });

                }
                else
                {
                    ModelState.AddModelError("", " Kullanıcı adı veya şifre hatalı");
                }
            }
            else
            {
                ModelState.AddModelError("", "Lutfen alanları bos gecmeyin");
            }
            return View();
        }
    }
}
