using System;
using System.Collections.Generic;
using System.Text;

namespace Obras.Bibliograficas.Alessandro.Domain.Autores.Nome
{
	public class RegraMaiusculasMinusculas : IAutorNomeRegra
	{
		public string Aplicar(string nome)
		{
			return nome.ToUpper();
		}
	}
}
