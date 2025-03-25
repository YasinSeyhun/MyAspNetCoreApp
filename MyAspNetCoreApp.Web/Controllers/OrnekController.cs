using Microsoft.AspNetCore.Mvc;

namespace MyAspNetCoreApp.Web.Controllers
{
    public class OrnekController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return RedirectToAction("Index","Ornek");
        }

        public IActionResult ContentResult()
        {
            return Content("ornekcontentsayfasi");
        }

        public IActionResult JsonResult()
        {
            return Json(new { name = "value" });
        }

        public IActionResult EmptyResult()
        {
            return new EmptyResult();
        }

        public IActionResult ParametreView(int id)
        {
            return RedirectToAction("JsonResultParametre", "Ornek", new { id = id });
        }

        public IActionResult JsonResultParametre(int id)
        {
            return Json(new { id = id });
        }
    }
}
