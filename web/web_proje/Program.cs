using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using web_proje.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using web_proje.Entity;


var builder = WebApplication.CreateBuilder(args);

//Eski Takvim Lisansý
//Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NDaF1cWGhIYVBpR2Nbek5xdl9EYlZQQGYuP1ZhSXxXd0djXX9ec3RQRWldVEY=");


// Session'ý yapýlandýrma
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Session süresi
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// Add services to the container.
builder.Services.AddControllersWithViews();

//Veritabaný Baðlantýsý
builder.Services.AddDbContext<VeritabaniContext>(options =>
{
    options.UseSqlServer("Server=SEVVAL\\SEVVAL;Database=VeritabaniDB;Trusted_Connection=True;TrustServerCertificate=True;");
});

// Add Authentication (Kimlik doðrulama hizmeti)
builder.Services.AddAuthentication("CookieAuth")
    .AddCookie("CookieAuth", options =>
    {
        options.LoginPath = "/Login"; // Login sayfasýnýn yolu
        options.AccessDeniedPath = "/AccessDenied"; // Yetkisiz eriþim sayfasý
    });

// Add Authorization (Yetkilendirme hizmeti)
builder.Services.AddAuthorization();



var app = builder.Build();
// Middleware kullanýmý
app.UseSession();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=LoginSayfa}/{id?}");








app.Run();
