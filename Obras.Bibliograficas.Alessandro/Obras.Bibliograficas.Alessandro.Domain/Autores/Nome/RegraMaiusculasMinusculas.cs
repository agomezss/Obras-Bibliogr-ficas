
namespace Obras.Bibliograficas.Alessandro.Domain.Autores.Nome
{
	public class RegraMaiusculasMinusculas : IAutorNomeRegra
	{
		public string Aplicar(string nome)
		{
			if (!nome.Contains(",")) return nome;

			var posicoesNome = nome.Split(',');
			posicoesNome[0] = posicoesNome[0].ToUpper();
			
			return string.Join(',', posicoesNome);
		}
	}
}
