using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductInventoryApp.Migrations
{
    /// <inheritdoc />
    public partial class AmSchimbatInRomana : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StockQuantity",
                table: "Products",
                newName: "CantitateaStoc");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "Pret");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "Producator");

            migrationBuilder.RenameColumn(
                name: "Manufacturer",
                table: "Products",
                newName: "Nume");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Producator",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Pret",
                table: "Products",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Nume",
                table: "Products",
                newName: "Manufacturer");

            migrationBuilder.RenameColumn(
                name: "CantitateaStoc",
                table: "Products",
                newName: "StockQuantity");
        }
    }
}
