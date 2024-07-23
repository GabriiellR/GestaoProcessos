using GestaoProcessos.Dominio.Chamados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoProcessos.Infraestrutura.Data.Map.Chamados
{
    internal class FilaChamadoMap : IEntityTypeConfiguration<FilaChamado>
    {
        public void Configure(EntityTypeBuilder<FilaChamado> builder)
        {
            builder.ToTable("cmd_filas");
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
        }
    }
}
