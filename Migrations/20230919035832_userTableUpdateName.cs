using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace library_management.Migrations
{
    /// <inheritdoc />
    public partial class userTableUpdateName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "LibraryUser");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LibraryUser",
                table: "LibraryUser",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LibraryUser",
                table: "LibraryUser");

            migrationBuilder.RenameTable(
                name: "LibraryUser",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");
        }
    }
}
