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

        int Topla()
        {
            int s1 = 10;
            int s2 = 20;
            int sum = s1 + s2;
            return sum;
        }

        int Cevre()
        {
            int kisakenar = 10;
            int uzunkenar = 20;
            int sonuc= (kisakenar + uzunkenar) * 2;
            return sonuc;
        }

        void MesajListesi(string p)
        {
            ViewBag.p1 = p;
        }

        void KullaniciAdi(string ad)
        {
            ViewBag.ad1 = ad;
        }
        int Topla(int num1, int num2)
        {
            int sonuc = num1 + num2;
            return sonuc;
        }
        int Faktoriyel(int num)
        {
            int f = 1;
            for (int i = 1; i <= num; i++)
            {
                f *= i;
            }
            return f;
        }

        public IActionResult Index()
        {
            Mesajlar();
            MesajListesi("parametre  ismi");
            KullaniciAdi("admin");
            ViewBag.tp = Topla(20, 30);
            return View();
        }
        public IActionResult Urunler()
        {
            Mesajlar();
            KullaniciAdi("melih");
            ViewBag.t = Topla();
            ViewBag.c = Cevre();
            ViewBag.fak = Faktoriyel(5);
            return View();
        }
        public IActionResult Deneme()
        {
            Sehirler sehirler = new Sehirler();
            sehirler.Id = 1;
            sehirler.Ad = "bartın";
            sehirler.Nufus = 1000000;
            sehirler.Ulke = "turkiye";
            ViewBag.s1 = sehirler.Id;
            ViewBag.s2 = sehirler.Ad;
            ViewBag.s3 = sehirler.Nufus;
            ViewBag.s4 = sehirler.Ulke;

            sehirler.Renk1 = "kırmızı";
            sehirler.Renk2 = "beyaz";
            ViewBag.b1 = sehirler.Renk1;
            ViewBag.b2 = sehirler.Renk2;

            sehirler.Id = 2;
            sehirler.Ad = "zonguldak";
            sehirler.Nufus = 2000000;
            sehirler.Ulke = "almanya";
            ViewBag.t1 = sehirler.Id;
            ViewBag.t2 = sehirler.Ad;
            ViewBag.t3 = sehirler.Nufus;
            ViewBag.t4 = sehirler.Ulke;

            sehirler.Renk1 = "sarı";
            sehirler.Renk2 = "kırmızı";
            ViewBag.t5 = sehirler.Renk1;
            ViewBag.t6 = sehirler.Renk2;

            return View();
        }
    }
}
