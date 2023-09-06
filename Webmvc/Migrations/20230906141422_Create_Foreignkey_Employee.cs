using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webmvc.Migrations
{
    /// <inheritdoc />
    public partial class Create_Foreignkey_Employee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerId",
                table: "Employee",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_CustomerId",
                table: "Employee",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Customer_CustomerId",
                table: "Employee",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Customer_CustomerId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_CustomerId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Employee");
        }
    }
}
