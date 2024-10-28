using HomeWork11.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork11.Controllers
{
    public class AboutContoller : Controller
    {
        List<AboutModel>aboutList;

        public AboutContoller()
        {
            aboutList =[new AboutModel{Name="Aleyna", Surname="Çelen", School="İstanbul Aydın Üni", Meslek="Software Developer", Ozgecmis= "Hello, I am Aleyna Çelen, I am a 4rd year Industrial Engineering student at Istanbul Aydın University.As an engineer candidate, my biggest goal is to"}];


            

        }
        public ActionResult Index()
        {
            ViewBag.AboutList=aboutList;
            return View();
        }

    }
}
           
