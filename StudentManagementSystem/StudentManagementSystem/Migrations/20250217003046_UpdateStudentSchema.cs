using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStudentSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Programs_ProgramCode",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ProgramCode",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ProgramCode",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "ProgramName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProgramName",
                value: "ARTS");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProgramName",
                value: "ARTS");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProgramName",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "ProgramCode",
                table: "Students",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProgramCode",
                value: "ARTS");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProgramCode",
                value: "ARTS");

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
    }
}
