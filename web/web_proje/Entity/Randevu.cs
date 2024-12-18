using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace web_proje.Entity
{
	public class Randevu
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int RandevuId { get; set; }

		public int HocaId {  get; set; }

		public int AsistanId { get; set; }

		public DateTime Randevu_Tarihi { get; set; }

	}
}
