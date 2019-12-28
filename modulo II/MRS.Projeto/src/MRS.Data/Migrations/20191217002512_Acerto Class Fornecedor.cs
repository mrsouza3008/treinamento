using Microsoft.EntityFrameworkCore.Migrations;

namespace MRS.Data.Migrations
{
    public partial class AcertoClassFornecedor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoFornecedor",
                table: "FORNECEDORES",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoFornecedor",
                table: "FORNECEDORES");
        }
    }
}
