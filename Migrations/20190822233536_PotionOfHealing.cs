using Microsoft.EntityFrameworkCore.Migrations;

namespace Herbalist.Migrations
{
    public partial class PotionOfHealing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PotionRecipes",
                columns: new[] { "Id", "DC", "Description", "PotionName", "Rarity" },
                values: new object[,]
                {
                    { 1, 10, @"You regain 2d4 + 2 Hit Points when you drink this potion.
                The potion's red liquid glimmers when agitated.", "Healing Potion", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PotionRecipes",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
