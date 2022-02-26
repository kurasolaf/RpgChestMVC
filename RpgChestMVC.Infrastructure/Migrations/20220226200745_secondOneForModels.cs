using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgChestMVC.Infrastructure.Migrations
{
    public partial class secondOneForModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BonusMultiplier",
                table: "Rarities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemRarity",
                table: "Rarities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfSockets",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DmgFromElement",
                table: "BonusDmgFromElementals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ValueR",
                table: "BonusDmgFromElementals",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BonusMultiplier",
                table: "Rarities");

            migrationBuilder.DropColumn(
                name: "ItemRarity",
                table: "Rarities");

            migrationBuilder.DropColumn(
                name: "NumberOfSockets",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "DmgFromElement",
                table: "BonusDmgFromElementals");

            migrationBuilder.DropColumn(
                name: "ValueR",
                table: "BonusDmgFromElementals");
        }
    }
}
