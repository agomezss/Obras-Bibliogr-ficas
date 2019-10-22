using System;
using System.Collections.Generic;
using System.Text;

namespace Obras.Bibliograficas.Alessandro.Domain.Autores
{
	public interface IAutorNomeRegra
	{
		string Aplicar(string nome);
	}
}
