using GestaoProcessos.Dominio.Administracao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoProcessos.Infraestrutura.Data.Map.Administracao
{
    public class EmpresaMap : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("adm_empresa");
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
