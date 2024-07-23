using GestaoProcessos.Dominio.Administracao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoProcessos.Infraestrutura.Data.Map.Administracao
{
    public class FuncaoMap : IEntityTypeConfiguration<Funcao>
    {
        public void Configure(EntityTypeBuilder<Funcao> builder)
        {
            builder.ToTable("adm_funcao");
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
