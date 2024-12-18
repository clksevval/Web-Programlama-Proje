using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using web_proje.Models;
using web_proje.Data;

public class LoginController : Controller
{
    private readonly VeritabaniContext _context;

    public LoginController(VeritabaniContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult LoginSayfa()
    {
        return View();
    }


    [HttpPost]
    public IActionResult LoginSayfa(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            // Kullanıcıyı sadece KullaniciAdi ve Sifre'ye göre kontrol edin
            var kullanici = _context.Kullanicilar
                .FirstOrDefault(k => k.KullaniciAd == model.KullaniciAdi && k.KullaniciSifre == model.Sifre);

            if (kullanici != null)
            {
                // Kullanıcının RolId'sini session'a kaydediyoruz.
                HttpContext.Session.SetInt32("RolId", kullanici.RolId);
                if (kullanici.RolId == 1) // Admin RolId
                {
                    return RedirectToAction("Anasayfa_Admin", "Admin");
                }
                else if (kullanici.RolId == 2) // Kullanıcı RolId
                {
                    return RedirectToAction("Anasayfa", "Kullanici");
                }
            }


            ModelState.AddModelError("", "Geçersiz kullanıcı adı veya şifre.");
        }

        return View(model);
    }

}
