using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace library_management.Migrations
{
    /// <inheritdoc />
    public partial class updatedFKs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "BookBorrowings",
                newName: "LibraryUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BookBorrowings_BookId",
                table: "BookBorrowings",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookBorrowings_LibraryUserId",
                table: "BookBorrowings",
                column: "LibraryUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookBorrowings_Books_BookId",
                table: "BookBorrowings",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookBorrowings_LibraryUser_LibraryUserId",
                table: "BookBorrowings",
                column: "LibraryUserId",
                principalTable: "LibraryUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookBorrowings_Books_BookId",
                table: "BookBorrowings");

            migrationBuilder.DropForeignKey(
                name: "FK_BookBorrowings_LibraryUser_LibraryUserId",
                table: "BookBorrowings");

            migrationBuilder.DropIndex(
                name: "IX_BookBorrowings_BookId",
                table: "BookBorrowings");

            migrationBuilder.DropIndex(
                name: "IX_BookBorrowings_LibraryUserId",
                table: "BookBorrowings");

            migrationBuilder.RenameColumn(
                name: "LibraryUserId",
                table: "BookBorrowings",
                newName: "UserId");
        }
    }
}
