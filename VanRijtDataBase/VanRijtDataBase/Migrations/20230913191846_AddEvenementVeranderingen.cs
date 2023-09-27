using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VanRijtDataBase.Migrations
{
    /// <inheritdoc />
    public partial class AddEvenementVeranderingen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evenement_Adres_AdresID",
                table: "Evenement");

            migrationBuilder.DropForeignKey(
                name: "FK_EvenementData_Evenement_EvenementID",
                table: "EvenementData");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Login_LoginID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Notitie",
                table: "EvenementData");

            migrationBuilder.AlterColumn<string>(
                name: "TelefoonNummer",
                table: "User",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "User",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "LoginID",
                table: "User",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "BedrijfsNaam",
                table: "User",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Login",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "UserType",
                table: "Login",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Login",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "EvenementID",
                table: "EvenementData",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "EventNaam",
                table: "Evenement",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "AdresID",
                table: "Evenement",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Evenement",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Straat",
                table: "Adres",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PostCode",
                table: "Adres",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EvenementVeranderingens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EvenementID = table.Column<int>(type: "int", nullable: true),
                    Tijd = table.Column<TimeOnly>(type: "time(6)", nullable: false),
                    Notitie = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvenementVeranderingens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvenementVeranderingens_Evenement_EvenementID",
                        column: x => x.EvenementID,
                        principalTable: "Evenement",
                        principalColumn: "EvenementID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Evenement_UserID",
                table: "Evenement",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_EvenementVeranderingens_EvenementID",
                table: "EvenementVeranderingens",
                column: "EvenementID");

            migrationBuilder.AddForeignKey(
                name: "FK_Evenement_Adres_AdresID",
                table: "Evenement",
                column: "AdresID",
                principalTable: "Adres",
                principalColumn: "AdresID");

            migrationBuilder.AddForeignKey(
                name: "FK_Evenement_User_UserID",
                table: "Evenement",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_EvenementData_Evenement_EvenementID",
                table: "EvenementData",
                column: "EvenementID",
                principalTable: "Evenement",
                principalColumn: "EvenementID");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Login_LoginID",
                table: "User",
                column: "LoginID",
                principalTable: "Login",
                principalColumn: "LoginID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evenement_Adres_AdresID",
                table: "Evenement");

            migrationBuilder.DropForeignKey(
                name: "FK_Evenement_User_UserID",
                table: "Evenement");

            migrationBuilder.DropForeignKey(
                name: "FK_EvenementData_Evenement_EvenementID",
                table: "EvenementData");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Login_LoginID",
                table: "User");

            migrationBuilder.DropTable(
                name: "EvenementVeranderingens");

            migrationBuilder.DropIndex(
                name: "IX_Evenement_UserID",
                table: "Evenement");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Evenement");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "TelefoonNummer",
                keyValue: null,
                column: "TelefoonNummer",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "TelefoonNummer",
                table: "User",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Logo",
                keyValue: null,
                column: "Logo",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "User",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "LoginID",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "BedrijfsNaam",
                keyValue: null,
                column: "BedrijfsNaam",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "BedrijfsNaam",
                table: "User",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Login",
                keyColumn: "Username",
                keyValue: null,
                column: "Username",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Login",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Login",
                keyColumn: "UserType",
                keyValue: null,
                column: "UserType",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "UserType",
                table: "Login",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Login",
                keyColumn: "Password",
                keyValue: null,
                column: "Password",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Login",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "EvenementID",
                table: "EvenementData",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notitie",
                table: "EvenementData",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Evenement",
                keyColumn: "EventNaam",
                keyValue: null,
                column: "EventNaam",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "EventNaam",
                table: "Evenement",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "AdresID",
                table: "Evenement",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Adres",
                keyColumn: "Straat",
                keyValue: null,
                column: "Straat",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Straat",
                table: "Adres",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Adres",
                keyColumn: "PostCode",
                keyValue: null,
                column: "PostCode",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "PostCode",
                table: "Adres",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Evenement_Adres_AdresID",
                table: "Evenement",
                column: "AdresID",
                principalTable: "Adres",
                principalColumn: "AdresID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EvenementData_Evenement_EvenementID",
                table: "EvenementData",
                column: "EvenementID",
                principalTable: "Evenement",
                principalColumn: "EvenementID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Login_LoginID",
                table: "User",
                column: "LoginID",
                principalTable: "Login",
                principalColumn: "LoginID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
