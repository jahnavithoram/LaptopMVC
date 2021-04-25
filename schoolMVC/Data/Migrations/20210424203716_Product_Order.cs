using Microsoft.EntityFrameworkCore.Migrations;

namespace schoolMVC.Data.Migrations
{
    public partial class Product_Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderModel",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    SellerName = table.Column<string>(nullable: true),
                    prize = table.Column<double>(nullable: false),
                    CustomerName = table.Column<string>(nullable: true),
                    CustomerADD = table.Column<string>(nullable: true),
                    CustomerContact = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderModel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductModel",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    SellerName = table.Column<string>(nullable: true),
                    prize = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductModel", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderModel");

            migrationBuilder.DropTable(
                name: "ProductModel");
        }
    }
}
