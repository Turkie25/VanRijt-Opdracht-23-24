using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VanRijtDataBase.Migrations
{
    /// <inheritdoc />
    public partial class movedUserType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserType",
                table: "Login");

            migrationBuilder.AddColumn<string>(
                name: "UserType",
                table: "User",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserType",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "UserType",
                table: "Login",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
