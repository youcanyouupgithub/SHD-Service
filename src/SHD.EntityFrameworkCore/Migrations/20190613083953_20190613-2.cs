using Microsoft.EntityFrameworkCore.Migrations;

namespace SHD.Migrations
{
    public partial class _201906132 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_u_Package",
                table: "u_Package");

            migrationBuilder.RenameTable(
                name: "u_Package",
                newName: "Dish");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dish",
                table: "Dish",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Dish",
                table: "Dish");

            migrationBuilder.RenameTable(
                name: "Dish",
                newName: "u_Package");

            migrationBuilder.AddPrimaryKey(
                name: "PK_u_Package",
                table: "u_Package",
                column: "Id");
        }
    }
}
