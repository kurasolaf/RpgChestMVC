using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgChestMVC.Infrastructure.Migrations
{
    public partial class CompleteDTOAndModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dmg",
                table: "FullWeaponTypes");

            migrationBuilder.CreateTable(
                name: "BonusDmgs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DmgMultiplier = table.Column<int>(type: "int", nullable: false),
                    DmgDice = table.Column<int>(type: "int", nullable: false),
                    FullWeaponTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BonusDmgs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BonusDmgs_FullWeaponTypes_FullWeaponTypeId",
                        column: x => x.FullWeaponTypeId,
                        principalTable: "FullWeaponTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dmgs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DmgMultiplier = table.Column<int>(type: "int", nullable: false),
                    DmgDice = table.Column<int>(type: "int", nullable: false),
                    FullWeaponTypeRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dmgs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dmgs_FullWeaponTypes_FullWeaponTypeRef",
                        column: x => x.FullWeaponTypeRef,
                        principalTable: "FullWeaponTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BonusDmgs_FullWeaponTypeId",
                table: "BonusDmgs",
                column: "FullWeaponTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Dmgs_FullWeaponTypeRef",
                table: "Dmgs",
                column: "FullWeaponTypeRef",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BonusDmgs");

            migrationBuilder.DropTable(
                name: "Dmgs");

            migrationBuilder.AddColumn<int>(
                name: "Dmg",
                table: "FullWeaponTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
