using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioCore.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPhonenumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactLocation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    EducationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationDateInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationSubtitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.EducationId);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    ExperienceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExperienceTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExperienceSubTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExperienceDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExperienceDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.ExperienceId);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageNameSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageSendDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageIsRead = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageId);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    TestimonialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestimonialNameSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestimonialTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestimonialCommentDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestimonialImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.TestimonialId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Testimonials");
        }
    }
}
