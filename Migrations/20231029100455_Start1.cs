using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LifeGuides.Migrations
{
    /// <inheritdoc />
    public partial class Start1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BooksAuthors_authorid",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "authorid",
                table: "Books",
                newName: "authorId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_authorid",
                table: "Books",
                newName: "IX_Books_authorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BooksAuthors_authorId",
                table: "Books",
                column: "authorId",
                principalTable: "BooksAuthors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BooksAuthors_authorId",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "authorId",
                table: "Books",
                newName: "authorid");

            migrationBuilder.RenameIndex(
                name: "IX_Books_authorId",
                table: "Books",
                newName: "IX_Books_authorid");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BooksAuthors_authorid",
                table: "Books",
                column: "authorid",
                principalTable: "BooksAuthors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
