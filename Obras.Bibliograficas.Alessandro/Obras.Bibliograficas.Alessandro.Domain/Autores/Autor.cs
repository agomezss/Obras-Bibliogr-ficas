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
		public int Id { get; set; }

		[Required]
		[Key]
		[StringLength(200)]
		public string Nome { get; set; }


		public void FormatarNome(string nome, IAutorNomeProvider provider)
		{
			Nome = provider.AplicarRegrasNome(nome);
		}
	}
}
