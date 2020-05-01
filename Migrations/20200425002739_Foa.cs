using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodPlanner.Migrations
{
    public partial class Foa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GrainDishes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrainDishes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GrainDishNutrient",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrainName = table.Column<int>(nullable: false),
                    KaroMainIngredientsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrainDishNutrient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LightFood",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LightFood", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lightFoodNutrients",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LightFoodName = table.Column<int>(nullable: false),
                    LightFoodMainIngredient = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lightFoodNutrients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainIngredients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    ClassOfFood = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainIngredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Soups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SwallowNutrient",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SwallowName = table.Column<int>(nullable: false),
                    MainIngredientsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SwallowNutrient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Swallows",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Swallows", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GrainDishes");

            migrationBuilder.DropTable(
                name: "GrainDishNutrient");

            migrationBuilder.DropTable(
                name: "LightFood");

            migrationBuilder.DropTable(
                name: "lightFoodNutrients");

            migrationBuilder.DropTable(
                name: "MainIngredients");

            migrationBuilder.DropTable(
                name: "Soups");

            migrationBuilder.DropTable(
                name: "SwallowNutrient");

            migrationBuilder.DropTable(
                name: "Swallows");
        }
    }
}
