using Obras.Bibliograficas.Alessandro.Domain;
using Obras.Bibliograficas.Alessandro.Domain.Autores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obras.Bibliograficas.Alessandro.Data.Repositories
{
	class AutorRepository : IAutorRepository
	{
		protected ObrasDbContext _context { get; set; }

		public AutorRepository(ObrasDbContext context)
		{
			_context = context;
		}
		public void AlterarAutor(Autor autor)
		{
			_context.Autores.Update(autor);
			_context.SaveChanges();
		}

		public void CadastrarAutor(Autor autor)
		{
			_context.Autores.Add(autor);
			_context.SaveChanges();
		}

		public IEnumerable<Autor> ListarAutores(Autor autor)
		{
			return _context.Autores.ToList();
		}

		public void RemoverAutor(Autor autor)
		{
			var obj = _context.Autores.FirstOrDefault(a => a.Id == autor.Id);
			_context.Autores.Remove(obj);
			_context.SaveChanges();
		}
	}
}
