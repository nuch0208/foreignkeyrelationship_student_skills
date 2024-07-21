using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace foreignkeyrelationship_student_skills.Migrations
{
    /// <inheritdoc />
    public partial class MigrationInitial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "skillod",
                table: "students");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "skillod",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
