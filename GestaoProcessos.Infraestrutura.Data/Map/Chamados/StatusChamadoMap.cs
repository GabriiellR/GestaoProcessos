using GestaoProcessos.Dominio.Chamados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoProcessos.Infraestrutura.Data.Map.Chamados
{
    public class StatusChamadoMap : IEntityTypeConfiguration<StatusChamado>
    {
        public void Configure(EntityTypeBuilder<StatusChamado> builder)
        {
            builder.ToTable("cmd_statuschamado");
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Id)
                   .HasColumnName("id")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(prop => prop.Nome)
                   .HasColumnName("nome")
                   .HasColumnType("varchar")
                   .HasMaxLength(150)
                   .IsRequired();

            builder.HasData(
                                new StatusChamado { Id = 1, Nome = "Novo" },
                                new StatusChamado { Id = 2, Nome = "Em Atendimento" },
                                new StatusChamado { Id = 3, Nome = "Pendente" },
                                new StatusChamado { Id = 4, Nome = "Solucionado" },
                                new StatusChamado { Id = 5, Nome = "Encerrado" }
                            );
        }
    }
}
