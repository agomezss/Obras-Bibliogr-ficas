using Microsoft.Extensions.DependencyInjection;
using Obras.Bibliograficas.Alessandro.Data;
using Obras.Bibliograficas.Alessandro.Domain.Autores;
using Obras.Bibliograficas.Alessandro.Test.Fixture;
using System;
using System.Linq;
using Xunit;

namespace Obras.Bibliograficas.Alessandro.Test
{
	public class AutorServiceIntegrationTest : IClassFixture<DependencyFixture>, IDisposable
	{
		private ServiceProvider _serviceProvider;
		private IAutorService _service;
		private ObrasDbContext _context;

		public AutorServiceIntegrationTest(DependencyFixture fixture)
		{
			_serviceProvider = fixture.ServiceProvider;
			_service = _serviceProvider.GetService<IAutorService>();

			var db = _serviceProvider.GetService<ObrasDbContext>();
			db.SetTestMode();

			_context = db;
		}

		[Fact]
		public void TestListar()
		{
			// Arrange
			_service.Cadastrar(new Domain.Autor()
			{
				Nome = "Alessandro Gomez"
			});

			// Act
			var result = _service.Listar();

			// Assert
			Assert.True(result != null);
			Assert.True(result.Count > 0);
		}

		[Fact]
		public void TestBuscar()
		{
			// Arrange
			var existentes = _service.Listar().Where(a => a.Nome == "Alessandro Gomez");

			foreach (var item in existentes)
			{
				_service.Remover(new Domain.Autor() { Id = item.Id });
			}

			_service.Cadastrar(new Domain.Autor()
			{
				Nome = "Alessandro Gomez"
			});


			var criado = _service.Listar().Where(a => a.Nome == "Alessandro Gomez").FirstOrDefault();

			// Act
			var result = _service.Buscar(new Domain.Autor() { Id = criado.Id });

			// Assert
			Assert.True(result != null);
			Assert.True(result.Id == criado.Id);

		}

		[Fact]
		public void TestInserir()
		{
			// Arrange
			var existentes = _service.Listar().Where(a => a.Nome == "Alessandro Gomez");

			foreach (var item in existentes)
			{
				_service.Remover(new Domain.Autor() { Id = item.Id });
			}

			// Act
			_service.Cadastrar(new Domain.Autor()
			{
				Nome = "Alessandro Gomez"
			});

			var criado = _service.Listar().Where(a => a.Nome == "Alessandro Gomez").FirstOrDefault();

			var result = _service.Buscar(new Domain.Autor() { Id = criado.Id });

			// Assert
			Assert.True(result != null);
			Assert.True(result.Id == criado.Id);
		}

		[Fact]
		public void TestAtualizar()
		{
			// Arrange
			var existentes = _service.Listar().Where(a => a.Nome == "Alessandro Gomez");

			foreach (var item in existentes)
			{
				_service.Remover(new Domain.Autor() { Id = item.Id });
			}

			_service.Cadastrar(new Domain.Autor()
			{
				Nome = "Alessandro Gomez"
			});

			var criado = _service.Listar().Where(a => a.Nome == "Alessandro Gomez").FirstOrDefault();

			// Act
			criado.Nome = "joão gomez";
			_service.Alterar(criado);
			var result = _service.Buscar(new Domain.Autor() { Id = criado.Id });

			// Assert
			Assert.True(result != null);
			Assert.True(result.Nome == "joão gomez");
		}

		[Fact]
		public void TestExcluir()
		{
			// Arrange
			var existentes = _service.Listar().Where(a => a.Nome == "Alessandro Gomez");

			foreach (var item in existentes)
			{
				_service.Remover(new Domain.Autor() { Id = item.Id });
			}

			_service.Cadastrar(new Domain.Autor()
			{
				Nome = "Alessandro Gomez"
			});

			var criado = _service.Listar().Where(a => a.Nome == "Alessandro Gomez").FirstOrDefault();

			// Act
			_service.Remover(new Domain.Autor() { Id = criado.Id });
			var result = _service.Buscar(new Domain.Autor() { Id = criado.Id });

			// Assert
			Assert.True(result == null);
		}

		public void Dispose()
		{
			try
			{
				_context.Rollback();
			}
			catch
			{
			}
		}
	}
}
