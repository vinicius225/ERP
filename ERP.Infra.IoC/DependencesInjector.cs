using ERP.Aplication.Interfaces;
using ERP.Aplication.Services;
using ERP.Domain;
using ERP.Domain.Interfaces;
using ERP.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.Text;

namespace ERP.Infra.IoC
{
    public static class DependencesInjector
    {
        public static void ServicesInjector(this IServiceCollection services)
        {
            services.AddSingleton<IUsuarioServices, UsuarioServices>();
            services.AddSingleton<IAutenticacaoService, AutenticacaoService>();
            services.AddSingleton<ILogService, LogService>();
        }
        public static void RepositoryInjector(this IServiceCollection services)
        {
            services.AddSingleton<IUsuarioRepository, UsuarioRepository>();
            services.AddSingleton<ILogRepository, LogRepository>();
        }
        public static void DataBaseInjector(this IServiceCollection services)
        {
            services.AddSingleton<IConectionDB, ConectionDatabase>();
        }


    }
}