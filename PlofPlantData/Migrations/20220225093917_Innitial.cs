using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlofPlantData.Migrations
{
    public partial class Innitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kassen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Temp = table.Column<double>(type: "float", nullable: false),
                    Co2 = table.Column<double>(type: "float", nullable: false),
                    Luchtvochtigheid = table.Column<double>(type: "float", nullable: false),
                    IsDeurOpen = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kassen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Verdiepingen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ph = table.Column<double>(type: "float", nullable: false),
                    Ec = table.Column<double>(type: "float", nullable: false),
                    WaterLevel = table.Column<double>(type: "float", nullable: false),
                    LichtLevel = table.Column<double>(type: "float", nullable: false),
                    KasId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verdiepingen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Verdiepingen_Kassen_KasId",
                        column: x => x.KasId,
                        principalTable: "Kassen",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Planten",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VerdiepingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planten", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Planten_Verdiepingen_VerdiepingId",
                        column: x => x.VerdiepingId,
                        principalTable: "Verdiepingen",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Planten_VerdiepingId",
                table: "Planten",
                column: "VerdiepingId");

            migrationBuilder.CreateIndex(
                name: "IX_Verdiepingen_KasId",
                table: "Verdiepingen",
                column: "KasId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planten");

            migrationBuilder.DropTable(
                name: "Verdiepingen");

            migrationBuilder.DropTable(
                name: "Kassen");
        }
    }
}
