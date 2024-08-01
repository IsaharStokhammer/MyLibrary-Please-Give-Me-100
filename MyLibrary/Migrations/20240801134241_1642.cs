using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyLibrary.Migrations
{
    /// <inheritdoc />
    public partial class _1642 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Serie",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GenreId1",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Serie_GenreId",
                table: "Serie",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_GenreId1",
                table: "Book",
                column: "GenreId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Genre_GenreId1",
                table: "Book",
                column: "GenreId1",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Serie_Genre_GenreId",
                table: "Serie",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Genre_GenreId1",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Serie_Genre_GenreId",
                table: "Serie");

            migrationBuilder.DropIndex(
                name: "IX_Serie_GenreId",
                table: "Serie");

            migrationBuilder.DropIndex(
                name: "IX_Book_GenreId1",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Serie");

            migrationBuilder.DropColumn(
                name: "GenreId1",
                table: "Book");
        }
    }
}
