using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obras.Bibliograficas.Alessandro.Domain.Autores.Nome
{
	public class RegraOrdenacao : IAutorNomeRegra
	{
		public string Aplicar(string nome)
		{
			if (!nome.Contains(' ')) return nome;

			Stack<string> componentesNome = new Stack<string>(nome.Split(' '));

			if (componentesNome.Count == 1) return nome;

			var componenteFamiliar = VerificaExistenciaComponenteFamiliar(componentesNome.Peek());
			if (componenteFamiliar != null) componentesNome.Pop();

			var novoNome = new StringBuilder();
			novoNome.Append(componentesNome.Pop());

			if (componenteFamiliar != null)
				novoNome.Append($" {componenteFamiliar}");

			novoNome.Append(",");

			componentesNome = new Stack<string>(componentesNome);

			while (componentesNome.Count > 0)
				novoNome.Append($" {componentesNome.Pop()}");

			return novoNome.ToString();
		}

		private string VerificaExistenciaComponenteFamiliar(string componente)
		{
			List<string> componentesFamiliares = new List<string>()
			{
				"filho",
				"filha",
				"neto",
				"neta",
				"sobrinho",
				"sobrinha",
				"junior"
			};

			return componentesFamiliares.Contains(componente.ToLower()) ?
				   componente :
				   null;
		}
	}
}
