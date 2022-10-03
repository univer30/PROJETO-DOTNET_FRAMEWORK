
using Loja.Application.Interfaces;
using Loja.Application.Services;
using Loja.Domain.Interfaces;
using Loja.Infra.Data.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;


namespace Loja.Infra.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration consfiguration)
        {

            //Loja.Application
           services.AddScoped<ILojaMariliaService, LojaMariliaService>();
           services.AddScoped<IProdutoService, ProdutoService>();


           //Loja.Domain.Interfaces | Loja.Infra.Data.Repository

           services.AddScoped<ILojaMariliaRepository, LojaMariliaRepository>();
           services.AddScoped<IProdutoRepository, ProdutoRepository>();
           return services;
        }  
    }
}