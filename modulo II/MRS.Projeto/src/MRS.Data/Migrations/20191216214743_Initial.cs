using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MRS.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FORNECEDORES",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    Documento = table.Column<string>(type: "varchar(14)", nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FORNECEDORES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PRODUTOS",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FornecedorId = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(1000)", nullable: false),
                    Imagem = table.Column<string>(type: "varchar(100)", nullable: false),
                    Valor = table.Column<decimal>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTOS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PRODUTOS_FORNECEDORES_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "FORNECEDORES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTOS_FornecedorId",
                table: "PRODUTOS",
                column: "FornecedorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PRODUTOS");

            migrationBuilder.DropTable(
                name: "FORNECEDORES");
        }
    }
}
