using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VanRijtDataBase.Migrations
{
    /// <inheritdoc />
    public partial class changedEvenementVeranderingName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EvenementVeranderingens_Evenement_EvenementID",
                table: "EvenementVeranderingens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EvenementVeranderingens",
                table: "EvenementVeranderingens");

            migrationBuilder.RenameTable(
                name: "EvenementVeranderingens",
                newName: "EvenementVeranderingen");

            migrationBuilder.RenameIndex(
                name: "IX_EvenementVeranderingens_EvenementID",
                table: "EvenementVeranderingen",
                newName: "IX_EvenementVeranderingen_EvenementID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EvenementVeranderingen",
                table: "EvenementVeranderingen",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EvenementVeranderingen_Evenement_EvenementID",
                table: "EvenementVeranderingen",
                column: "EvenementID",
                principalTable: "Evenement",
                principalColumn: "EvenementID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EvenementVeranderingen_Evenement_EvenementID",
                table: "EvenementVeranderingen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EvenementVeranderingen",
                table: "EvenementVeranderingen");

            migrationBuilder.RenameTable(
                name: "EvenementVeranderingen",
                newName: "EvenementVeranderingens");

            migrationBuilder.RenameIndex(
                name: "IX_EvenementVeranderingen_EvenementID",
                table: "EvenementVeranderingens",
                newName: "IX_EvenementVeranderingens_EvenementID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EvenementVeranderingens",
                table: "EvenementVeranderingens",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EvenementVeranderingens_Evenement_EvenementID",
                table: "EvenementVeranderingens",
                column: "EvenementID",
                principalTable: "Evenement",
                principalColumn: "EvenementID");
        }
    }
}
