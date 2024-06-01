using Blogy.BusinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Writer.ViewComponents.LayoutViewComponents
{
    public class _LayoutMessageComponentPartial:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMessageService _messageService;

        public _LayoutMessageComponentPartial(UserManager<AppUser> userManager, IMessageService messageService)
        {
            _userManager = userManager;
            _messageService = messageService;
        }
        public async Task<IViewComponentResult> InvokeAsync(string p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            p = user.Email;
            var messagelist = _messageService.TGetMessageListByWriter(p);
            ViewBag.mesajsayisi = _messageService.TGetMessageListByWriter(p).Count();
            return View(messagelist);
        }
    }
}
