using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MRS.Business.Interfaces;
using MRS.Business.Interfaces.Services;
using MRS.Business.Notificacoes;
using MRS.Business.Services;
using MRS.Data.Repository;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MRS.Api.Config
{
    public static class DependecyInjectionConfig
    {
        public static IServiceCollection AddDependecyInjectionConfig(this IServiceCollection services)
        {
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<INotificador, Notificador>();
            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

            return services;
        }


    }
}
