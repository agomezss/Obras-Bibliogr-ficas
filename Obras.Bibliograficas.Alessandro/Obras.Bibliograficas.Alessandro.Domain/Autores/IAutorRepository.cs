using System;
using System.Collections.Generic;
using System.Text;

namespace Obras.Bibliograficas.Alessandro.Domain.Autores
{
	public interface IAutorRepository
	{
		List<Autor> Listar();
		void Cadastrar(Autor autor);
		void Alterar(Autor autor);
		Autor Buscar(Autor autor);
		void Remover(Autor autor);
	}
}
