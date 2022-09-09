using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgChestMVC.Infrastructure.Migrations
{
    public partial class PlayerBackapckUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FullArmors_PlayerBackpacks_PlayerBackpackId",
                table: "FullArmors");

            migrationBuilder.AlterColumn<int>(
                name: "PlayerBackpackId",
                table: "FullArmors",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_FullArmors_PlayerBackpacks_PlayerBackpackId",
                table: "FullArmors",
                column: "PlayerBackpackId",
                principalTable: "PlayerBackpacks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FullArmors_PlayerBackpacks_PlayerBackpackId",
                table: "FullArmors");

            migrationBuilder.AlterColumn<int>(
                name: "PlayerBackpackId",
                table: "FullArmors",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FullArmors_PlayerBackpacks_PlayerBackpackId",
                table: "FullArmors",
                column: "PlayerBackpackId",
                principalTable: "PlayerBackpacks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
