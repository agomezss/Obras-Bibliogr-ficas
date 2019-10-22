using System;
using System.Collections.Generic;
using System.Linq;

namespace Obras.Bibliograficas.Alessandro.Domain.Autores.Nome
{
	public class RegraOrdenacaoPronomeTratamento : IAutorNomeRegra
	{
		public string Aplicar(string nome)
		{
			return nome;
		}
	}
}
