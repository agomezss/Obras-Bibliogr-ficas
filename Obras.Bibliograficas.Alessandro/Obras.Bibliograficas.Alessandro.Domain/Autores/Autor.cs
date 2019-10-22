using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Obras.Bibliograficas.Alessandro.Domain
{
	[Table("Autor")]
	public class Autor
	{
		[Required]
		[Key]
		[StringLength(200)]
		public string NomeCompleto { get; set; }

		[StringLength(100)]
		public string SobrenomePrincipal { get; set; }

		[StringLength(100)]
		public string NomesComplementares { get; set; }
	}
}
