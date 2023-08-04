using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeStore.DL.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "HomeClasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BannerAbout",
                table: "HomeClasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BannerAbout2",
                table: "HomeClasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BannerAbout3",
                table: "HomeClasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BannerAbout4",
                table: "HomeClasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BannerDescription",
                table: "HomeClasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BannerDescription2",
                table: "HomeClasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BannerDescription3",
                table: "HomeClasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BannerDescription4",
                table: "HomeClasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BannerTitle",
                table: "HomeClasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BannerTitle2",
                table: "HomeClasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BannerTitle3",
                table: "HomeClasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BannerTitle4",
                table: "HomeClasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "HomeClasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "HomeClasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "About",
                table: "HomeClasses");

            migrationBuilder.DropColumn(
                name: "BannerAbout",
                table: "HomeClasses");

            migrationBuilder.DropColumn(
                name: "BannerAbout2",
                table: "HomeClasses");

            migrationBuilder.DropColumn(
                name: "BannerAbout3",
                table: "HomeClasses");

            migrationBuilder.DropColumn(
                name: "BannerAbout4",
                table: "HomeClasses");

            migrationBuilder.DropColumn(
                name: "BannerDescription",
                table: "HomeClasses");

            migrationBuilder.DropColumn(
                name: "BannerDescription2",
                table: "HomeClasses");

            migrationBuilder.DropColumn(
                name: "BannerDescription3",
                table: "HomeClasses");

            migrationBuilder.DropColumn(
                name: "BannerDescription4",
                table: "HomeClasses");

            migrationBuilder.DropColumn(
                name: "BannerTitle",
                table: "HomeClasses");

            migrationBuilder.DropColumn(
                name: "BannerTitle2",
                table: "HomeClasses");

            migrationBuilder.DropColumn(
                name: "BannerTitle3",
                table: "HomeClasses");

            migrationBuilder.DropColumn(
                name: "BannerTitle4",
                table: "HomeClasses");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "HomeClasses");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "HomeClasses");
        }
    }
}
