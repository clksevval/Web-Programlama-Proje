using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace web_proje.Entity
{
	public class Acil_Durum
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Acil_DurumId { get; set; }

		public required string Baslik {  get; set; }

		public required string Aciklama { get; set; }

		public DateTime Tarih {  get; set; }

	}
}
