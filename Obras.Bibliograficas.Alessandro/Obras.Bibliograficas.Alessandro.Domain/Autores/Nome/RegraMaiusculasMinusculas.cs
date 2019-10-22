using System.Collections.Generic;

namespace Obras.Bibliograficas.Alessandro.Domain.Autores.Nome
{
	public class RegraMaiusculasMinusculas : IAutorNomeRegra
	{
		List<string> preposicoes = new List<string>()
			{
				"das",
				"dos",
				"da",
				"de",
				"do"
			};

		public string Aplicar(string nome)
		{
			if (!nome.Contains(",")) return nome.ToUpper();

			var posicoesNome = nome.Split(',');
			posicoesNome[0] = posicoesNome[0].ToUpper();

			for (int i = 1; i < posicoesNome.Length && posicoesNome.Length > 1; i++)
			{
				if (preposicoes.Contains(posicoesNome[i]))
					continue;

				if (posicoesNome[i].Length <= 1)
				{
					posicoesNome[i] = posicoesNome[i].ToUpper();
					continue;
				}

				posicoesNome[i] = posicoesNome[i].Substring(0, 1).ToUpper() + posicoesNome[i].Substring(1).ToLower();
			}

			return string.Join(',', posicoesNome);
		}
	}
}
