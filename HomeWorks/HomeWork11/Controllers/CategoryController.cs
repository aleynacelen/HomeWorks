using Microsoft.AspNetCore.Mvc;

namespace HomeWork11.Controllers
{
    public class CategoryController : Controller
    {
        
        public ActionResult Index()

        {
            ViewBag.Categories = new List<string> { "Teknoloji", "Sağlık", "Spor" };
            return View();
        }

    }
}
