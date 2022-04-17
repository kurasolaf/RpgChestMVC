using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgChestMVC.Infrastructure.Migrations
{
    public partial class MayMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Items",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "BasicStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasicsStat = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasicStats_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SecondaryStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SecondarysStat = table.Column<int>(type: "int", nullable: false),
                    ValueSS = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondaryStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecondaryStats_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasicStats_ItemId",
                table: "BasicStats",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SecondaryStats_ItemId",
                table: "SecondaryStats",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasicStats");

            migrationBuilder.DropTable(
                name: "SecondaryStats");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Items");
        }
    }
}
