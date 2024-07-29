using GestaoProcesso.Aplicacao.Administracao;
using GestaoProcesso.Aplicacao.Chamados;
using GestaoProcessos.Aplicacao.Interfaces.Administracao;
using GestaoProcessos.Aplicacao.Interfaces.Chamados;
using GestaoProcessos.Dominio.Interfaces.Repository.Administracao;
using GestaoProcessos.Dominio.Interfaces.Repository.Chamados;
using GestaoProcessos.Dominio.Interfaces.Service.Administracao;
using GestaoProcessos.Dominio.Interfaces.Service.Chamados;
using GestaoProcessos.Dominio.Servicos.Administracao;
using GestaoProcessos.Dominio.Servicos.Chamados;
using GestaoProcessos.Infraestrutura.Repository.Administracao;
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
            service.AddScoped<IApplicationServiceAuth, ApplicationServiceAuth>();
            service.AddScoped<IApplicationServicePassword, ApplicationServicePassword>();
            service.AddScoped<IApplicationServiceToken, ApplicationServiceToken>();
            service.AddScoped<IApplicationServiceParametros, ApplicationServiceParametros>();


            service.AddScoped<IApplicationServiceChamado, ApplicationServiceChamado>();
            service.AddScoped<IApplicationServiceUsuario, ApplicationServiceUsuario>();

            service.AddScoped<IServiceChamado, ServiceChamado>();
            service.AddScoped<IServiceUsuario, ServiceUsuario>();
            service.AddScoped<IServiceParametros, ServiceParametros>();

            service.AddScoped<IRepositoryChamado, RepositoryChamado>();
            service.AddScoped<IRepositoryUsuario, RepositoryUsuario>();
            service.AddScoped<IRepositoryParametros, RepositoryParametros>();

        }

        private static void RegisterSingleton(IServiceCollection service)
        {
        }

        private static void RegisterTransient(IServiceCollection service) { }
    }
}