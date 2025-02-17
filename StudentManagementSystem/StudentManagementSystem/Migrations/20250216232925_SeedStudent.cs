using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeedStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProgramCode",
                table: "Students",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Programs",
                columns: table => new
                {
                    ProgramCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProgramName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programs", x => x.ProgramCode);
                });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "ProgramCode", "ProgramName" },
                values: new object[] { "ARTS", "Arts and Sciences" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "GPA", "LastName", "ProgramCode" },
                values: new object[,]
                {
                    { 1, new DateTime(1971, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bart", 2.7000000000000002, "Simpson", "ARTS" },
                    { 2, new DateTime(1973, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lisa", 4.0, "Simpson", "ARTS" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_ProgramCode",
                table: "Students",
                column: "ProgramCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Programs_ProgramCode",
                table: "Students",
                column: "ProgramCode",
                principalTable: "Programs",
                principalColumn: "ProgramCode",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Programs_ProgramCode",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Programs");

            migrationBuilder.DropIndex(
                name: "IX_Students_ProgramCode",
                table: "Students");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "ProgramCode",
                table: "Students");
        }
    }
}
