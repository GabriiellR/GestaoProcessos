using GestaoProcessos.Dominio.Administracao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoProcessos.Infraestrutura.Data.Map.Administracao
{
    public class FilialMap : IEntityTypeConfiguration<Filial>
    {
        public void Configure(EntityTypeBuilder<Filial> builder)
        {
            builder.ToTable("filial");
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Id)
                   .HasColumnName("id")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(prop => prop.Nome)
                   .HasColumnName("nome")
                   .HasColumnType("varchar")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(prop => prop.Logradouro)
                   .HasColumnName("logradouro")
                   .HasColumnType("varchar")
                   .HasMaxLength(400)
                   .IsRequired();

            builder.Property(prop => prop.Bairro)
                   .HasColumnName("bairro")
                   .HasColumnType("varchar")
                   .HasMaxLength(150)
                   .IsRequired();

            builder.Property(prop => prop.Localidade)
                   .HasColumnName("localidade")
                   .HasColumnType("varchar")
                   .HasMaxLength(150)
                   .IsRequired();

            builder.Property(prop => prop.UF)
                   .HasColumnName("UF")
                   .HasColumnType("varchar")
                   .HasMaxLength(2)
                   .IsRequired();

            builder.Property(prop => prop.Numero)
                   .HasColumnName("numero")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(prop => prop.Telefone)
                   .HasColumnName("telefone")
                   .HasColumnType("varchar")
                   .HasMaxLength(13)
                   .IsRequired();
        }
    }
}
