using Obras.Bibliograficas.Alessandro.Domain.Autores;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Obras.Bibliograficas.Alessandro.Domain
{
	[Table("Autor")]
	public class Autor
	{
		[Required]
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		[StringLength(200)]
		public string Nome { get; set; }

		[StringLength(200)]
		public string NomeFormatado { get; set; }

		public void FormatarNome(IAutorNomeProvider provedorNomeAutoral)
		{
			NomeFormatado = provedorNomeAutoral.AplicarRegrasNome(Nome);
		}
	}
}
