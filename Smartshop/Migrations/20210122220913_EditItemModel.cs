using Microsoft.EntityFrameworkCore.Migrations;

namespace Smartshop.Migrations
{
    public partial class EditItemModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Items",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Items");

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Items",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
