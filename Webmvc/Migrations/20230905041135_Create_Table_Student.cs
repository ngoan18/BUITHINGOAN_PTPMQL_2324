using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webmvc.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_Student : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Studdent",
                table: "Studdent");

            migrationBuilder.RenameTable(
                name: "Studdent",
                newName: "Student");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "StudentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Studdent");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Studdent",
                table: "Studdent",
                column: "StudentID");
        }
    }
}
