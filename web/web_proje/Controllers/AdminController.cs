using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using web_proje.Data;
using web_proje.Entity;
using web_proje.Models;

namespace web_proje.Controllers
{
    [RolFiltre(1)] // Sadece RolId = 1 (Admin) olan kullanıcılar erişebilir
    public class AdminController : Controller
	{
        private readonly VeritabaniContext _context;

        public AdminController(VeritabaniContext context)
        {
            _context = context;
        }

        public IActionResult Anasayfa_Admin()
        {
            ViewBag.KullaniciListe = _context.Kullanicilar.ToList();
            return View();
        }

        //Kullanıcı Ekleme
        [HttpPost]
        public IActionResult Anasayfa_Admin(Kullanici yeni_kullanici)
        {
            _context.Add(yeni_kullanici);
            _context.SaveChanges();

            return RedirectToAction(nameof(Anasayfa_Admin));
        }


        //Kullanıcı Güncelleme
        [HttpGet]
        public IActionResult Update_Kullanici(int ID)
        {
            var Guncellenecek_Kullanici = _context.Kullanicilar.Find(ID);

            return View(Guncellenecek_Kullanici);
        }
        [HttpPost]
        public IActionResult Update_Kullanici(Kullanici k)
        {
            _context.Update(k);
            _context.SaveChanges();
            return RedirectToAction(nameof(Anasayfa_Admin));
        }




        //Kullanıcı Silme
        [HttpPost]
        public IActionResult Delete_Kullanici(int id)
        {
            // Id Kaydı Var Mı 
            var Silinecek_Kullanici = _context.Kullanicilar.Find(id);

            // Null Kontrolü
            if (Silinecek_Kullanici == null)
            {
                return Json(new { success = false, message = "Kayıt bulunamadı!" });
            }

            // Silme İşlemi
            _context.Kullanicilar.Remove(Silinecek_Kullanici);
            _context.SaveChanges(); // Değişiklikleri veritabanına uygula

            return RedirectToAction(nameof(Anasayfa_Admin));
        }
        // ///////////////////////////////////////////////////////////////////////////////////
        [HttpGet]
        public IActionResult Asistan_Bilgi_Admin()
        {
            ViewBag.AsistanListe = _context.Asistanlar.ToList();
            return View();
        }

        //Asistan Ekleme
        [HttpPost]
        public IActionResult Asistan_Bilgi_Admin(Asistan yeni_asistan)
        {
            _context.Add(yeni_asistan);
            _context.SaveChanges();

            return RedirectToAction(nameof(Asistan_Bilgi_Admin));
        }


        //Asistan Güncelleme
        [HttpGet]
        public IActionResult Update(int ID)
        {
            var Guncellenecek_Kisi = _context.Asistanlar.Find(ID);

            return View(Guncellenecek_Kisi);
        }
        [HttpPost]
        public IActionResult Update(Asistan a)
        {
            _context.Update(a);
            _context.SaveChanges();
            return RedirectToAction(nameof(Asistan_Bilgi_Admin));
        }




        //Asistan Silme
        [HttpPost]
        public IActionResult Delete(int id)
        {
            // Id Kaydı Var Mı 
            var Silinecek_Kisi = _context.Asistanlar.Find(id);

            // Null Kontrolü
            if (Silinecek_Kisi == null)
            {
                return Json(new { success = false, message = "Kayıt bulunamadı!" });
            }

            // Silme İşlemi
            _context.Asistanlar.Remove(Silinecek_Kisi);
            _context.SaveChanges(); // Değişiklikleri veritabanına uygula

            return RedirectToAction(nameof(Asistan_Bilgi_Admin));
        }

        // ///////////////////////////////////////////////////////////////////////////////////////////////


        [HttpGet]
        public IActionResult Hoca_Bilgi_Admin()
        {
            ViewBag.HocaListe = _context.Hocalar.ToList();
            return View();
        }

        //Hoca Ekleme
        [HttpPost]
        public IActionResult Hoca_Bilgi_Admin(Hoca yeni_hoca)
        {
            _context.Add(yeni_hoca);
            _context.SaveChanges();

            return RedirectToAction(nameof(Hoca_Bilgi_Admin));
        }


        //Hoca Güncelleme
        [HttpGet]
        public IActionResult Update_Hoca(int ID)
        {
            var Guncellenecek_Hoca = _context.Hocalar.Find(ID);

            return View(Guncellenecek_Hoca);
        }
        [HttpPost]
        public IActionResult Update_Hoca(Hoca h)
        {
            _context.Update(h);
            _context.SaveChanges();
            return RedirectToAction(nameof(Hoca_Bilgi_Admin));
        }




        //Hoca Silme
        [HttpPost]
        public IActionResult Delete_Hoca(int id)
        {
            // Id Kaydı Var Mı 
            var Silinecek_Hoca = _context.Hocalar.Find(id);

            // Null Kontrolü
            if (Silinecek_Hoca == null)
            {
                return Json(new { success = false, message = "Kayıt bulunamadı!" });
            }

            // Silme İşlemi
            _context.Hocalar.Remove(Silinecek_Hoca);
            _context.SaveChanges(); // Değişiklikleri veritabanına uygula

            return RedirectToAction(nameof(Hoca_Bilgi_Admin));
        }

        // ///////////////////////////////////////////////////////////////////////////////

        [HttpGet]
        public IActionResult Bolum_Bilgi_Admin()
        {
            ViewBag.BolumListe = _context.Bolumler.ToList();
            return View();
        }

        //Bolum  Ekleme
        [HttpPost]
        public IActionResult Bolum_Bilgi_Admin(Bolum yeni_bolum)
        {
            _context.Add(yeni_bolum);
            _context.SaveChanges();

            return RedirectToAction(nameof(Bolum_Bilgi_Admin));
        }


        //Bolum Güncelleme
        [HttpGet]
        public IActionResult Update_Bolum(int ID)
        {
            var Guncellenecek_Bolum = _context.Bolumler.Find(ID);

            return View(Guncellenecek_Bolum);
        }
        [HttpPost]
        public IActionResult Update_Bolum(Bolum b)
        {
            _context.Update(b);
            _context.SaveChanges();
            return RedirectToAction(nameof(Bolum_Bilgi_Admin));
        }




        //Bolum Silme
        [HttpPost]
        public IActionResult Delete_Bolum(int id)
        {
            // Id Kaydı Var Mı 
            var Silinecek_Bolum = _context.Bolumler.Find(id);

            // Null Kontrolü
            if (Silinecek_Bolum == null)
            {
                return Json(new { success = false, message = "Kayıt bulunamadı!" });
            }

            // Silme İşlemi
            _context.Bolumler.Remove(Silinecek_Bolum);
            _context.SaveChanges(); // Değişiklikleri veritabanına uygula

            return RedirectToAction(nameof(Bolum_Bilgi_Admin));
        }


        // ////////////////////////////////////////////////////////////////////////////////////


        [HttpGet]
        public IActionResult Takvim_Admin()
        {
            ViewBag.NobetListe = _context.Nobetler.ToList();
            return View();
        }

        //Hoca Ekleme
        [HttpPost]
        public IActionResult Takvim_Admin(Nobet yeni_nobet)
        {
            _context.Add(yeni_nobet);
            _context.SaveChanges();

            return RedirectToAction(nameof(Takvim_Admin));
        }


        //Hoca Güncelleme
        [HttpGet]
        public IActionResult Update_Nobet(int ID)
        {
            var Guncellenecek_Nobet = _context.Nobetler.Find(ID);

            return View(Guncellenecek_Nobet);
        }
        [HttpPost]
        public IActionResult Update_Nobet(Nobet n)
        {
            _context.Update(n);
            _context.SaveChanges();
            return RedirectToAction(nameof(Takvim_Admin));
        }




        //Hoca Silme
        [HttpPost]
        public IActionResult Delete_Nobet(int id)
        {
            // Id Kaydı Var Mı 
            var Silinecek_Nobet = _context.Nobetler.Find(id);

            // Null Kontrolü
            if (Silinecek_Nobet == null)
            {
                return Json(new { success = false, message = "Kayıt bulunamadı!" });
            }

            // Silme İşlemi
            _context.Nobetler.Remove(Silinecek_Nobet);
            _context.SaveChanges(); // Değişiklikleri veritabanına uygula

            return RedirectToAction(nameof(Takvim_Admin));
        }

        // ///////////////////////////////////////////////////////////////////////////////


        [HttpGet]
        public IActionResult Randevu_Admin()
        {
            ViewBag.RandevuListe = _context.Randevular.ToList();
            return View();
        }

        //Randevu Tarihi Ekleme
        [HttpPost]
        public IActionResult Randevu_Admin(Randevu yeni_randevu)
        {
            _context.Add(yeni_randevu);
            _context.SaveChanges();

            return RedirectToAction(nameof(Randevu_Admin));
        }


        //Randevu Tarihi Silme
        [HttpPost]
        public IActionResult Delete_Randevu(int id)
        {
            // Id Kaydı Var Mı 
            var Silinecek_Randevu = _context.Randevular.Find(id);

            // Null Kontrolü
            if (Silinecek_Randevu == null)
            {
                return Json(new { success = false, message = "Kayıt bulunamadı!" });
            }

            // Silme İşlemi
            _context.Randevular.Remove(Silinecek_Randevu);
            _context.SaveChanges(); // Değişiklikleri veritabanına uygula

            return RedirectToAction(nameof(Randevu_Admin));
        }
        // ///////////////////////////////////////////////////////////////////////////////

        [HttpGet]
        public IActionResult Acil_Durum_Admin()
        {
            ViewBag.Acil_DurumListe = _context.Acil_Durumlar.ToList();
            return View();
        }

        //Haber  Ekleme
        [HttpPost]
        public IActionResult Acil_Durum_Admin(Acil_Durum yeni_haber)
        {
            _context.Add(yeni_haber);
            _context.SaveChanges();

            return RedirectToAction(nameof(Acil_Durum_Admin));
        }


        //Haber Güncelleme
        [HttpGet]
        public IActionResult Update_Acil_Durum(int ID)
        {
            var Guncellenecek_Haber = _context.Acil_Durumlar.Find(ID);

            return View(Guncellenecek_Haber);
        }
        [HttpPost]
        public IActionResult Update_Acil_Durum(Acil_Durum e)
        {
            _context.Update(e);
            _context.SaveChanges();
            return RedirectToAction(nameof(Acil_Durum_Admin));
        }




        //Haber Silme
        [HttpPost]
        public IActionResult Delete_Acil_Durum(int id)
        {
            // Id Kaydı Var Mı 
            var Silinecek_Haber = _context.Acil_Durumlar.Find(id);

            // Null Kontrolü
            if (Silinecek_Haber == null)
            {
                return Json(new { success = false, message = "Kayıt bulunamadı!" });
            }

            // Silme İşlemi
            _context.Acil_Durumlar.Remove(Silinecek_Haber);
            _context.SaveChanges(); // Değişiklikleri veritabanına uygula

            return RedirectToAction(nameof(Acil_Durum_Admin));
        }


        // ////////////////////////////////////////////////////////////////////////////////////


    }
}
