using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
//using Microsoft.AspNetCore.Hosting;
using System.IO;
using Obras.Bibliograficas.Alessandro.Domain;

namespace Obras.Bibliograficas.Alessandro.Data
{
	public class ObrasDbContext : DbContext
	{
		//private readonly IHostingEnvironment _env;
		private IDbContextTransaction _transaction;
		private bool IsTesting;

		//public ObrasDbContext(IHostingEnvironment env) : base()
		//{
		//	_env = env;
		//}

		public ObrasDbContext() : base()
		{
		}

		/// <summary>
		/// Construtor para testes.
		/// </summary>
		/// <param name="options">Opções</param>
		public ObrasDbContext(DbContextOptions<ObrasDbContext> options)
	   : base(options)
		{ }

		public DbSet<Autor> Autores { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			base.OnModelCreating(modelBuilder);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseInMemoryDatabase("InMemoryDbInstance");
				//.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFProviders.InMemory;Trusted_Connection=True;ConnectRetryCount=0");
			
		}

		public void Commit()
		{
			if (IsTesting)
			{
				_transaction?.Rollback();
				return;
			}

			_transaction?.Commit();

			_transaction = null;

			SaveChanges();
		}

		public void BeginTransaction()
		{
			_transaction = _transaction ?? Database.BeginTransaction();
		}

		public void Rollback()
		{
			_transaction?.Rollback();
		}

		public void SetTestMode()
		{
			IsTesting = true;
		}
	}
}
