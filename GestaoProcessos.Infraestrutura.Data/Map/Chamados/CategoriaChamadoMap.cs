using GestaoProcessos.Dominio.Chamados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoProcessos.Infraestrutura.Data.Map.Chamados
{
    public class CategoriaChamadoMap : IEntityTypeConfiguration<CategoriaChamado>
    {
        public void Configure(EntityTypeBuilder<CategoriaChamado> builder)
        {
            builder.ToTable("cmd_categorias");
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
