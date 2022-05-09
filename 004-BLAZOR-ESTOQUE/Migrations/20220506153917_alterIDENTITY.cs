using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _004_BLAZOR_ESTOQUE.Migrations
{
    public partial class alterIDENTITY : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categorias_CategoriaCategoryId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_CategoriaCategoryId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "CategoriaCategoryId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Produtos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaCategoryId",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CategoriaCategoryId",
                table: "Produtos",
                column: "CategoriaCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categorias_CategoriaCategoryId",
                table: "Produtos",
                column: "CategoriaCategoryId",
                principalTable: "Categorias",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
