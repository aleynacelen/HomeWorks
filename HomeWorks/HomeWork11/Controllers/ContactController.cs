using Microsoft.AspNetCore.Mvc;

namespace HomeWork11.Controllers
{
    public class ContactController : Controller
    {
        // GET: ContactController
        public ActionResult Index()
        {
            return View();
        }

[HttpPost]
        public IActionResult Submit(string name, string email, string subject, string message)
        {
            

          
            return RedirectToAction("Index", "Home");
        }

    }
}
