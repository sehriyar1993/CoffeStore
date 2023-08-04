using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeStore.DL.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "About2",
                table: "HomeClasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description2",
                table: "HomeClasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title2",
                table: "HomeClasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "About2",
                table: "HomeClasses");

            migrationBuilder.DropColumn(
                name: "Description2",
                table: "HomeClasses");

            migrationBuilder.DropColumn(
                name: "Title2",
                table: "HomeClasses");
        }
    }
}
