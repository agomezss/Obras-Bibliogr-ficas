﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Obras.Bibliograficas.Alessandro.Data;
using Swashbuckle.AspNetCore.Swagger;

namespace Obras.Bibliograficas.Alessandro
{
	public class Startup
	{
		public IHostingEnvironment Hosting { get; protected set; }

		public Startup(IConfiguration configuration, IHostingEnvironment env)
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(env.ContentRootPath)
				.AddJsonFile("appsettings.json", true, true);

			builder.AddEnvironmentVariables();

			Configuration = builder.Build();
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			var connectionString = Configuration.GetConnectionString("DefaultConnection");

			//services.AddDbContext<ObrasDbContext>(cfg =>
			//{
			//	//cfg.Use
			//});


			services.AddCors(options =>
			{
				options.AddPolicy("AllowAllHeadersAndMethods",
					builder =>
					{
						builder
						//.AllowAnyOrigin()
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
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseCors("AllowAllHeadersAndMethods");

			app.UseMvc();

			app.UseSwagger();
			app.UseSwaggerUI(s =>
			{
				s.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1.0");
			});
		}
	}
}
