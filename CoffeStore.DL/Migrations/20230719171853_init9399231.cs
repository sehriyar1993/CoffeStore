using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeStore.DL.Migrations
{
    public partial class init9399231 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "NewsLetters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "NewsLetters");
        }
    }
}
