using Microsoft.Extensions.DependencyInjection;
using Obras.Bibliograficas.Alessandro.Data;
using Obras.Bibliograficas.Alessandro.Data.Repositories;
using Obras.Bibliograficas.Alessandro.Domain.Autores;
using Obras.Bibliograficas.Alessandro.Domain.Autores.Nome;
using Obras.Bibliograficas.Alessandro.Service;

namespace Obras.Bibliograficas.Alessandro.Ioc
{
	/// <summary>
	/// Injeção de dependencia.
	/// </summary>
	public class NativeInjectorBootStrapper
	{
		public static void RegisterServices(IServiceCollection services)
		{
			// Application
			services.AddScoped<IAutorService, AutorService>();
			services.AddScoped<IAutorRepository, AutorRepository>();

			// Rule providers - Regras de nome de autores (Atua mais ou menos como um feature flag)
			services.AddScoped<IAutorNomeProvider, AutorNomeProviderPadrao>();

			// Infra - Data
			services.AddScoped<ObrasDbContext>();
		}
	}
}
