using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace web_proje.Entity
{
	public class Kullanici
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int KullaniciId { get; set; }
	
		public required string KullaniciAd { get; set; }

		public int KullaniciSifre { get; set; }

		public int RolId { get; set; }
	
	}
}
