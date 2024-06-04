using Blogy.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Writer/")]
    public class WriterController : Controller
    {
        private readonly IWriterService _writerService;

        public WriterController(IWriterService writerService)
        {
            _writerService = writerService;
        }

        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var values = _writerService.TGetListAll();
            return View(values);
        }


        [Route("DeleteWriter/{id}")]
        public ActionResult DeleteWriter(int id)
        {
            _writerService.TDelete(id);
            return RedirectToAction("Index");
        }
        [Route("ChangeToTrue/{id}")]
        public IActionResult ChangeToTrue(int id)
        {
            _writerService.TChangeToTrueByWriter(id);
            return RedirectToAction("Index");
        }

        [Route("ChangeToFalse/{id}")]
        public IActionResult ChangeToFalse(int id)
        {
            _writerService.TChangeToFalseByWriter(id);
            return RedirectToAction("Index");
        }

    }
}
