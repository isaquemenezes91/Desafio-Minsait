using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Livraria.Migrations
{
    /// <inheritdoc />
    public partial class updateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autores_Livros_LivroId",
                table: "Autores");

            migrationBuilder.AlterColumn<int>(
                name: "LivroId",
                table: "Autores",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Autores_Livros_LivroId",
                table: "Autores",
                column: "LivroId",
                principalTable: "Livros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autores_Livros_LivroId",
                table: "Autores");

            migrationBuilder.AlterColumn<int>(
                name: "LivroId",
                table: "Autores",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Autores_Livros_LivroId",
                table: "Autores",
                column: "LivroId",
                principalTable: "Livros",
                principalColumn: "Id");
        }
    }
}
