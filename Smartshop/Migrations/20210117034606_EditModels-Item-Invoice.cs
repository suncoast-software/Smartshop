using Microsoft.EntityFrameworkCore.Migrations;

namespace Smartshop.Migrations
{
    public partial class EditModelsItemInvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Invoices_InvoiceId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_InvoiceId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "InvoiceNumber",
                table: "Items",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvoiceNumber",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "Items",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_InvoiceId",
                table: "Items",
                column: "InvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Invoices_InvoiceId",
                table: "Items",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
