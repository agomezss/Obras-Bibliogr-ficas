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

		public void Alterar(Autor autor)
		{
			_repo.Alterar(autor);
		}

		public void Cadastrar(Autor autor)
		{
			_repo.Cadastrar(autor);
		}

		public Autor Buscar(Autor autor)
		{
			return _repo.Buscar(autor);
		}

		public List<Autor> Listar()
		{
			return _repo.Listar();
		}

		public void Remover(Autor autor)
		{
			_repo.Remover(autor);
		}
	}
}
