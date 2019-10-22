using System;
using System.Collections.Generic;
using System.Text;

namespace Obras.Bibliograficas.Alessandro.Domain.Autores
{
	public interface IAutorRepository
	{
		IEnumerable<Autor> ListarAutores(Autor autor);
		void CadastrarAutor(Autor autor);
		void AlterarAutor(Autor autor);
		void RemoverAutor(Autor autor);
	}
}
