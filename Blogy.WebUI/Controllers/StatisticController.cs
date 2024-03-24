using Blogy.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Controllers
{
    public class StatisticController : Controller
    {
        private readonly ICategoryService _categoryService;
   public StatisticController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            ViewBag.v = _categoryService.TGetCategoryCount();
            return View();
        }
    }
}
