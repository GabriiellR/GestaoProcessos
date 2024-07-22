using GestaoProcessos.Infraesrtutura.CrossCutting.Adaptadores.Profiles.Administracao;
using GestaoProcessos.Infraestrutura.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace GestaoProcesso.Aprensentacao.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureControllers(this IServiceCollection services)
        {
            services.AddControllers()
                    .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
        }

        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(p => p.AddPolicy("corsapp", builder =>
            {
                builder.WithOrigins("*")
                       .AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));
        }

        public static void ConfigureAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(config => config.AddMaps(typeof(UsuarioProfile).Assembly));
        }

        public static void ConfigureDatabase(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<MysqlContext>(p => p.UseMySql(connectionString,
                                                                ServerVersion.AutoDetect(connectionString),
                                                    assembly => assembly.MigrationsAssembly(typeof(MysqlContext).Assembly.FullName)));
        }
    }
}
