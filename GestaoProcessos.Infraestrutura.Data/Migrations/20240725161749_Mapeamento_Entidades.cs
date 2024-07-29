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
                name: "adm_empresa",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adm_empresa", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "adm_filial",
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
                    cep = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telefone = table.Column<string>(type: "varchar(13)", maxLength: 13, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adm_filial", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "adm_funcao",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adm_funcao", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "adm_setor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adm_setor", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cmd_categorias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cmd_categorias", x => x.id);
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
                name: "adm_parametros",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome_sistema = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    segredo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DuracaoToken = table.Column<int>(type: "int", nullable: false),
                    diretorio_raiz_arquivos = table.Column<string>(type: "varchar(400)", maxLength: 400, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    extensoes_aceitas = table.Column<string>(type: "varchar(400)", maxLength: 400, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tamanho_maximo_arquivo = table.Column<int>(type: "int", nullable: false),
                    empresa_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adm_parametros", x => x.id);
                    table.ForeignKey(
                        name: "FK_adm_parametros_adm_empresa_empresa_id",
                        column: x => x.empresa_id,
                        principalTable: "adm_empresa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "adm_usuarios",
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
                    hash_senha = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    salt = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    data_nascimento = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "CURDATE()"),
                    status = table.Column<sbyte>(type: "tinyint", nullable: false),
                    filial_id = table.Column<int>(type: "int", nullable: false),
                    setor_id = table.Column<int>(type: "int", nullable: false),
                    empresa_id = table.Column<int>(type: "int", nullable: false),
                    gestor_id = table.Column<int>(type: "int", nullable: true),
                    funcao_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adm_usuarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_adm_usuarios_adm_empresa_empresa_id",
                        column: x => x.empresa_id,
                        principalTable: "adm_empresa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_adm_usuarios_adm_filial_filial_id",
                        column: x => x.filial_id,
                        principalTable: "adm_filial",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_adm_usuarios_adm_funcao_funcao_id",
                        column: x => x.funcao_id,
                        principalTable: "adm_funcao",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_adm_usuarios_adm_setor_setor_id",
                        column: x => x.setor_id,
                        principalTable: "adm_setor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_adm_usuarios_adm_usuarios_gestor_id",
                        column: x => x.gestor_id,
                        principalTable: "adm_usuarios",
                        principalColumn: "id");
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
                    subfila_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cmd_chamados", x => x.id);
                    table.ForeignKey(
                        name: "FK_cmd_chamados_adm_usuarios_usuario_abertura_id",
                        column: x => x.usuario_abertura_id,
                        principalTable: "adm_usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cmd_chamados_adm_usuarios_usuario_solucao",
                        column: x => x.usuario_solucao,
                        principalTable: "adm_usuarios",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_cmd_chamados_cmd_categorias_categoria_id",
                        column: x => x.categoria_id,
                        principalTable: "cmd_categorias",
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
                        name: "FK_cmd_filasusuarios_adm_usuarios_usuario_id",
                        column: x => x.usuario_id,
                        principalTable: "adm_usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cmd_filasusuarios_cmd_filas_fila_id",
                        column: x => x.fila_id,
                        principalTable: "cmd_filas",
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
                name: "IX_adm_parametros_empresa_id",
                table: "adm_parametros",
                column: "empresa_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_adm_usuarios_empresa_id",
                table: "adm_usuarios",
                column: "empresa_id");

            migrationBuilder.CreateIndex(
                name: "IX_adm_usuarios_filial_id",
                table: "adm_usuarios",
                column: "filial_id");

            migrationBuilder.CreateIndex(
                name: "IX_adm_usuarios_funcao_id",
                table: "adm_usuarios",
                column: "funcao_id");

            migrationBuilder.CreateIndex(
                name: "IX_adm_usuarios_gestor_id",
                table: "adm_usuarios",
                column: "gestor_id");

            migrationBuilder.CreateIndex(
                name: "IX_adm_usuarios_setor_id",
                table: "adm_usuarios",
                column: "setor_id");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "adm_parametros");

            migrationBuilder.DropTable(
                name: "cmd_chamados");

            migrationBuilder.DropTable(
                name: "cmd_filasusuarios");

            migrationBuilder.DropTable(
                name: "cmd_categorias");

            migrationBuilder.DropTable(
                name: "cmd_statuschamado");

            migrationBuilder.DropTable(
                name: "cmd_subfilas");

            migrationBuilder.DropTable(
                name: "adm_usuarios");

            migrationBuilder.DropTable(
                name: "cmd_filas");

            migrationBuilder.DropTable(
                name: "adm_empresa");

            migrationBuilder.DropTable(
                name: "adm_filial");

            migrationBuilder.DropTable(
                name: "adm_funcao");

            migrationBuilder.DropTable(
                name: "adm_setor");
        }
    }
}
