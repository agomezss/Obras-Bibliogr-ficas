using Obras.Bibliograficas.Alessandro.Domain;
using Obras.Bibliograficas.Alessandro.Domain.Autores;
using System;
using System.Collections.Generic;

namespace Obras.Bibliograficas.Alessandro.Service
{
	public class AutorService : IAutorService
	{
		protected IAutorRepository _repo { get; set; }

		public AutorService(IAutorRepository repository)
		{
			_repo = repository;
		}

		public void AlterarAutor(Autor autor)
		{
			_repo.AlterarAutor(autor);
		}

		public void CadastrarAutor(Autor autor)
		{
			_repo.CadastrarAutor(autor);
		}

		public IEnumerable<Autor> ListarAutores(Autor autor)
		{
			return _repo.ListarAutores(autor);
		}

		public void RemoverAutor(Autor autor)
		{
			_repo.RemoverAutor(autor);
		}
	}
}
