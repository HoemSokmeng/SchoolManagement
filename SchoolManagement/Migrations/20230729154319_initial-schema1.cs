using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagement.Migrations
{
    /// <inheritdoc />
    public partial class initialschema1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Grade",
                table: "scoreStudents",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "scoreStudents",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "average",
                table: "scoreStudents",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "scoreStudents");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "scoreStudents");

            migrationBuilder.DropColumn(
                name: "average",
                table: "scoreStudents");
        }
    }
}
