using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FakeStoreApi.Models;
namespace FakeStoreApi.Controllers;

public class HomeController : Controller
{
   

    public IActionResult Index()
    {
        using (HttpClient httpClient=new HttpClient())
        {
            
        }
        return View();
    }

  
}
