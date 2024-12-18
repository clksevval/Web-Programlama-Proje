using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace web_proje.Entity
{
	public class Nobet
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int NobetId { get; set; }

		public int AsistanId { get; set; }

		public int BolumId { get; set; }

		public DateTime Nobet_Tarihi { get; set; }
		
		//MigrationGüncelleme
		public DateTime Nobet_Tarihi_Bitis { get; set; }
	}

}
