using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlofPlantData.Migrations
{
    public partial class _1ToManyClassData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ec",
                table: "Verdiepingen");

            migrationBuilder.DropColumn(
                name: "LichtLevel",
                table: "Verdiepingen");

            migrationBuilder.DropColumn(
                name: "Ph",
                table: "Verdiepingen");

            migrationBuilder.DropColumn(
                name: "WaterLevel",
                table: "Verdiepingen");

            migrationBuilder.DropColumn(
                name: "Co2",
                table: "Kassen");

            migrationBuilder.DropColumn(
                name: "IsDeurOpen",
                table: "Kassen");

            migrationBuilder.DropColumn(
                name: "Luchtvochtigheid",
                table: "Kassen");

            migrationBuilder.DropColumn(
                name: "Temp",
                table: "Kassen");

            migrationBuilder.CreateTable(
                name: "KasData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KasId = table.Column<int>(type: "int", nullable: false),
                    Temp = table.Column<double>(type: "float", nullable: false),
                    Co2 = table.Column<double>(type: "float", nullable: false),
                    Luchtvochtigheid = table.Column<double>(type: "float", nullable: false),
                    IsDeurOpen = table.Column<bool>(type: "bit", nullable: false),
                    DatumToegevoegd = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KasData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KasData_Kassen_KasId",
                        column: x => x.KasId,
                        principalTable: "Kassen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VerdiepingData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VerdiepingId = table.Column<int>(type: "int", nullable: false),
                    Ph = table.Column<double>(type: "float", nullable: false),
                    Ec = table.Column<double>(type: "float", nullable: false),
                    WaterLevel = table.Column<double>(type: "float", nullable: false),
                    LichtLevel = table.Column<double>(type: "float", nullable: false),
                    DatumToegevoegd = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VerdiepingData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VerdiepingData_Verdiepingen_VerdiepingId",
                        column: x => x.VerdiepingId,
                        principalTable: "Verdiepingen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KasData_KasId",
                table: "KasData",
                column: "KasId");

            migrationBuilder.CreateIndex(
                name: "IX_VerdiepingData_VerdiepingId",
                table: "VerdiepingData",
                column: "VerdiepingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KasData");

            migrationBuilder.DropTable(
                name: "VerdiepingData");

            migrationBuilder.AddColumn<double>(
                name: "Ec",
                table: "Verdiepingen",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "LichtLevel",
                table: "Verdiepingen",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Ph",
                table: "Verdiepingen",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "WaterLevel",
                table: "Verdiepingen",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Co2",
                table: "Kassen",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeurOpen",
                table: "Kassen",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Luchtvochtigheid",
                table: "Kassen",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Temp",
                table: "Kassen",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
