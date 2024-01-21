using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Ornekler;

namespace Proje_OOP.Controllers
{
    public class DefaultController : Controller
    {
        //void İslemler()
        //{
        //    Class1 class1 = new Class1();
        //    class1.Topla();
        //}

        void Mesajlar()
        {
            ViewBag.m1 = "merhaba";
            ViewBag.m2 = "selam";
            ViewBag.m3 = "Melih";
        }

        public IActionResult Index()
        {
            Mesajlar();
            return View();
        }
        public IActionResult Urunler()
        {
            Mesajlar();
            return View();
        }
    }
}
