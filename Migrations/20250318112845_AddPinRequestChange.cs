using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityProject.Migrations
{
    public partial class AddPinRequestChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "asset_capital_insurance_pinrequestchange",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    createdon = table.Column<DateTime>(nullable: true),
                    user_type = table.Column<string>(nullable: true),
                    request = table.Column<string>(nullable: true),
                    approvalstatus = table.Column<bool>(nullable: false),
                    initiated = table.Column<bool>(nullable: false),
                    userid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asset_capital_insurance_pinrequestchange", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "asset_capital_insurance_pinrequestchange");
        }
    }
}
