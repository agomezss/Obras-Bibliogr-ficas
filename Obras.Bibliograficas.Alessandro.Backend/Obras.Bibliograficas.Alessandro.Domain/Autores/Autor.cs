using Obras.Bibliograficas.Alessandro.Domain.Autores;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Obras.Bibliograficas.Alessandro.Domain
{
	[Table("Autor")]
	public class Autor
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		[StringLength(200)]
		public string Nome { get; set; }

		public string NomeFormatado { get; set; }

		public void FormatarNome(AutorNomeProvider provedorNomeAutoral)
		{
			NomeFormatado = provedorNomeAutoral.AplicarRegrasNome(Nome);
		}
	}
}
