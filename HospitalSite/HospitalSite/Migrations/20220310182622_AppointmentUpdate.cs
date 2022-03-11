using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalSite.Migrations
{
    public partial class AppointmentUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Teams",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Teams");
        }
    }
}
