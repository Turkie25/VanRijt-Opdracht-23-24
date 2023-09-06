using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VanRijtDataBase.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EvenementData",
                columns: table => new
                {
                    EvenementDataID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EvenementID = table.Column<int>(type: "int", nullable: false),
                    Tijd = table.Column<TimeOnly>(type: "time(6)", nullable: false),
                    Instroom = table.Column<int>(type: "int", nullable: false),
                    Uitstroom = table.Column<int>(type: "int", nullable: false),
                    Weer = table.Column<int>(type: "int", nullable: false),
                    Tempratuur = table.Column<int>(type: "int", nullable: false),
                    Notitie = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvenementData", x => x.EvenementDataID);
                    table.ForeignKey(
                        name: "FK_EvenementData_Evenement_EvenementID",
                        column: x => x.EvenementID,
                        principalTable: "Evenement",
                        principalColumn: "EvenementID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_EvenementData_EvenementID",
                table: "EvenementData",
                column: "EvenementID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EvenementData");
        }
    }
}
