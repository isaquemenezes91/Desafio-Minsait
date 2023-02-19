using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Livraria.Migrations
{
    /// <inheritdoc />
    public partial class att1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCadastroSistema",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "DataUltimaAtualizacao",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "Autores");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastroSistema",
                table: "Livros",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataUltimaAtualizacao",
                table: "Livros",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataNascimento",
                table: "Autores",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);
        }
    }
}
