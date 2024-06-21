using Microsoft.AspNetCore.Mvc;
using OgrenciYonetim.Models;
using System.Collections.Generic;
using System.Linq;

namespace OgrenciYonetim.Controllers
{
    public class OgrencilerController : Controller
    {
        private static List<Ogrenciler> ogrencilerListesi = new List<Ogrenciler>
        {
            new Ogrenciler { OgrenciNo = 1, Ad = "Ali", Soyad = "Yılmaz", Sinif = 3, DersTanimi = "Matematik (Mat-1)", Kredi = 3, SinavTarihi = new DateTime(2023, 6, 10), VizeNotu = 85, FinalNotu = 90, Ortalama = 87, HarfKarsiligi = "AA", GecmeDurumu = true },
            new Ogrenciler { OgrenciNo = 2, Ad = "Ayşe", Soyad = "Demir", Sinif = 2, DersTanimi = "Fizik (Fiz-2)", Kredi = 4, SinavTarihi = new DateTime(2023, 5, 21), VizeNotu = 78, FinalNotu = 82, Ortalama = 80, HarfKarsiligi = "BB", GecmeDurumu = true },
            new Ogrenciler { OgrenciNo = 3, Ad = "Mehmet", Soyad = "Çelik", Sinif = 1, DersTanimi = "Kimya (Kim-1)", Kredi = 2, SinavTarihi = new DateTime(2023, 4, 15), VizeNotu = 88, FinalNotu = 79, Ortalama = 82, HarfKarsiligi = "BA", GecmeDurumu = true },
            new Ogrenciler { OgrenciNo = 4, Ad = "Fatma", Soyad = "Kara", Sinif = 4, DersTanimi = "Biyoloji (Biy-1)", Kredi = 3, SinavTarihi = new DateTime(2023, 6, 5), VizeNotu = 92, FinalNotu = 85, Ortalama = 88, HarfKarsiligi = "AA", GecmeDurumu = true },
            new Ogrenciler { OgrenciNo = 5, Ad = "Can", Soyad = "Öztürk", Sinif = 3, DersTanimi = "Edebiyat (Ede-1)", Kredi = 2, SinavTarihi = new DateTime(2023, 3, 30), VizeNotu = 55, FinalNotu = 65, Ortalama = 61, HarfKarsiligi = "DD", GecmeDurumu = true }
        };

        public IActionResult Index()
        {
            return View(ogrencilerListesi);
        }

        public IActionResult Detay(int id)
        {
            var ogrenci = ogrencilerListesi.FirstOrDefault(o => o.OgrenciNo == id);
            if (ogrenci == null)
            {
                return NotFound();
            }
            return View(ogrenci);
        }

        public IActionResult Yeni()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Yeni(Ogrenciler yeniOgrenci)
        {
            if (ModelState.IsValid)
            {
                ogrencilerListesi.Add(yeniOgrenci);
                return RedirectToAction("Index");
            }
            return View(yeniOgrenci);
        }

        public IActionResult Guncelle(int id)
        {
            var ogrenci = ogrencilerListesi.FirstOrDefault(o => o.OgrenciNo == id);
            if (ogrenci == null)
            {
                return NotFound();
            }
            return View(ogrenci);
        }

        [HttpPost]
        public IActionResult Guncelle(Ogrenciler guncellenmisOgrenci)
        {
            var ogrenci = ogrencilerListesi.FirstOrDefault(o => o.OgrenciNo == guncellenmisOgrenci.OgrenciNo);
            if (ogrenci == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                ogrenci.Ad = guncellenmisOgrenci.Ad;
                ogrenci.Soyad = guncellenmisOgrenci.Soyad;
                ogrenci.Sinif = guncellenmisOgrenci.Sinif;
                ogrenci.DersTanimi = guncellenmisOgrenci.DersTanimi;
                ogrenci.Kredi = guncellenmisOgrenci.Kredi;
                ogrenci.SinavTarihi = guncellenmisOgrenci.SinavTarihi;
                ogrenci.VizeNotu = guncellenmisOgrenci.VizeNotu;
                ogrenci.FinalNotu = guncellenmisOgrenci.FinalNotu;
                ogrenci.Ortalama = guncellenmisOgrenci.Ortalama;
                ogrenci.HarfKarsiligi = guncellenmisOgrenci.HarfKarsiligi;
                ogrenci.GecmeDurumu = guncellenmisOgrenci.GecmeDurumu;
                return RedirectToAction("Index");
            }
            return View(guncellenmisOgrenci);
        }

        public IActionResult Sil(int id)
        {
            var ogrenci = ogrencilerListesi.FirstOrDefault(o => o.OgrenciNo == id);
            if (ogrenci == null)
            {
                return NotFound();
            }
            return View(ogrenci);
        }

        [HttpPost, ActionName("Sil")]
        public IActionResult SilOnayla(int id)
        {
            var ogrenci = ogrencilerListesi.FirstOrDefault(o => o.OgrenciNo == id);
            if (ogrenci == null)
            {
                return NotFound();
            }
            ogrencilerListesi.Remove(ogrenci);
            return RedirectToAction("Index");
        }
    }
}
