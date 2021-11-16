using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Stock.ExchangeAPI.Migrations
{
    public partial class mopo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IPODetails");

            migrationBuilder.CreateTable(
                name: "Ipo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IpoCompanyName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    StockExchange = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalShares = table.Column<int>(type: "int", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ipo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Price",
                columns: table => new
                {
                    PriceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pricestock = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockExchange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Price", x => x.PriceId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ipo");

            migrationBuilder.DropTable(
                name: "Price");

            migrationBuilder.CreateTable(
                name: "IPODetails",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IPOCompanyName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Pricepershare = table.Column<int>(type: "int", nullable: false),
                    StockExchange = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalShares = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPODetails", x => x.ItemId);
                });
        }
    }
}
