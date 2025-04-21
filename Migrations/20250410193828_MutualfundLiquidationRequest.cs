using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityProject.Migrations
{
    public partial class MutualfundLiquidationRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "asset_mutualfundliquidation",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserType = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    RedemptionAccount = table.Column<string>(nullable: true),
                    PartialOrFull = table.Column<bool>(nullable: false),
                    BankName = table.Column<string>(nullable: true),
                    InvestmentId = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asset_mutualfundliquidation", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "asset_mutualfundliquidation");
        }
    }
}
