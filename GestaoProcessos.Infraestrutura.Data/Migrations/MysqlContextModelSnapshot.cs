﻿// <auto-generated />
using System;
using GestaoProcessos.Infraestrutura.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestaoProcessos.Infraestrutura.Data.Migrations
{
    [DbContext(typeof(MysqlContext))]
    partial class MysqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GestaoProcessos.Dominio.Administracao.Empresa", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("empresa", (string)null);
                });

            modelBuilder.Entity("GestaoProcessos.Dominio.Administracao.Filial", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar")
                        .HasColumnName("bairro");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Localidade")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar")
                        .HasColumnName("localidade");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("varchar")
                        .HasColumnName("logradouro");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("nome");

                    b.Property<int>("Numero")
                        .HasColumnType("int")
                        .HasColumnName("numero");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("varchar")
                        .HasColumnName("telefone");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar")
                        .HasColumnName("UF");

                    b.HasKey("Id");

                    b.ToTable("filial", (string)null);
                });

            modelBuilder.Entity("GestaoProcessos.Dominio.Administracao.Funcao", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("funcao", (string)null);
                });

            modelBuilder.Entity("GestaoProcessos.Dominio.Administracao.Setor", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("setor", (string)null);
                });

            modelBuilder.Entity("GestaoProcessos.Dominio.Administracao.Usuario", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateOnly>("DataNascimento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValueSql("CURDATE()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar")
                        .HasColumnName("email");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int")
                        .HasColumnName("empresa_id");

                    b.Property<int>("FilialId")
                        .HasColumnType("int")
                        .HasColumnName("filial_id");

                    b.Property<int>("FuncaoId")
                        .HasColumnType("int");

                    b.Property<int>("GestorId")
                        .HasColumnType("int");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("login");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar")
                        .HasColumnName("nome");

                    b.Property<int>("SetorId")
                        .HasColumnType("int")
                        .HasColumnName("setor_id");

                    b.Property<sbyte>("Status")
                        .HasColumnType("tinyint")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("FilialId");

                    b.HasIndex("FuncaoId");

                    b.HasIndex("GestorId");

                    b.HasIndex("SetorId");

                    b.ToTable("usuarios", (string)null);
                });

            modelBuilder.Entity("GestaoProcessos.Dominio.Chamados.CategoriaChamado", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("cmd_cateforias", (string)null);
                });

            modelBuilder.Entity("GestaoProcessos.Dominio.Chamados.Chamado", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int")
                        .HasColumnName("categoria_id");

                    b.Property<DateTime>("DataAbertura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("data_abertura")
                        .HasDefaultValueSql("now()");

                    b.Property<DateTime?>("DataAtendimento")
                        .HasColumnType("datetime")
                        .HasColumnName("data_atendimento");

                    b.Property<DateTime?>("DataFechamento")
                        .HasColumnType("datetime")
                        .HasColumnName("data_fechamento");

                    b.Property<DateTime?>("DataSolucao")
                        .HasColumnType("datetime")
                        .HasColumnName("data_Solucao");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("descricao");

                    b.Property<int>("FilaId")
                        .HasColumnType("int")
                        .HasColumnName("fila_id");

                    b.Property<string>("Solucao")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("solucao");

                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1)
                        .HasColumnName("status_id");

                    b.Property<int?>("SubfilaId")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("subfila_id");

                    b.Property<TimeSpan?>("TempoAtendimento")
                        .HasColumnType("time")
                        .HasColumnName("tempo_atendimento");

                    b.Property<TimeSpan?>("TempoSolucao")
                        .HasColumnType("time")
                        .HasColumnName("tempo_solucao");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar")
                        .HasColumnName("titulo");

                    b.Property<int>("UsuarioAberturaId")
                        .HasColumnType("int")
                        .HasColumnName("usuario_abertura_id");

                    b.Property<int?>("UsuarioSolucaoId")
                        .HasColumnType("int")
                        .HasColumnName("usuario_solucao");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("FilaId");

                    b.HasIndex("StatusId");

                    b.HasIndex("SubfilaId");

                    b.HasIndex("UsuarioAberturaId");

                    b.HasIndex("UsuarioSolucaoId");

                    b.ToTable("cmd_chamados", (string)null);
                });

            modelBuilder.Entity("GestaoProcessos.Dominio.Chamados.FilaChamado", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("cmd_filas", (string)null);
                });

            modelBuilder.Entity("GestaoProcessos.Dominio.Chamados.FilaUsuario", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("FilaId")
                        .HasColumnType("int")
                        .HasColumnName("fila_id");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int")
                        .HasColumnName("usuario_id");

                    b.HasKey("Id");

                    b.HasIndex("FilaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("cmd_filasusuarios", (string)null);
                });

            modelBuilder.Entity("GestaoProcessos.Dominio.Chamados.StatusChamado", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("cmd_statuschamado", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Novo"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Em Atendimento"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Pendente"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Solucionado"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Encerrado"
                        });
                });

            modelBuilder.Entity("GestaoProcessos.Dominio.Chamados.SubfilaChamado", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("cmd_subfilas", (string)null);
                });

            modelBuilder.Entity("GestaoProcessos.Dominio.Administracao.Usuario", b =>
                {
                    b.HasOne("GestaoProcessos.Dominio.Administracao.Empresa", "Empresa")
                        .WithMany("Usuarios")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestaoProcessos.Dominio.Administracao.Filial", "Filial")
                        .WithMany("Usuarios")
                        .HasForeignKey("FilialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestaoProcessos.Dominio.Administracao.Funcao", "Funcao")
                        .WithMany("Usuarios")
                        .HasForeignKey("FuncaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestaoProcessos.Dominio.Administracao.Usuario", "Gestor")
                        .WithMany("UsuariosSubordinados")
                        .HasForeignKey("GestorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestaoProcessos.Dominio.Administracao.Setor", "Setor")
                        .WithMany("Usuarios")
                        .HasForeignKey("SetorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");

                    b.Navigation("Filial");

                    b.Navigation("Funcao");

                    b.Navigation("Gestor");

                    b.Navigation("Setor");
                });

            modelBuilder.Entity("GestaoProcessos.Dominio.Chamados.Chamado", b =>
                {
                    b.HasOne("GestaoProcessos.Dominio.Chamados.CategoriaChamado", "Categoria")
                        .WithMany("Chamados")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestaoProcessos.Dominio.Chamados.FilaChamado", "Fila")
                        .WithMany("Chamados")
                        .HasForeignKey("FilaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestaoProcessos.Dominio.Chamados.StatusChamado", "Status")
                        .WithMany("Chamados")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestaoProcessos.Dominio.Chamados.SubfilaChamado", "Subfila")
                        .WithMany("Chamados")
                        .HasForeignKey("SubfilaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestaoProcessos.Dominio.Administracao.Usuario", "UsuarioAbertura")
                        .WithMany("ChamadosAbertura")
                        .HasForeignKey("UsuarioAberturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestaoProcessos.Dominio.Administracao.Usuario", "UsuarioSolucao")
                        .WithMany("ChamadosSolucao")
                        .HasForeignKey("UsuarioSolucaoId");

                    b.Navigation("Categoria");

                    b.Navigation("Fila");

                    b.Navigation("Status");

                    b.Navigation("Subfila");

                    b.Navigation("UsuarioAbertura");

                    b.Navigation("UsuarioSolucao");
                });

            modelBuilder.Entity("GestaoProcessos.Dominio.Chamados.FilaUsuario", b =>
                {
                    b.HasOne("GestaoProcessos.Dominio.Chamados.FilaChamado", "Fila")
                        .WithMany("FilasUsuarios")
                        .HasForeignKey("FilaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestaoProcessos.Dominio.Administracao.Usuario", "Usuario")
                        .WithMany("FilasUsuarios")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fila");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("GestaoProcessos.Dominio.Administracao.Empresa", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("GestaoProcessos.Dominio.Administracao.Filial", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("GestaoProcessos.Dominio.Administracao.Funcao", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("GestaoProcessos.Dominio.Administracao.Setor", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("GestaoProcessos.Dominio.Administracao.Usuario", b =>
                {
                    b.Navigation("ChamadosAbertura");

                    b.Navigation("ChamadosSolucao");

                    b.Navigation("FilasUsuarios");

                    b.Navigation("UsuariosSubordinados");
                });

            modelBuilder.Entity("GestaoProcessos.Dominio.Chamados.CategoriaChamado", b =>
                {
                    b.Navigation("Chamados");
                });

            modelBuilder.Entity("GestaoProcessos.Dominio.Chamados.FilaChamado", b =>
                {
                    b.Navigation("Chamados");

                    b.Navigation("FilasUsuarios");
                });

            modelBuilder.Entity("GestaoProcessos.Dominio.Chamados.StatusChamado", b =>
                {
                    b.Navigation("Chamados");
                });

            modelBuilder.Entity("GestaoProcessos.Dominio.Chamados.SubfilaChamado", b =>
                {
                    b.Navigation("Chamados");
                });
#pragma warning restore 612, 618
        }
    }
}
