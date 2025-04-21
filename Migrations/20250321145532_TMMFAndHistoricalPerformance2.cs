using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityProject.Migrations
{
    public partial class TMMFAndHistoricalPerformance2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "portfolio_historicalperformance",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    portfolio_id = table.Column<int>(nullable: false),
                    productby = table.Column<string>(nullable: true),
                    year = table.Column<string>(nullable: true),
                    yield = table.Column<string>(nullable: true),
                    createdon = table.Column<DateTime>(nullable: true),
                    updatedon = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_portfolio_historicalperformance", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TMMF",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    abouttmmf = table.Column<string>(nullable: true),
                    managementfee = table.Column<string>(nullable: true),
                    howitworks = table.Column<string>(nullable: true),
                    yeartildate = table.Column<string>(nullable: true),
                    productname = table.Column<string>(nullable: true),
                    offerprice = table.Column<string>(nullable: true),
                    productby = table.Column<string>(nullable: true),
                    incomedistribution = table.Column<string>(nullable: true),
                    historicalperformance = table.Column<string>(nullable: true),
                    createdon = table.Column<DateTime>(nullable: true),
                    updatedon = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TMMF", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "portfolio_historicalperformance");

            migrationBuilder.DropTable(
                name: "TMMF");
        }
    }
}
