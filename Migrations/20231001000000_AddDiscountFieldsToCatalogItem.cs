using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopPorted.Migrations
{
    public partial class AddDiscountFieldsToCatalogItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiscountThreshold",
                table: "Catalog",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiscountPercentage",
                table: "Catalog",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountThreshold",
                table: "Catalog");

            migrationBuilder.DropColumn(
                name: "DiscountPercentage",
                table: "Catalog");
        }
    }
}
