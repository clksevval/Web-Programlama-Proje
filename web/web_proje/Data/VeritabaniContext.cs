using Microsoft.EntityFrameworkCore;
using web_proje.Entity;

namespace web_proje.Data
{
	public class VeritabaniContext : DbContext
	{
		//Tabloları Oluşturma
		public DbSet<Asistan> Asistanlar { get; set; }

		public DbSet<Bolum> Bolumler { get; set; }

		public DbSet<Hoca> Hocalar { get; set; }

		public DbSet<Nobet> Nobetler { get; set; }

		public DbSet<Randevu> Randevular { get; set; }

		public DbSet<Acil_Durum> Acil_Durumlar { get; set; }

		public DbSet<Kullanici> Kullanicilar { get; set; }

		public DbSet<Rol> Roller { get; set; }


		public VeritabaniContext(DbContextOptions options): base(options) //Database Oluşturma Kısmı
		{
		}

	}
}
