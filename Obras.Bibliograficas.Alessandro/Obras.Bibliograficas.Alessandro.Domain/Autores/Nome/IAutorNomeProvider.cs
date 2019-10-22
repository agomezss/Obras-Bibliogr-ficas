using System;
using System.Collections.Generic;
using System.Text;

namespace Obras.Bibliograficas.Alessandro.Domain.Autores
{
	public abstract class IAutorNomeProvider
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

		protected IAutorNomeProvider IncluirRegra(IAutorNomeRegra regra)
		{
			Regras.Add(regra);
			return this;
		}
	}
}
