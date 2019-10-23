using System.Collections.Generic;

namespace Obras.Bibliograficas.Alessandro.Domain.Autores
{
	public abstract class AutorNomeProvider
	{
		protected List<IAutorNomeRegra> Regras = new List<IAutorNomeRegra>();

		public string AplicarRegrasNome(string nome)
		{
			if (Regras == null) return nome;

			foreach (var regra in Regras)
			{
				nome = regra.Aplicar(nome);
			}

			return nome;
		}

		protected void IncluirRegra(IAutorNomeRegra regra)
		{
			Regras.Add(regra);
		}
	}
}
