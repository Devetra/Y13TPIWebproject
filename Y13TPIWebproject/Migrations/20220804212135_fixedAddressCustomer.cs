using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Y13TPIWebproject.Migrations
{
    public partial class fixedAddressCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Customer_AddressID",
                table: "Customer",
                column: "AddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Address_AddressID",
                table: "Customer",
                column: "AddressID",
                principalTable: "Address",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Address_AddressID",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_AddressID",
                table: "Customer");
        }
    }
}
