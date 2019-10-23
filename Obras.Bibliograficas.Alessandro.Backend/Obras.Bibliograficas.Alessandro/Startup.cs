using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Obras.Bibliograficas.Alessandro.Data;
using Obras.Bibliograficas.Alessandro.Ioc;
using Swashbuckle.AspNetCore.Swagger;

namespace Obras.Bibliograficas.Alessandro
{
	public class Startup
	{
		public IConfiguration Configuration { get; }
		public IHostingEnvironment Hosting { get; protected set; }

		public Startup(IConfiguration configuration, IHostingEnvironment env)
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(env.ContentRootPath)
				.AddJsonFile("appsettings.json", true, true);

			builder.AddEnvironmentVariables();

			Configuration = builder.Build();
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<ObrasDbContext>(opt => opt.UseInMemoryDatabase("InMemoryDbInstance"));

			services.AddCors(options =>
			{
				options.AddPolicy("AllowAll",
					builder =>
					{
						builder
						.AllowAnyOrigin()
						.AllowAnyMethod()
						.AllowAnyHeader()
						.AllowCredentials();
					});
			});


			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

			services.AddSwaggerGen(s =>
			{
				s.SwaggerDoc("v1", new Info
				{
					Version = "v1",
					Title = "Obras Bibliográficas API - Alessandro",
					Description = "Obras Bibliográficas API Swagger surface - Alessandro",
					Contact = new Contact { Name = "Alessandro", Email = "a.gomezsimoes@outlook.com", Url = "https://www.linkedin.com/in/alessandro-gomez/" },
				});

				var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.XML";
				var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
				s.IncludeXmlComments(xmlPath);
			});

			RegisterServices(services);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseCors("AllowAll");

			app.UseMvc();

			app.UseSwagger();
			app.UseSwaggerUI(s =>
			{
				s.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1.0");
			});
		}

		private void RegisterServices(IServiceCollection services)
		{
			NativeInjectorBootStrapper.RegisterServices(services);
		}
	}
}
