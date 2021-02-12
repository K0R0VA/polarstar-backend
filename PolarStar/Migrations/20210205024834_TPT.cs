using Microsoft.EntityFrameworkCore.Migrations;

namespace PolarStar.Migrations
{
    public partial class TPT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Plinths_PlinthId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Protections_ProtectionId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_PlinthId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProtectionId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Diameter",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "HighTemperature",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "HighVoltage",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LightFlow",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LightingRange",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LowTemperature",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LowVoltage",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Mass",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PlinthId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Power",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProtectionId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "Lamps",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Mass = table.Column<float>(type: "real", nullable: false),
                    LowVoltage = table.Column<int>(type: "integer", nullable: false),
                    HighVoltage = table.Column<int>(type: "integer", nullable: false),
                    Power = table.Column<int>(type: "integer", nullable: false),
                    Length = table.Column<int>(type: "integer", nullable: false),
                    Width = table.Column<int>(type: "integer", nullable: false),
                    ProtectionId = table.Column<int>(type: "integer", nullable: true),
                    LowTemperature = table.Column<int>(type: "integer", nullable: true),
                    HighTemperature = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lamps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lamps_Products_Id",
                        column: x => x.Id,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lamps_Protections_ProtectionId",
                        column: x => x.ProtectionId,
                        principalTable: "Protections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Searchlights",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    LightingRange = table.Column<int>(type: "integer", nullable: false),
                    Diameter = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Searchlights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Searchlights_Lamps_Id",
                        column: x => x.Id,
                        principalTable: "Lamps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Spotlights",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    LightFlow = table.Column<int>(type: "integer", nullable: false),
                    PlinthId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spotlights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spotlights_Lamps_Id",
                        column: x => x.Id,
                        principalTable: "Lamps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Spotlights_Plinths_PlinthId",
                        column: x => x.PlinthId,
                        principalTable: "Plinths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lamps_ProtectionId",
                table: "Lamps",
                column: "ProtectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Spotlights_PlinthId",
                table: "Spotlights",
                column: "PlinthId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Searchlights");

            migrationBuilder.DropTable(
                name: "Spotlights");

            migrationBuilder.DropTable(
                name: "Lamps");

            migrationBuilder.AddColumn<int>(
                name: "Diameter",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "HighTemperature",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HighVoltage",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Length",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LightFlow",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LightingRange",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LowTemperature",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LowVoltage",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Mass",
                table: "Products",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlinthId",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Power",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProtectionId",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Width",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_PlinthId",
                table: "Products",
                column: "PlinthId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProtectionId",
                table: "Products",
                column: "ProtectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Plinths_PlinthId",
                table: "Products",
                column: "PlinthId",
                principalTable: "Plinths",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Protections_ProtectionId",
                table: "Products",
                column: "ProtectionId",
                principalTable: "Protections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
