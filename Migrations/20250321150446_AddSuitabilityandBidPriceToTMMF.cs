using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityProject.Migrations
{
    public partial class AddSuitabilityandBidPriceToTMMF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "bidprice",
                table: "TMMF",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "suitability",
                table: "TMMF",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bidprice",
                table: "TMMF");

            migrationBuilder.DropColumn(
                name: "suitability",
                table: "TMMF");
        }
    }
}
