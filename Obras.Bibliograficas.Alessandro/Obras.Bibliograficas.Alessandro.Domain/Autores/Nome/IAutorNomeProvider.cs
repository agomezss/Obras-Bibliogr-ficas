using System;
using System.Collections.Generic;
using System.Text;

namespace Obras.Bibliograficas.Alessandro.Domain.Autores
{
	public abstract class IAutorNomeProvider
	{
		protected List<IAutorNomeRegra> Regras { get; set; }

		public  string AplicarRegrasNome(string nome)
		{
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
