using HomeWork11.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork11.Controllers
{
    public class AboutContoller : Controller
    {
        // GET: AboutContoller
        public ActionResult Index()
        {
            new AboutModel{Ozgecmis= "Hello, I am Aleyna Çelen, I am a 4rd year Industrial Engineering student at Istanbul Aydın University. As an engineer candidate, my biggest goal is to"};
            return View();
        }

    }
}
