using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoteLLLBackend.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hospedagens",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataReserva = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataCheckOut = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsReserva = table.Column<bool>(type: "bit", nullable: false),
                    FuncionarioId = table.Column<long>(type: "bigint", nullable: false),
                    IsAtiva = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospedagens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoCadastro = table.Column<int>(type: "int", nullable: false),
                    DataRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAtiva = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quartos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tamanho = table.Column<int>(type: "int", nullable: false),
                    IsOcupado = table.Column<bool>(type: "bit", nullable: false),
                    IsReservado = table.Column<bool>(type: "bit", nullable: false),
                    IsAtivo = table.Column<bool>(type: "bit", nullable: false),
                    HospedagemId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quartos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quartos_Hospedagens_HospedagemId",
                        column: x => x.HospedagemId,
                        principalTable: "Hospedagens",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HospedagemPessoa",
                columns: table => new
                {
                    HospedagensId = table.Column<long>(type: "bigint", nullable: false),
                    HospedesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospedagemPessoa", x => new { x.HospedagensId, x.HospedesId });
                    table.ForeignKey(
                        name: "FK_HospedagemPessoa_Hospedagens_HospedagensId",
                        column: x => x.HospedagensId,
                        principalTable: "Hospedagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospedagemPessoa_Pessoas_HospedesId",
                        column: x => x.HospedesId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HospedagemPessoa_HospedesId",
                table: "HospedagemPessoa",
                column: "HospedesId");

            migrationBuilder.CreateIndex(
                name: "IX_Quartos_HospedagemId",
                table: "Quartos",
                column: "HospedagemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HospedagemPessoa");

            migrationBuilder.DropTable(
                name: "Quartos");

            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "Hospedagens");
        }
    }
}
