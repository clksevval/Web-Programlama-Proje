using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_proje.Entity
{
	public class Asistan
	{
		//Primary Key => Id,<TypeName>Id
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int AsistanId { get; set; }
		

		public required string AsistanAd { get; set; }

		public required string AsistanSoyad { get; set; }

		public int AsistanYas { get; set; }
		public long AsistanTel { get; set; }
		public required string AsistanMail { get; set; }
		public DateTime Nobet_Tarihi { get; set; }

		public int BolumId { get; set; }
	}
}
