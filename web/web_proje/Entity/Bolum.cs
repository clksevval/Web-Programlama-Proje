using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_proje.Entity
{
	public class Bolum
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int BolumId { get; set; }


		public required string BolumAd { get; set; }

		public int Hasta_Sayisi { get; set; }

		public int Bos_Yatak_Sayisi { get; set; }
	}
}
