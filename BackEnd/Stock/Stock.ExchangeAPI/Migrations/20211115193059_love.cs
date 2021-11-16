using Microsoft.EntityFrameworkCore.Migrations;

namespace Stock.ExchangeAPI.Migrations
{
    public partial class love : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Price",
                newName: "CompanyCode");

            migrationBuilder.AlterColumn<double>(
                name: "Pricestock",
                table: "Price",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompanyCode",
                table: "Price",
                newName: "CompanyName");

            migrationBuilder.AlterColumn<int>(
                name: "Pricestock",
                table: "Price",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
