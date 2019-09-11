using Microsoft.EntityFrameworkCore.Migrations;

namespace Herbalist.Migrations
{
    public partial class FixHerbInfos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Location",
                table: "HerbInfos",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "HerbInfos",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
