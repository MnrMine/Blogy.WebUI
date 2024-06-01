using Blogy.BusinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Blogy.WebUI.Areas.Writer.Controllers
{
    [Area("Writer")]
	[Route("Writer/Blog/")]
	public class BlogController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        private readonly ICommentService _commentService;



        public BlogController(UserManager<AppUser> userManager,  IArticleService articleService,ICategoryService categoryService, ICommentService commentService)
        {
            _userManager = userManager;
            _articleService =articleService;
            _categoryService = categoryService;
            _commentService = commentService;
        }
	 [Route("")]
		[Route("MyBlogList")]
		public async Task<IActionResult> MyBlogList()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            //ViewBag.id = user.Id + " " + user.Name + " " + user.Surname;

            var values = _articleService.TGetArticlesByWriter(user.Id);

            return View(values);
        }
        [HttpGet]
        [Route("CreateBlog")]
        public IActionResult CreateBlog()
        {
            List<SelectListItem> values =( from x in _categoryService.TGetListAll()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        [Route("CreateBlog")]
        public async Task<IActionResult> CreateBlog(Article article)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            article.ArticleId = user.Id;
            article.WriterId = user.Id;
            article.CreatedDate = DateTime.Now;
            _articleService.TInsert(article);
            return RedirectToAction("MyBlogList");
        }
        [Route("DeleteBlog/{id}")]
        public IActionResult DeleteBlog(int id)
        {
            _articleService.TDelete(id);
              return RedirectToAction("MyBlogList");
        }
        [HttpGet]
        [Route("EditBlog/{id}")]
        public IActionResult EditBlog(int id)
        {
            var values = _articleService.TGetById(id);
            List<SelectListItem> category = (from x in _categoryService.TGetListAll()
                                             select new SelectListItem
                                             {
                                                 Text = x.CategoryName,
                                                 Value = x.CategoryId.ToString()
                                             }).ToList();
            ViewBag.v = category;
            return View(values);

        }
        [HttpPost]
        [Route("EditBlog/{id}")]
        public IActionResult EditBlog(Article article)
        {
            article.CreatedDate = DateTime.Now;
            _articleService.TUpdate(article);
            return RedirectToAction("MyBlogList");
        }
        [Route("BlogArticleComment/{id}")]
        public IActionResult BlogArticleComment(int id)
        {
            var values = _commentService.TGetCommentsByArticleId(id);
            return View(values);
        }
    }
}
