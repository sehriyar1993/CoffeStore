using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeStore.DL.Migrations
{
    public partial class init939 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AboutUs",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutUs",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Abouts");
        }
    }
}
