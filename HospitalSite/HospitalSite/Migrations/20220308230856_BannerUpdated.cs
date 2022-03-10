using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalSite.Migrations
{
    public partial class BannerUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Banners");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Banners",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);
        }
    }
}
