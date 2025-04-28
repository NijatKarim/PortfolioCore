using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioCore.Migrations
{
    public partial class addsummary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Summary2",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Summary2",
                table: "Abouts");
        }
    }
}
