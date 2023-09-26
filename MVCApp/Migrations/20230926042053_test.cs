using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCApp.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Person_SDT",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_SDT",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "SDT",
                table: "Student");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SDT",
                table: "Student",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Student_SDT",
                table: "Student",
                column: "SDT");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Person_SDT",
                table: "Student",
                column: "SDT",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
