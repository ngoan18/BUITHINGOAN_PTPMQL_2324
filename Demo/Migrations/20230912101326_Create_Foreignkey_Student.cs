using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class Create_Foreignkey_Student : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PersonID",
                table: "Student",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Student_PersonID",
                table: "Student",
                column: "PersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Person_PersonID",
                table: "Student",
                column: "PersonID",
                principalTable: "Person",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Person_PersonID",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_PersonID",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "Student");
        }
    }
}
