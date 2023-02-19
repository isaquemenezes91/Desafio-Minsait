using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Livraria.Migrations
{
    /// <inheritdoc />
    public partial class TesteRelacionamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutorLivro_Autores_AutorId",
                table: "AutorLivro");

            migrationBuilder.DropForeignKey(
                name: "FK_AutorLivro_Livros_LivroId",
                table: "AutorLivro");

            migrationBuilder.RenameColumn(
                name: "LivroId",
                table: "AutorLivro",
                newName: "LivrosId");

            migrationBuilder.RenameColumn(
                name: "AutorId",
                table: "AutorLivro",
                newName: "AutoresId");

            migrationBuilder.RenameIndex(
                name: "IX_AutorLivro_LivroId",
                table: "AutorLivro",
                newName: "IX_AutorLivro_LivrosId");

            migrationBuilder.AddForeignKey(
                name: "FK_AutorLivro_Autores_AutoresId",
                table: "AutorLivro",
                column: "AutoresId",
                principalTable: "Autores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutorLivro_Livros_LivrosId",
                table: "AutorLivro",
                column: "LivrosId",
                principalTable: "Livros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutorLivro_Autores_AutoresId",
                table: "AutorLivro");

            migrationBuilder.DropForeignKey(
                name: "FK_AutorLivro_Livros_LivrosId",
                table: "AutorLivro");

            migrationBuilder.RenameColumn(
                name: "LivrosId",
                table: "AutorLivro",
                newName: "LivroId");

            migrationBuilder.RenameColumn(
                name: "AutoresId",
                table: "AutorLivro",
                newName: "AutorId");

            migrationBuilder.RenameIndex(
                name: "IX_AutorLivro_LivrosId",
                table: "AutorLivro",
                newName: "IX_AutorLivro_LivroId");

            migrationBuilder.AddForeignKey(
                name: "FK_AutorLivro_Autores_AutorId",
                table: "AutorLivro",
                column: "AutorId",
                principalTable: "Autores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutorLivro_Livros_LivroId",
                table: "AutorLivro",
                column: "LivroId",
                principalTable: "Livros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
