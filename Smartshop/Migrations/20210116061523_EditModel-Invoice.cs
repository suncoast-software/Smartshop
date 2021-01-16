using Microsoft.EntityFrameworkCore.Migrations;

namespace Smartshop.Migrations
{
    public partial class EditModelInvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Customers_CustomerId",
                table: "Invoice");

            migrationBuilder.DropIndex(
                name: "IX_Invoice_CustomerId",
                table: "Invoice");

            migrationBuilder.AlterColumn<decimal>(
                name: "CustomerId",
                table: "Invoice",
                type: "numeric(20,0)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId1",
                table: "Invoice",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_CustomerId1",
                table: "Invoice",
                column: "CustomerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Customers_CustomerId1",
                table: "Invoice",
                column: "CustomerId1",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Customers_CustomerId1",
                table: "Invoice");

            migrationBuilder.DropIndex(
                name: "IX_Invoice_CustomerId1",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "Invoice");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Invoice",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(20,0)");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_CustomerId",
                table: "Invoice",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Customers_CustomerId",
                table: "Invoice",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
