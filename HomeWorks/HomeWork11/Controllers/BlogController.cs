using HomeWork11.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork11.Controllers
{
    public class BlogController : Controller
    {
        List<BlogModel>BlogList;


        public BlogController()
        
        {
            BlogList=[
                  new BlogModel{Id=1,Aciklama="1.Acıklama", Baslik="1.Başlık",Resim="https://picsum.photos/id/1/200/300"},
                  new BlogModel{Id=1,Aciklama="2.Acıklama", Baslik="2.aşlık",Resim="https://picsum.photos/id/1/200/300"},
                  new BlogModel{Id=1,Aciklama="3.Acıklama", Baslik="3.Başlık",Resim="https://picsum.photos/id/1/200/300"},
                  new BlogModel{Id=1,Aciklama="4.Acıklama", Baslik="4.Başlık",Resim="https://picsum.photos/id/1/200/300"},
                  new BlogModel{Id=1,Aciklama="5.Acıklama", Baslik="5.Başlık",Resim="https://picsum.photos/id/1/200/300"},
                  new BlogModel{Id=1,Aciklama="6.Acıklama", Baslik="6.Başlık",Resim="https://picsum.photos/id/1/200/300"},
                  new BlogModel{Id=1,Aciklama="7.Acıklama", Baslik="7.Başlık",Resim="https://picsum.photos/id/1/200/300"},
                  new BlogModel{Id=1,Aciklama="8.Acıklama", Baslik="8.Başlık",Resim="https://picsum.photos/id/1/200/300"},
                  new BlogModel{Id=1,Aciklama="9.Acıklama", Baslik="9.Başlık",Resim="https://picsum.photos/id/1/200/300"},
                  new BlogModel{Id=1,Aciklama="10.Acıklama", Baslik="10.Başlık",Resim="https://picsum.photos/id/1/200/300"},

            ];
          

        }








        public ActionResult Index()
        {
            ViewBag.blogList=BlogList;
            return View();
        }

    }
}
