using Blogy.BusinessLayer.Abstract;
using Blogy.DataAccessLayer.Context;
using Blogy.WebUI.Areas.Writer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/Chart/")]
    public class ChartController : Controller
    {
        private readonly ICategoryService _categoryService;
        BlogyContext _context;

        public ChartController(ICategoryService categoryService, BlogyContext context)
        {
            _categoryService = categoryService;
            _context = context;
        }

        [Route("")]
        [Route("Index")]
        public IActionResult Index()

        {
            return View();
        }
        [Route("GetCategoryChart")]
        public IActionResult GetCategoryChart()
        {
            var values = _context.Articles.GroupBy(x => x.CategoryId).Select(y => new ChartModel
            {

                categoryname = _context.Categories.Where(x => x.CategoryId == y.Key).Select(z => z.CategoryName).FirstOrDefault(),
                count = y.Count(),
            }).ToList();

            return Json(new { jsonlist = values });

        }
    }
}
