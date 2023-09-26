using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Daily",
                columns: table => new
                {
                    Madaily = table.Column<string>(type: "TEXT", nullable: false),
                    Tendaily = table.Column<string>(type: "TEXT", nullable: false),
                    Diachi = table.Column<string>(type: "TEXT", nullable: false),
                    Nguoidaidien = table.Column<string>(type: "TEXT", nullable: false),
                    SDT = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Daily", x => x.Madaily);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    SDT = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Hethongphanphoi",
                columns: table => new
                {
                    MaHTPP = table.Column<string>(type: "TEXT", nullable: false),
                    TenHTPP = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hethongphanphoi", x => x.MaHTPP);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonId = table.Column<string>(type: "TEXT", nullable: false),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    SDT = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "Hopdong",
                columns: table => new
                {
                    Mahp = table.Column<string>(type: "TEXT", nullable: false),
                    Tenhp = table.Column<string>(type: "TEXT", nullable: false),
                    Madaily = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hopdong", x => x.Mahp);
                    table.ForeignKey(
                        name: "FK_Hopdong_Daily_Madaily",
                        column: x => x.Madaily,
                        principalTable: "Daily",
                        principalColumn: "Madaily",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Lop = table.Column<string>(type: "TEXT", nullable: false),
                    Khoa = table.Column<string>(type: "TEXT", nullable: false),
                    SDT = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Student_Person_SDT",
                        column: x => x.SDT,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hopdong_Madaily",
                table: "Hopdong",
                column: "Madaily");

            migrationBuilder.CreateIndex(
                name: "IX_Student_SDT",
                table: "Student",
                column: "SDT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Hethongphanphoi");

            migrationBuilder.DropTable(
                name: "Hopdong");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Daily");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
