using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CookBook.Infrastructure.Migrations
{
    public partial class RemoveStarsAndLikes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Likes",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "Stars",
                table: "Recipe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Likes",
                table: "Recipe",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Stars",
                table: "Recipe",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
