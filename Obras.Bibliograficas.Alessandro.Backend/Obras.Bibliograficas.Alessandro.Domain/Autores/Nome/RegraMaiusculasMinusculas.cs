using System.Collections.Generic;
using System.Text;

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

			var componentesNome = nome.Split(',');
			componentesNome[0] = componentesNome[0].ToUpper();

			var componentesSecundarios = componentesNome[1].Split(' ');

			for (int i = 0; i < componentesSecundarios.Length && componentesSecundarios.Length > 1; i++)
			{
				if (preposicoes.Contains(componentesSecundarios[i]))
					continue;

				if (componentesSecundarios[i].Length <= 1)
				{
					componentesSecundarios[i] = componentesSecundarios[i].ToUpper();
					continue;
				}

				componentesSecundarios[i] = componentesSecundarios[i].Substring(0, 1).ToUpper() + 
											componentesSecundarios[i].Substring(1).ToLower();
			}

			var novoNome = new StringBuilder();
			novoNome.Append(componentesNome[0]);
			novoNome.Append(",");
			novoNome.Append(string.Join(' ', componentesSecundarios));

			return novoNome.ToString();
		}
	}
}
