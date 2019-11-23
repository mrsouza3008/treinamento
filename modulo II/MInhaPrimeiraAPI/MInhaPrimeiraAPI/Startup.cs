﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MInhaPrimeiraAPI.DAL;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Swagger;
using AutoMapper;

namespace MInhaPrimeiraAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSingleton<APIContext, Contexto>();

            services.AddDbContext<APIContext>(options =>
            options.UseInMemoryDatabase(databaseName: "ProdutosInMemory"));

            services.AddAutoMapper(typeof(Startup));
            services.AddTransient<IProdutoRepository, ProdutoRepository>();  // Quando pedir uma Interface passar uma Classe Concreta
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info {
                    Title = "Minha primeira API",
                    Version = "v1",
                    Description = "Documentacao da minha primeira API ASP.NET Core Web ",
                    TermsOfService = "https://example.com/terms",
                    Contact = new Contact
                    {
                        Name = "Marcelo Souza",
                        Email = string.Empty,
                        Url = "https://twitter.com/spboyer",
                    },
                    License = new License
                    {
                        Name = "Use under LICX",
                        Url = "https://example.com/license"
                    }

                });

                                
            });


        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Minha primeira API V1");
                c.RoutePrefix = "documentacao";
            });



            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
