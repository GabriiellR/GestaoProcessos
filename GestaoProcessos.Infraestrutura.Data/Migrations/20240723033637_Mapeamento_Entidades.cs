using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GestaoProcessos.Infraestrutura.Data.Migrations
{
    /// <inheritdoc />
    public partial class Mapeamento_Entidades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cmd_cateforias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cmd_cateforias", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cmd_filas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cmd_filas", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cmd_statuschamado",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cmd_statuschamado", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cmd_subfilas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cmd_subfilas", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "empresa",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empresa", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "filial",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    logradouro = table.Column<string>(type: "varchar(400)", maxLength: 400, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bairro = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    localidade = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UF = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    numero = table.Column<int>(type: "int", nullable: false),
                    Cep = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telefone = table.Column<string>(type: "varchar(13)", maxLength: 13, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filial", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "funcao",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_funcao", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "setor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_setor", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    login = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataNascimento = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "CURDATE()"),
                    status = table.Column<sbyte>(type: "tinyint", nullable: false),
                    filial_id = table.Column<int>(type: "int", nullable: false),
                    setor_id = table.Column<int>(type: "int", nullable: false),
                    empresa_id = table.Column<int>(type: "int", nullable: false),
                    GestorId = table.Column<int>(type: "int", nullable: false),
                    FuncaoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_usuarios_empresa_empresa_id",
                        column: x => x.empresa_id,
                        principalTable: "empresa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_usuarios_filial_filial_id",
                        column: x => x.filial_id,
                        principalTable: "filial",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_usuarios_funcao_FuncaoId",
                        column: x => x.FuncaoId,
                        principalTable: "funcao",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_usuarios_setor_setor_id",
                        column: x => x.setor_id,
                        principalTable: "setor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_usuarios_usuarios_GestorId",
                        column: x => x.GestorId,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cmd_chamados",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    data_abertura = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "now()"),
                    data_atendimento = table.Column<DateTime>(type: "datetime", nullable: true),
                    data_Solucao = table.Column<DateTime>(type: "datetime", nullable: true),
                    data_fechamento = table.Column<DateTime>(type: "datetime", nullable: true),
                    titulo = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    solucao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tempo_solucao = table.Column<TimeSpan>(type: "time", nullable: true),
                    tempo_atendimento = table.Column<TimeSpan>(type: "time", nullable: true),
                    status_id = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    usuario_abertura_id = table.Column<int>(type: "int", nullable: false),
                    usuario_solucao = table.Column<int>(type: "int", nullable: true),
                    fila_id = table.Column<int>(type: "int", nullable: false),
                    categoria_id = table.Column<int>(type: "int", nullable: false),
                    subfila_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cmd_chamados", x => x.id);
                    table.ForeignKey(
                        name: "FK_cmd_chamados_cmd_cateforias_categoria_id",
                        column: x => x.categoria_id,
                        principalTable: "cmd_cateforias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cmd_chamados_cmd_filas_fila_id",
                        column: x => x.fila_id,
                        principalTable: "cmd_filas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cmd_chamados_cmd_statuschamado_status_id",
                        column: x => x.status_id,
                        principalTable: "cmd_statuschamado",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cmd_chamados_cmd_subfilas_subfila_id",
                        column: x => x.subfila_id,
                        principalTable: "cmd_subfilas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cmd_chamados_usuarios_usuario_abertura_id",
                        column: x => x.usuario_abertura_id,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cmd_chamados_usuarios_usuario_solucao",
                        column: x => x.usuario_solucao,
                        principalTable: "usuarios",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cmd_filasusuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    usuario_id = table.Column<int>(type: "int", nullable: false),
                    fila_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cmd_filasusuarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_cmd_filasusuarios_cmd_filas_fila_id",
                        column: x => x.fila_id,
                        principalTable: "cmd_filas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cmd_filasusuarios_usuarios_usuario_id",
                        column: x => x.usuario_id,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "cmd_statuschamado",
                columns: new[] { "id", "nome" },
                values: new object[,]
                {
                    { 1, "Novo" },
                    { 2, "Em Atendimento" },
                    { 3, "Pendente" },
                    { 4, "Solucionado" },
                    { 5, "Encerrado" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_cmd_chamados_categoria_id",
                table: "cmd_chamados",
                column: "categoria_id");

            migrationBuilder.CreateIndex(
                name: "IX_cmd_chamados_fila_id",
                table: "cmd_chamados",
                column: "fila_id");

            migrationBuilder.CreateIndex(
                name: "IX_cmd_chamados_status_id",
                table: "cmd_chamados",
                column: "status_id");

            migrationBuilder.CreateIndex(
                name: "IX_cmd_chamados_subfila_id",
                table: "cmd_chamados",
                column: "subfila_id");

            migrationBuilder.CreateIndex(
                name: "IX_cmd_chamados_usuario_abertura_id",
                table: "cmd_chamados",
                column: "usuario_abertura_id");

            migrationBuilder.CreateIndex(
                name: "IX_cmd_chamados_usuario_solucao",
                table: "cmd_chamados",
                column: "usuario_solucao");

            migrationBuilder.CreateIndex(
                name: "IX_cmd_filasusuarios_fila_id",
                table: "cmd_filasusuarios",
                column: "fila_id");

            migrationBuilder.CreateIndex(
                name: "IX_cmd_filasusuarios_usuario_id",
                table: "cmd_filasusuarios",
                column: "usuario_id");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_empresa_id",
                table: "usuarios",
                column: "empresa_id");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_filial_id",
                table: "usuarios",
                column: "filial_id");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_FuncaoId",
                table: "usuarios",
                column: "FuncaoId");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_GestorId",
                table: "usuarios",
                column: "GestorId");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_setor_id",
                table: "usuarios",
                column: "setor_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cmd_chamados");

            migrationBuilder.DropTable(
                name: "cmd_filasusuarios");

            migrationBuilder.DropTable(
                name: "cmd_cateforias");

            migrationBuilder.DropTable(
                name: "cmd_statuschamado");

            migrationBuilder.DropTable(
                name: "cmd_subfilas");

            migrationBuilder.DropTable(
                name: "cmd_filas");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "empresa");

            migrationBuilder.DropTable(
                name: "filial");

            migrationBuilder.DropTable(
                name: "funcao");

            migrationBuilder.DropTable(
                name: "setor");
        }
    }
}
