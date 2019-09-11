using Microsoft.EntityFrameworkCore.Migrations;

namespace Herbalist.Migrations
{
    public partial class HerbCountsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HerbCounts",
                columns: table => new
                {
                    HerbId = table.Column<int>(nullable: false),
                    UsedId = table.Column<string>(maxLength: 450, nullable: false),
                    Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HerbCounts", x => new { x.HerbId, x.UsedId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HerbCounts");
        }
    }
}
