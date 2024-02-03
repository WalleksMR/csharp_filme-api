using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace filmesAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cinemas_Endereco_EnderecoId",
                table: "Cinemas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Filmes",
                table: "Filmes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cinemas",
                table: "Cinemas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco");

            migrationBuilder.RenameTable(
                name: "Filmes",
                newName: "filmes");

            migrationBuilder.RenameTable(
                name: "Cinemas",
                newName: "cinemas");

            migrationBuilder.RenameTable(
                name: "Endereco",
                newName: "enderecos");

            migrationBuilder.RenameIndex(
                name: "IX_Cinemas_EnderecoId",
                table: "cinemas",
                newName: "IX_cinemas_EnderecoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_filmes",
                table: "filmes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cinemas",
                table: "cinemas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_enderecos",
                table: "enderecos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_cinemas_enderecos_EnderecoId",
                table: "cinemas",
                column: "EnderecoId",
                principalTable: "enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cinemas_enderecos_EnderecoId",
                table: "cinemas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_filmes",
                table: "filmes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cinemas",
                table: "cinemas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_enderecos",
                table: "enderecos");

            migrationBuilder.RenameTable(
                name: "filmes",
                newName: "Filmes");

            migrationBuilder.RenameTable(
                name: "cinemas",
                newName: "Cinemas");

            migrationBuilder.RenameTable(
                name: "enderecos",
                newName: "Endereco");

            migrationBuilder.RenameIndex(
                name: "IX_cinemas_EnderecoId",
                table: "Cinemas",
                newName: "IX_Cinemas_EnderecoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Filmes",
                table: "Filmes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cinemas",
                table: "Cinemas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cinemas_Endereco_EnderecoId",
                table: "Cinemas",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
