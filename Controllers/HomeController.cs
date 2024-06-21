using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OgrenciYonetim.Models;
using System.Collections.Generic;
using System.Linq;

namespace OgrenciYonetim.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private static List<Ogrenciler> ogrenciListesi = new List<Ogrenciler>
        {
            new Ogrenciler { OgrenciNo = 1, Ad = "Ali", Soyad = "Veli", Sinif = 1, DersTanimi = "Mat-1", Kredi = 3, SinavTarihi = DateTime.Now, VizeNotu = 75, FinalNotu = 80, Ortalama = 77.5, HarfKarsiligi = "BB", GecmeDurumu = true },
            new Ogrenciler { OgrenciNo = 2, Ad = "Ayşe", Soyad = "Fatma", Sinif = 2, DersTanimi = "Fiz-2", Kredi = 4, SinavTarihi = DateTime.Now, VizeNotu = 85, FinalNotu = 90, Ortalama = 87.5, HarfKarsiligi = "AA", GecmeDurumu = true },
            new Ogrenciler { OgrenciNo = 3, Ad = "Mehmet", Soyad = "Demir", Sinif = 3, DersTanimi = "Kim-3", Kredi = 2, SinavTarihi = DateTime.Now, VizeNotu = 65, FinalNotu = 70, Ortalama = 67.5, HarfKarsiligi = "CC", GecmeDurumu = true },
            new Ogrenciler { OgrenciNo = 4, Ad = "Elif", Soyad = "Yılmaz", Sinif = 4, DersTanimi = "Bio-4", Kredi = 3, SinavTarihi = DateTime.Now, VizeNotu = 95, FinalNotu = 100, Ortalama = 97.5, HarfKarsiligi = "AA", GecmeDurumu = true },
            new Ogrenciler { OgrenciNo = 5, Ad = "Ahmet", Soyad = "Kaya", Sinif = 5, DersTanimi = "Geo-5", Kredi = 4, SinavTarihi = DateTime.Now, VizeNotu = 55, FinalNotu = 60, Ortalama = 57.5, HarfKarsiligi = "DD", GecmeDurumu = false }
        };

        public IActionResult Index()
        {
            return View(ogrenciListesi);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Yeni()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Yeni(Ogrenciler yeniOgrenci)
        {
            ogrenciListesi.Add(yeniOgrenci);
            return RedirectToAction("Index");
        }

        public IActionResult Detay(int id)
        {
            var ogrenci = ogrenciListesi.FirstOrDefault(o => o.OgrenciNo == id);
            return View(ogrenci);
        }

        public IActionResult Guncelle(int id)
        {
            var ogrenci = ogrenciListesi.FirstOrDefault(o => o.OgrenciNo == id);
            return View(ogrenci);
        }

        [HttpPost]
        public IActionResult Guncelle(Ogrenciler guncelOgrenci)
        {
            var ogrenci = ogrenciListesi.FirstOrDefault(o => o.OgrenciNo == guncelOgrenci.OgrenciNo);
            if (ogrenci != null)
            {
                ogrenci.Ad = guncelOgrenci.Ad;
                ogrenci.Soyad = guncelOgrenci.Soyad;
                ogrenci.Sinif = guncelOgrenci.Sinif;
                ogrenci.DersTanimi = guncelOgrenci.DersTanimi;
                ogrenci.Kredi = guncelOgrenci.Kredi;
                ogrenci.SinavTarihi = guncelOgrenci.SinavTarihi;
                ogrenci.VizeNotu = guncelOgrenci.VizeNotu;
                ogrenci.FinalNotu = guncelOgrenci.FinalNotu;
                ogrenci.Ortalama = guncelOgrenci.Ortalama;
                ogrenci.HarfKarsiligi = guncelOgrenci.HarfKarsiligi;
                ogrenci.GecmeDurumu = guncelOgrenci.GecmeDurumu;
            }
            return RedirectToAction("Index");
        }

        public IActionResult Sil(int id)
        {
            var ogrenci = ogrenciListesi.FirstOrDefault(o => o.OgrenciNo == id);
            return View(ogrenci);
        }

        [HttpPost]
        public IActionResult SilOnayla(int id)
        {
            var ogrenci = ogrenciListesi.FirstOrDefault(o => o.OgrenciNo == id);
            if (ogrenci != null)
            {
                ogrenciListesi.Remove(ogrenci);
            }
            return RedirectToAction("Index");
        }
    }
}
