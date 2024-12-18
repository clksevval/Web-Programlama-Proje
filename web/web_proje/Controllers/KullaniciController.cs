using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using web_proje.Data;
using web_proje.Entity;
using web_proje.Models;
namespace web_proje.Controllers
{
    [RolFiltre(2)] // Sadece RolId = 2 (User) olan kullanýcýlar eriþebilir
    public class KullaniciController : Controller
    {
        private readonly VeritabaniContext _context;

        public KullaniciController(VeritabaniContext context)
        {
            _context = context;
        }

        public IActionResult Anasayfa()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Takvim()
        {
            ViewBag.NobetListe = _context.Nobetler.ToList();

            return View();

        }

        public IActionResult Asistan_Bilgi()
        {
            ViewBag.AsistanListe = _context.Asistanlar.ToList();
            return View();
        }

        public IActionResult Hoca_Bilgi()
        {
            ViewBag.HocaListe = _context.Hocalar.ToList();
            return View();
        }
        public IActionResult Bolum_Bilgi()
        {
            ViewBag.BolumListe = _context.Bolumler.ToList();
            return View();
        }

        // ///////////////////////////////////////////////////////////////////////////
        public IActionResult Randevu()
        {
            ViewBag.RandevuListe = _context.Randevular.ToList();
            return View();
        }

        //Haber Güncelleme
        [HttpGet]
        public IActionResult Update_Randevu(int ID)
        {
            var Guncellenecek_Randevu = _context.Randevular.Find(ID);

            return View(Guncellenecek_Randevu);
        }
        [HttpPost]
        public IActionResult Update_Randevu(Randevu r)
        {
            _context.Update(r);
            _context.SaveChanges();
            return RedirectToAction(nameof(Randevu));
        }


        // ////////////////////////////////////////////////////////////////////////////////////
        public IActionResult Acil_Durum()
        {
            ViewBag.Acil_DurumListe = _context.Acil_Durumlar.ToList();
            return View();
        }

    }
}

