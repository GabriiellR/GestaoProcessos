using GestaoProcessos.Dominio.Chamados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoProcessos.Infraestrutura.Data.Map.Chamados
{
    public class FilaUsuarioMap : IEntityTypeConfiguration<FilaUsuario>
    {
        public void Configure(EntityTypeBuilder<FilaUsuario> builder)
        {
            builder.ToTable("cmd_filasusuarios");
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Id)
                   .HasColumnName("id")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(prop => prop.FilaId)
                   .HasColumnName("fila_id")
                   .HasColumnType("int")
                   .IsRequired();

            builder.HasOne(prop => prop.Usuario)
                   .WithMany(prop => prop.FilasUsuarios)
                   .HasForeignKey(prop => prop.UsuarioId);

            builder.Property(prop => prop.UsuarioId)
                   .HasColumnName("usuario_id")
                   .HasColumnType("int")
                   .IsRequired();

            builder.HasOne(prop => prop.Fila)
                   .WithMany(prop => prop.FilasUsuarios)
                   .HasForeignKey(prop => prop.FilaId);
        }
    }
}
