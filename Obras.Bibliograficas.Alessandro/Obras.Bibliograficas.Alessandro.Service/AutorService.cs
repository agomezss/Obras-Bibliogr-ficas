using Obras.Bibliograficas.Alessandro.Domain;
using Obras.Bibliograficas.Alessandro.Domain.Autores;
using System.Collections.Generic;

namespace Obras.Bibliograficas.Alessandro.Service
{
	public class AutorService : IAutorService
	{
		protected IAutorRepository _repo { get; set; }
		IAutorNomeProvider _provedorNomeAutoral;

		public AutorService(IAutorRepository repository, IAutorNomeProvider provedorNomeAutoral)
		{
			_repo = repository;
			_provedorNomeAutoral = provedorNomeAutoral;
		}

		public Autor Alterar(Autor autor)
		{
			autor.FormatarNome(_provedorNomeAutoral);
			return _repo.Alterar(autor);
		}

		public Autor Cadastrar(Autor autor)
		{
			autor.FormatarNome(_provedorNomeAutoral);
			return _repo.Cadastrar(autor);
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
