using AutoMapper;
using GestaoProcesso.Aplicacao.Chamados;
using GestaoProcessos.Aplicacao.Interfaces.Chamados;
using GestaoProcessos.Dominio.Interfaces.Repository.Chamados;
using GestaoProcessos.Dominio.Interfaces.Service.Chamados;
using GestaoProcessos.Dominio.Servicos.Chamados;
using GestaoProcessos.Infraestrutura.Repository.Chamados;
using Microsoft.Extensions.DependencyInjection;

namespace GestaoProcessos.Infraestrutura.CrossCutting.IoC
{
    public static class Modules
    {

        public static void RegisterModules(this IServiceCollection service)
        {
            RegisterTransient(service);
            RegisterSingleton(service);
            RegisterScoped(service);
        }

        private static void RegisterScoped(IServiceCollection service)
        {
            service.AddScoped<IApplicationServiceChamado, ApplicationServiceChamado>();

            service.AddScoped<IServiceChamado, ServiceChamado>();

            service.AddScoped<IRepositoryChamado, RepositoryChamado>();

        }

        private static void RegisterSingleton(IServiceCollection service)
        {
        }

        private static void RegisterTransient(IServiceCollection service) { }
    }
}