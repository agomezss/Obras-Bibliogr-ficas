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


		public void FormatarNome(string nome, IAutorNomeProvider provider)
		{
			Nome = provider.AplicarRegrasNome(nome);
		}
	}
}
