using GestaoProcessos.Dominio.Administracao;
using GestaoProcessos.Dominio.Chamados;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GestaoProcessos.Infraestrutura.Data
{
    public class MysqlContext : DbContext
    {
        public MysqlContext(DbContextOptions<MysqlContext> options) : base(options) { }
        public MysqlContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var configuration = new ConfigurationBuilder()
                                  .SetBasePath(Directory.GetCurrentDirectory())
                                  .AddJsonFile("appsettings.json")
                                  .Build();

            var connectionString = configuration.GetConnectionString("mysql");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Filial> Filiais { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<Chamado> Chamados { get; set; }
        public DbSet<FilaChamado> FilaChamado { get; set; }
        public DbSet<SubfilaChamado> Subfila { get; set; }
        public DbSet<CategoriaChamado> CategoriaChamado { get; set; }
        public DbSet<Parametros> Parametros { get; set; }
    }
}