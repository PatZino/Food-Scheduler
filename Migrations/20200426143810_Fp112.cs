using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodPlanner.Migrations
{
    public partial class Fp112 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "GrainDishSoup");

            migrationBuilder.AddColumn<int>(
                name: "SoupName",
                table: "GrainDishSoup",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoupName",
                table: "GrainDishSoup");

            migrationBuilder.AddColumn<int>(
                name: "Name",
                table: "GrainDishSoup",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
