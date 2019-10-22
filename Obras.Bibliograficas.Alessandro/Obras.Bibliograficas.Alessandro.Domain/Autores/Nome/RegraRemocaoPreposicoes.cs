using System;
using System.Collections.Generic;
using System.Linq;

namespace Obras.Bibliograficas.Alessandro.Domain.Autores.Nome
{
	public class RegraRemocaoPreposicoes : IAutorNomeRegra
	{
		public string Aplicar(string nome)
		{
			List<string> preposicoes = new List<string>()
			{
				"das",
				"dos",
				"da",
				"de",
				"do"
			};

			var componentes = nome.ToLower().Split(' ');
			var componentesFiltrados = componentes.Where(a=>!preposicoes.Contains(a));
			return string.Join(' ', componentesFiltrados);

		}
	}
}
