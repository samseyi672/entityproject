using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityProject.Migrations
{
    public partial class AddIdCardUtilityBillSignatureAndClientBank : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "asset_capital_insurance_clientbank",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    BankId = table.Column<string>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true),
                    AccountName = table.Column<string>(nullable: true),
                    UserType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asset_capital_insurance_clientbank", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "asset_capital_insurance_idcard",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    UserType = table.Column<string>(nullable: true),
                    Filepath = table.Column<string>(nullable: true),
                    inititated = table.Column<int>(nullable: false),
                    approvalstatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asset_capital_insurance_idcard", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "asset_capital_insurance_signature",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    UserType = table.Column<string>(nullable: true),
                    Filepath = table.Column<string>(nullable: true),
                    inititated = table.Column<int>(nullable: false),
                    approvalstatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asset_capital_insurance_signature", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "asset_capital_insurance_utilitybill",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    UserType = table.Column<string>(nullable: true),
                    Filepath = table.Column<string>(nullable: true),
                    inititated = table.Column<int>(nullable: false),
                    approvalstatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asset_capital_insurance_utilitybill", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "asset_capital_insurance_clientbank");

            migrationBuilder.DropTable(
                name: "asset_capital_insurance_idcard");

            migrationBuilder.DropTable(
                name: "asset_capital_insurance_signature");

            migrationBuilder.DropTable(
                name: "asset_capital_insurance_utilitybill");
        }
    }
}
