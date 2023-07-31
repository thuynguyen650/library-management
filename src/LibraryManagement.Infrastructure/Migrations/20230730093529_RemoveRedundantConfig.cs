using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveRedundantConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Books_BooksId",
                table: "AuthorBook");

            migrationBuilder.DropForeignKey(
                name: "FK_BookBookCategory_Books_BooksId",
                table: "BookBookCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_BookUser_Books_BooksId",
                table: "BookUser");

            migrationBuilder.RenameColumn(
                name: "BooksId",
                table: "BookUser",
                newName: "BookId");

            migrationBuilder.RenameColumn(
                name: "BooksId",
                table: "BookBookCategory",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BookBookCategory_BooksId",
                table: "BookBookCategory",
                newName: "IX_BookBookCategory_BookId");

            migrationBuilder.RenameColumn(
                name: "BooksId",
                table: "AuthorBook",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorBook_BooksId",
                table: "AuthorBook",
                newName: "IX_AuthorBook_BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBook_Books_BookId",
                table: "AuthorBook",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookBookCategory_Books_BookId",
                table: "BookBookCategory",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookUser_Books_BookId",
                table: "BookUser",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Books_BookId",
                table: "AuthorBook");

            migrationBuilder.DropForeignKey(
                name: "FK_BookBookCategory_Books_BookId",
                table: "BookBookCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_BookUser_Books_BookId",
                table: "BookUser");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "BookUser",
                newName: "BooksId");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "BookBookCategory",
                newName: "BooksId");

            migrationBuilder.RenameIndex(
                name: "IX_BookBookCategory_BookId",
                table: "BookBookCategory",
                newName: "IX_BookBookCategory_BooksId");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "AuthorBook",
                newName: "BooksId");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorBook_BookId",
                table: "AuthorBook",
                newName: "IX_AuthorBook_BooksId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBook_Books_BooksId",
                table: "AuthorBook",
                column: "BooksId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookBookCategory_Books_BooksId",
                table: "BookBookCategory",
                column: "BooksId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookUser_Books_BooksId",
                table: "BookUser",
                column: "BooksId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
