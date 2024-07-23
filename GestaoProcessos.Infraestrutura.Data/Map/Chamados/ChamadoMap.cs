using GestaoProcessos.Dominio.Chamados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoProcessos.Infraestrutura.Data.Map.Chamados
{
    public class ChamadoMap : IEntityTypeConfiguration<Chamado>
    {
        public void Configure(EntityTypeBuilder<Chamado> builder)
        {
            builder.ToTable("cmd_chamados");
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Id)
                   .HasColumnName("id")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(prop => prop.DataAbertura)
                   .HasColumnName("data_abertura")
                   .HasColumnType("datetime")
                   .HasDefaultValueSql("now()");

            builder.Property(prop => prop.DataAtendimento)
                   .HasColumnName("data_atendimento")
                   .HasColumnType("datetime")
                   .IsRequired(false);

            builder.Property(prop => prop.DataSolucao)
                   .HasColumnName("data_Solucao")
                   .HasColumnType("datetime")
                   .IsRequired(false);

            builder.Property(prop => prop.DataFechamento)
                   .HasColumnName("data_fechamento")
                   .HasColumnType("datetime")
                   .IsRequired(false);

            builder.Property(prop => prop.Titulo)
                   .HasColumnName("titulo")
                   .HasColumnType("varchar")
                   .HasMaxLength(150)
                   .IsRequired();

            builder.Property(prop => prop.Descricao)
                   .HasColumnName("descricao")
                   .HasColumnType("longtext")
                   .IsRequired();

            builder.Property(prop => prop.Solucao)
                   .HasColumnName("solucao")
                   .HasColumnType("longtext")
                   .IsRequired();

            builder.Property(prop => prop.TempoSolucao)
                   .HasColumnName("tempo_solucao")
                   .HasColumnType("time")
                   .IsRequired(false);

            builder.Property(prop => prop.TempoAtendimento)
                   .HasColumnName("tempo_atendimento")
                   .HasColumnType("time")
                   .IsRequired(false);

            builder.Property(prop => prop.StatusId)
                   .HasColumnName("status_id")
                   .HasColumnType("int")
                   .HasDefaultValue(1);

            builder.HasOne(prop => prop.Status)
                   .WithMany(prop => prop.Chamados)
                   .HasForeignKey(prop => prop.StatusId);

            builder.Property(prop => prop.UsuarioAberturaId)
                   .HasColumnName("usuario_abertura_id")
                   .HasColumnType("int")
                   .IsRequired();

            builder.HasOne(prop => prop.UsuarioAbertura)
                   .WithMany(prop => prop.ChamadosAbertura)
                   .HasForeignKey(prop => prop.UsuarioAberturaId);

            builder.Property(prop => prop.UsuarioSolucaoId)
                   .HasColumnName("usuario_solucao")
                   .HasColumnType("int")
                   .IsRequired(false);

            builder.HasOne(prop => prop.UsuarioSolucao)
                  .WithMany(prop => prop.ChamadosSolucao)
                  .HasForeignKey(prop => prop.UsuarioSolucaoId);

            builder.Property(prop => prop.FilaId)
                   .HasColumnName("fila_id")
                   .HasColumnType("int")
                   .IsRequired();

            builder.HasOne(prop => prop.Fila)
                   .WithMany(prop => prop.Chamados)
                   .HasForeignKey(prop => prop.FilaId);

            builder.Property(prop => prop.CategoriaId)
                   .HasColumnName("categoria_id")
                   .HasColumnType("int")
                   .IsRequired();

            builder.HasOne(prop => prop.Categoria)
                   .WithMany(prop => prop.Chamados)
                   .HasForeignKey(prop => prop.CategoriaId);

            builder.Property(prop => prop.SubfilaId)
                   .HasColumnName("subfila_id")
                   .HasColumnType("int")
                   .IsRequired(false);

            builder.HasOne(prop => prop.Subfila)
                   .WithMany(prop => prop.Chamados)
                   .HasForeignKey(prop => prop.SubfilaId);
        }
    }
}
