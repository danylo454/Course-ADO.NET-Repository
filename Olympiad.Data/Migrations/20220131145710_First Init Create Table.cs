using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Olympiad.Data.Migrations
{
    public partial class FirstInitCreateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CountryAgents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPlayerAgent = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryAgents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CountryAgents_Players_IdPlayerAgent",
                        column: x => x.IdPlayerAgent,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OlympiadaTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCountryAgent = table.Column<int>(type: "int", nullable: false),
                    Gold = table.Column<int>(type: "int", nullable: false),
                    Silver = table.Column<int>(type: "int", nullable: false),
                    Bronze = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OlympiadaTables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OlympiadaTables_CountryAgents_IdCountryAgent",
                        column: x => x.IdCountryAgent,
                        principalTable: "CountryAgents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Olympiads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOlypiada = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdTableOlypida = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Olympiads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Olympiads_OlympiadaTables_IdTableOlypida",
                        column: x => x.IdTableOlypida,
                        principalTable: "OlympiadaTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CountryAgents_IdPlayerAgent",
                table: "CountryAgents",
                column: "IdPlayerAgent");

            migrationBuilder.CreateIndex(
                name: "IX_OlympiadaTables_IdCountryAgent",
                table: "OlympiadaTables",
                column: "IdCountryAgent");

            migrationBuilder.CreateIndex(
                name: "IX_Olympiads_IdTableOlypida",
                table: "Olympiads",
                column: "IdTableOlypida");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Olympiads");

            migrationBuilder.DropTable(
                name: "OlympiadaTables");

            migrationBuilder.DropTable(
                name: "CountryAgents");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
