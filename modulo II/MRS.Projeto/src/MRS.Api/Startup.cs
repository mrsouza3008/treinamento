using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

using HealthChecks.UI.Client;
using KissLog;
using KissLog.Apis.v1.Listeners;
using KissLog.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MRS.Api.Config;
using MRS.Api.Extensions;
using MRS.Business.Interfaces;
using MRS.Business.Notificacoes;
using MRS.Data.Context;
using MRS.Data.Repository;
using Swashbuckle.AspNetCore.Swagger;


namespace MRS.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApiContext>( Options => {
                Options.UseSqlServer(Configuration.GetConnectionString("sql"));
            });

            //  services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //  services.AddScoped<KissLog.ILogger>((context) =>
            //  {
            //      return KissLog.Logger.Factory.Get();
            // });

            services.AddApiVersioning(options =>
            {
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
                options.ReportApiVersions = true; // API Headers
            });


            services.AddAutoMapper(typeof(Startup));
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });

            //DI  - Dependency Injection  - Pasta MRS.API - Pasta CONFIG 
            services.AddDependecyInjectionConfig();

            //DI - Api Config - Pasta MRS.API - Pasta CONFIG
            services.AddApiConfig();

            services.AddVersionedApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true; //  Se não colocar versao, é adicionado versao padrao
            });


            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddXmlDataContractSerializerFormatters()    //   Para exibir em formato XML e nao JSON - tem que passar no cabecalho  (application/xml)
                .AddJsonOptions(opcoes =>  
                {
                    opcoes.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore; // remove valores nulos do JSON na resposta
                });

            services.AddSwaggerConfig();  // Documentacao - Esta no CONFIG SwaggerConfig

            services.AddResponseCaching();

            services.AddResponseCompression(opt =>
            {
                opt.Providers.Add<BrotliCompressionProvider>();
                opt.EnableForHttps = true;
                
            });

            services.AddHealthChecks()
                .AddSqlServer(Configuration.GetConnectionString("sql"), name: "Banco SQL")
                .AddCheck("Fornecedores", new SqlServerHealthCheck(Configuration.GetConnectionString("sql")));
                

            services.AddHealthChecksUI();
            

           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>.
        public void Configure
            (
                IApplicationBuilder app, 
                IHostingEnvironment env,
                ILoggerFactory loggerFactory,
                IApiVersionDescriptionProvider provider

            )
        {
            loggerFactory.AddFile("log/MRS-{Date}.txt", Microsoft.Extensions.Logging.LogLevel.Error);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseKissLogMiddleware(options => {
                options.Listeners.Add(new KissLogApiListener(new KissLog.Apis.v1.Auth.Application(
                    Configuration["KissLog.OrganizationId"],
                    Configuration["KissLog.ApplicationId"])
                ));
            });

            app.UseHttpsRedirection();

            app.UseSwaggerConfig(provider);  // Documentacao - Esta no CONFIG SwaggerConfig

            app.UseResponseCaching();  // Para colocar em Cache

            app.UseResponseCompression();  // para compressao

            app.UseHealthChecks("/api/hc" , new HealthCheckOptions
               {
                    Predicate = _ => true,
                    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
                    
               });    // Verificar status da API

            // /healthchecks-ui //  Para verificar Status do Banco - Necessario instalar Packages
            app.UseHealthChecksUI();  

      

            app.UseMvc();  // --------------------->>>>  Deixar o UseMvc sempre no final


            
        }
    }
}
