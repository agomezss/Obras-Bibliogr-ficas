using System;
using System.Collections.Generic;
using System.Text;

namespace Obras.Bibliograficas.Alessandro.Domain.Autores
{
	public interface IAutorService
	{
		List<Autor> Listar();
		Autor Cadastrar(Autor autor);
		Autor Alterar(Autor autor);
		Autor Buscar(Autor autor);
		void Remover(Autor autor);
	}
}
