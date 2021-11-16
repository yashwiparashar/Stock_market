using Microsoft.EntityFrameworkCore.Migrations;

namespace Stock.ExchangeAPI.Migrations
{
    public partial class mopooo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exchange_Company_CompanyId",
                table: "Exchange");

            migrationBuilder.DropIndex(
                name: "IX_Exchange_CompanyId",
                table: "Exchange");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Exchange");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Exchange",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Exchange_CompanyId",
                table: "Exchange",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exchange_Company_CompanyId",
                table: "Exchange",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
