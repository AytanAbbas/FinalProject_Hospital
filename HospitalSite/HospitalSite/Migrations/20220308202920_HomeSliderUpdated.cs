using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalSite.Migrations
{
    public partial class HomeSliderUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subtitle",
                table: "HomeSliders");

            migrationBuilder.AddColumn<string>(
                name: "LeftImage",
                table: "HomeSliders",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "HomeSliders",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RightImage",
                table: "HomeSliders",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LeftImage",
                table: "HomeSliders");

            migrationBuilder.DropColumn(
                name: "Link",
                table: "HomeSliders");

            migrationBuilder.DropColumn(
                name: "RightImage",
                table: "HomeSliders");

            migrationBuilder.AddColumn<string>(
                name: "Subtitle",
                table: "HomeSliders",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);
        }
    }
}
