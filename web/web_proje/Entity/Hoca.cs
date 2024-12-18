using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace web_proje.Entity
{
	public class Hoca
	{
			//Primary Key => Id,<TypeName>Id
			[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
			public int HocaId { get; set; }


			public required string HocaAd { get; set; }

			public required string HocaSoyad { get; set; }

			public int HocaYas { get; set; }
			public long HocaTel { get; set; }
			public required string HocaMail { get; set; }

			public int BolumId { get; set; }
		
	}

}

