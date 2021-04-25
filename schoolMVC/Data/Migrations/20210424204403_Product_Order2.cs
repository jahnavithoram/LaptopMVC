using Microsoft.EntityFrameworkCore.Migrations;

namespace schoolMVC.Data.Migrations
{
    public partial class Product_Order2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "ProductModel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "OrderModel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image",
                table: "ProductModel");

            migrationBuilder.DropColumn(
                name: "image",
                table: "OrderModel");
        }
    }
}
