using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioCore.Migrations
{
    public partial class socialmedia_tag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SocialMediaImageUrl",
                table: "SocialMedia",
                newName: "SocialMediaUrl");

            migrationBuilder.AddColumn<string>(
                name: "SocialMediaTag",
                table: "SocialMedia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SocialMediaTag",
                table: "SocialMedia");

            migrationBuilder.RenameColumn(
                name: "SocialMediaUrl",
                table: "SocialMedia",
                newName: "SocialMediaImageUrl");
        }
    }
}
