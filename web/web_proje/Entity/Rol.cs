using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace web_proje.Entity
{
	public class Rol
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int RolId { get; set; }

		public required string RolAd {  get; set; }
	}
}
