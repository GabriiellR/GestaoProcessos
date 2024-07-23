﻿using GestaoProcessos.Dominio.Administracao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoProcessos.Infraestrutura.Data.Map.Administracao
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuarios");
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Id)
                   .HasColumnName("id")
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(prop => prop.Nome)
                   .HasColumnName("nome")
                   .HasColumnType("varchar")
                   .HasMaxLength(255)
                   .IsRequired();

            builder.Property(prop => prop.Email)
                   .HasColumnName("email")
                   .HasColumnType("varchar")
                   .HasMaxLength(255)
                   .IsRequired();

            builder.Property(prop => prop.Login)
                   .HasColumnName("login")
                   .HasColumnType("varchar")
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(prop => prop.DataNascimento)
                   .HasColumnType("date")
                   .HasDefaultValueSql("CURDATE()");

            builder.Property(prop => prop.Status)
                   .HasColumnName("status")
                   .HasColumnType("tinyint")
                   .IsRequired();

            builder.Property(prop => prop.SetorId)
                   .HasColumnName("setor_id")
                   .HasColumnType("int")
                   .IsRequired();

            builder.HasOne(prop => prop.Setor)
                   .WithMany(prop => prop.Usuarios)
                   .HasForeignKey(prop => prop.SetorId);

            builder.Property(prop => prop.FilialId)
                   .HasColumnName("filial_id")
                   .HasColumnType("int")
                   .IsRequired();

            builder.HasOne(prop => prop.Filial)
                   .WithMany(prop => prop.Usuarios)
                   .HasForeignKey(prop => prop.FilialId);

            builder.Property(prop => prop.EmpresaId)
                   .HasColumnName("empresa_id")
                   .HasColumnType("int")
                   .IsRequired();

            builder.HasOne(prop => prop.Empresa)
                   .WithMany(prop => prop.Usuarios)
                   .HasForeignKey(prop => prop.EmpresaId);
        }
    }
}