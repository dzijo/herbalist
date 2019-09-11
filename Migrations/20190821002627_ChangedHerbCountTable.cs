using Microsoft.EntityFrameworkCore.Migrations;

namespace Herbalist.Migrations
{
    public partial class ChangedHerbCountTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HerbCounts",
                table: "HerbCounts");

            migrationBuilder.DropColumn(
                name: "UsedId",
                table: "HerbCounts");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "HerbCounts",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HerbCounts",
                table: "HerbCounts",
                columns: new[] { "HerbId", "UserName" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HerbCounts",
                table: "HerbCounts");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "HerbCounts");

            migrationBuilder.AddColumn<string>(
                name: "UsedId",
                table: "HerbCounts",
                maxLength: 450,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HerbCounts",
                table: "HerbCounts",
                columns: new[] { "HerbId", "UsedId" });
        }
    }
}
