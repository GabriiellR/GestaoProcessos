using GestaoProcessos.Dominio.Administracao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoProcessos.Infraestrutura.Data.Map.Administracao
{
    public class ParametrosMap : IEntityTypeConfiguration<Parametros>
    {
        public void Configure(EntityTypeBuilder<Parametros> builder)
        {
            builder.ToTable("adm_parametros");
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Id)
                   .HasColumnName("id")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(prop => prop.NomeSistema)
                   .HasColumnName("nome_sistema")
                   .HasColumnType("varchar")
                   .HasMaxLength(80)
                   .IsRequired();

            builder.Property(prop => prop.Segredo)
                   .HasColumnName("segredo")
                   .HasColumnType("longtext")
                   .IsRequired();

            builder.Property(prop => prop.DiretorioRaizArquivo)
                   .HasColumnName("diretorio_raiz_arquivos")
                   .HasColumnType("varchar")
                   .HasMaxLength(400)
                   .IsRequired();

            builder.Property(prop => prop.ExtensoesAceitas)
                   .HasColumnName("extensoes_aceitas")
                   .HasColumnType("varchar")
                   .HasMaxLength(400)
                   .IsRequired();

            builder.Property(prop => prop.TamanhoMaximoArquivo)
                   .HasColumnName("tamanho_maximo_arquivo")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(prop => prop.EmpresaId)
                   .HasColumnName("empresa_id")
                   .HasColumnType("int")
                   .IsRequired();

            builder.HasOne(prop => prop.Empresa)
                   .WithOne(prop => prop.Parametro)
                   .HasForeignKey<Parametros>(prop => prop.EmpresaId);
        }
    }
}
