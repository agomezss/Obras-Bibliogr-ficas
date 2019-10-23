using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Obras.Bibliograficas.Alessandro.Data;
using Obras.Bibliograficas.Alessandro.Ioc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Obras.Bibliograficas.Alessandro.Test.Fixture
{
	public class DependencyFixture
	{
		public DependencyFixture()
		{
			var serviceCollection = new ServiceCollection();

			serviceCollection.AddDbContext<ObrasDbContext>(options => options.UseInMemoryDatabase("InMemoryDbInstance"),
					ServiceLifetime.Transient);
		
			NativeInjectorBootStrapper.RegisterServices(serviceCollection);

			ServiceProvider = serviceCollection.BuildServiceProvider();
		}

		public ServiceProvider ServiceProvider { get; private set; }
	}
}
