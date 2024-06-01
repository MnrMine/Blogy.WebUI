using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Writer.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial:ViewComponent
    {
		private readonly UserManager<AppUser> _userManager;

		public _LayoutNavbarComponentPartial(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		public async Task<IViewComponentResult> InvokeAsync(int id)
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			ViewBag.resim = values.ImageUrl;
			ViewBag.adsoyad = values.Name + "" + values.Surname;
			return View();
        }
    }
}
