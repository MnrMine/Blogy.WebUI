using Blogy.BusinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/Comment/")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly UserManager<AppUser> _userManager;
        public CommentController(ICommentService commentService, UserManager<AppUser> userManager)
        {
            _commentService = commentService;
            _userManager = userManager;
        }

        [Route("")]
        [Route("CommentList")]
        public async Task<IActionResult> CommentList()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = _commentService.TGetCommentsByArticleId(user.Id);
            return View(values);
        }
        [HttpGet]
        [Route("ReadComment/{id}")]
        public async Task<IActionResult> ReadComment(int id)
        {
            var value = _commentService.TGetById(id);
            return View(value);
        }
        [Route("DeleteComment/{id}")]
        public IActionResult DeleteComment(int id)
        {
            _commentService.TDelete(id);
            return RedirectToAction("CommentList");
        }
    }
}
