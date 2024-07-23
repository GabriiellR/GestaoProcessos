using GestaoProcessos.Dominio.Chamados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoProcessos.Infraestrutura.Data.Map.Chamados
{
    public class SubfilaChamadoMap : IEntityTypeConfiguration<SubfilaChamado>
    {
        public void Configure(EntityTypeBuilder<SubfilaChamado> builder)
        {
            builder.ToTable("cmd_subfilas");
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
